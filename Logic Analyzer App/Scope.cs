using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//TODO: Double check IwasRunning turn off
namespace Logic_Analyzer_App
{
    public partial class Scope : Form
    {
        byte[] byteme = new byte[1] { 0 }; //string used for mbed communication
        int count = 1;
        bool IwasRunnin = false;
        delegate void DisplaySerial(int mbedstuff);
        DisplaySerial mbedBAD;
        List<float> dygraph = new List<float>();
        List<float> time = new List<float>(); 
        bool StopThePresses = false;
        float timespace = 0.0f;
        bool FirstCereal = true;
        public Scope(string ComPort)
        {
            InitializeComponent();
            Port.PortName = ComPort;
            mbedBAD = new DisplaySerial(SerialtoTextMethod);
            Port.Open();
            Port.Encoding = Encoding.GetEncoding(1252);
            ScopeDisplay.Series["PWMShow"].Points.DataBindY(dygraph);
            //PWMDisplay.DataSource = dygraph; //Change to XY binding and disable X indexing when time implemented
        }
        private void PWM_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (IwasRunnin)
            {
                // Display a MsgBox asking the user to save changes or abort.
                if (MessageBox.Show("The scope is still running. Do you want to close the form?", "Close Scope Application",
                   MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;
                    // Call method to save file...
                }
                else
                {
                    try
                    {
                        byteme[0] = 0;
                        Port.Write(byteme, 0, 1); //sends reset value before the window closes
                        Port.Close();
                    }
                    catch
                    {
                        byteme[0] = 0;
                        Port.Close();
                    }
                }
            }
        }

        private void PWMStart_Click(object sender, EventArgs e)
        {
            byteme[0] = 0;
            dygraph.Clear();
            try
            {
                Port.Write(byteme, 0, 1);
            }
            catch
            {
                MessageBox.Show("Error: Serial Port Down. Did you disconnect the MBED?", "Error: MBED Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            byteme[0] += 128;
            
            switch (ScopeTimeSelect.SelectedIndex)
            {
                case 0: byteme[0] += 0; timespace = 0.001f;  break;
                case 1: byteme[0] += 1; timespace = 0.005f;  break;
                case 2: byteme[0] += 2; timespace = 0.01f;   break;
                case 3: byteme[0] += 3; timespace = 0.05f;   break;
                case 4: byteme[0] += 4; timespace = 0.1f;    break;
                case 5: byteme[0] += 5; timespace = 0.25f;   break;
                case 6: byteme[0] += 6; timespace = 0.5f;    break;
                case 7: byteme[0] += 7; timespace = 1.0f;    break;
                default: MessageBox.Show("Please Select a Time Duration.", "Error: No Time Duration Selected.", MessageBoxButtons.OK, MessageBoxIcon.Error); return;  break;
            }
            switch (RFChoice.SelectedIndex)
            {
                case 0: byteme[0] += 16; break;
                case 1: byteme[0] += 0;  break;
                default: MessageBox.Show("Please Select a Trigger.", "Error: No Trigger Selected.", MessageBoxButtons.OK, MessageBoxIcon.Error); return;  break;
            }
            try
            {
                Port.Write(byteme, 0, 1); //Writing PWM selection to MBED
            }
            catch
            {
                MessageBox.Show("Error: Serial Port Down. Did you disconnect the MBED?", "Error: MBED Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            byteme[0] = 0;
            IwasRunnin = true;
            StopThePresses = false;
            FirstCereal = true;
        }
        public void SerialtoTextMethod(int TheValue)
        {
            float temp = 0;
            temp=((float)TheValue/254.0f)*3.3f;
            if (temp > 3.3)
            {
                try
                {
                    dygraph.Add(dygraph[dygraph.Count - 1]);
                } 
                catch
                {
                    dygraph.Add(0.0f);
                }
            }
            else
            {
                dygraph.Add(temp);
            }
            if (FirstCereal)
            {
                time.Add(0);
                FirstCereal = false;
            } else
            {
                time.Add(time[time.Count - 1] + timespace);
            }
            ScopeDisplay.Series["ScopeShow"].Points.DataBindXY(time,dygraph);
            if (Port.BytesToRead == 0)
            {
                IwasRunnin = false;
            }
        }
        private void CerealKiller(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (StopThePresses)
            {
                try
                {
                    Port.ReadChar(); //Dumping the data; the user doesn't care
                }
                catch
                {
                    return; //Assuming mbed disconnected why stop issued
                }
                return;
            }
            if (Port.BytesToRead == 0)
            
            Invoke(mbedBAD, Port.ReadChar());
           
        }

        private void PWMStop_Click(object sender, EventArgs e)
        {
            StopThePresses = true;
            MessageBox.Show("You have stopped the gathering and showing of data; please hold for the MBED to reset.", "Information: Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
            byteme[0] = 0;
            IwasRunnin = false;
            dygraph.Clear();
            dygraph.TrimExcess();
            try
            {
                Port.Write(byteme, 0, 1);
            }
            catch
            {
                MessageBox.Show("Error: MBED could not be reset.", "Error: Failed Reset", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FirstCereal = false;
        }
    }
}
