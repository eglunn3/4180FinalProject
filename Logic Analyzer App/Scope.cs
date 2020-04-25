using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Logic_Analyzer_App
{
    public partial class Scope : Form
    {
        byte[] byteme = new byte[1] { 0 }; //string used for mbed communication
        bool IwasRunnin = false;
        delegate void DisplaySerial(int mbedstuff);
        DisplaySerial mbedBAD;
        List<double> dygraph = new List<double>();
        List<double> time = new List<double>(); 
        bool StopThePresses = false;
        double timespace = 50E-6;
        bool FirstCereal = true;
        public Scope(string ComPort)
        {
            InitializeComponent();
            Port.PortName = ComPort;
            mbedBAD = new DisplaySerial(SerialtoTextMethod);
            Port.Open();
            Port.Encoding = Encoding.GetEncoding(1252);
            Port.ReceivedBytesThreshold = 1; 
        }
        private void Scope_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Port.IsOpen)
            {
                IwasRunnin = false;
            }
            else if (Port.BytesToRead > 0)
            {
                IwasRunnin = true;
            } 
            else
            {
                IwasRunnin = false;
            }
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

        private void ScopeStart_Click(object sender, EventArgs e)
        {
            byteme[0] = 0;
            dygraph.Clear();
            time.Clear();
            dygraph.TrimExcess();
            time.TrimExcess();
            Port.DiscardInBuffer();
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
                case 0: byteme[0] += 0;  break;
                case 1: byteme[0] += 1;  break;
                case 2: byteme[0] += 2;  break;
                case 3: byteme[0] += 3;  break;
                case 4: byteme[0] += 4;  break;
                case 5: byteme[0] += 5;  break;
                case 6: byteme[0] += 6;  break;
                case 7: byteme[0] += 7;  break;
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
                Port.Write(byteme, 0, 1); //Writing Scope selection to MBED
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
          double temp = 0;
          temp = ((double)TheValue / 254.0) * 3.3;
          if (temp > 3.3)
           {
             try
             {
              dygraph.Add(dygraph[dygraph.Count - 1]);
              }
             catch
             {
             dygraph.Add(0);
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
           }
           else
           {
                time.Add(time[time.Count - 1] + timespace);
           }
           try
            {
                ScopeDisplay.Series["ScopeShow"].Points.DataBindXY(time, dygraph);
            }
            catch
            {
                MessageBox.Show("Critical error: Mismatch of time/dygraph. Please restart the program and try again.","Error: Invalid lengths of list objects.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void CerealKiller(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (StopThePresses)
            {
                try
                {
                    Port.DiscardInBuffer(); //Dumping the data; the user doesn't care
                }
                catch
                {
                    return; //Assuming mbed disconnected why stop issued
                }
                return;
            }
            while (Port.BytesToRead > 0)
            {
                Invoke(mbedBAD, Port.ReadChar());
            }
        }

        private void ScopeStop_Click(object sender, EventArgs e)
        {
            StopThePresses = true;
            MessageBox.Show("You have stopped the gathering and showing of data; please hold for the MBED to reset.", "Information: Stop", MessageBoxButtons.OK, MessageBoxIcon.Information);
            byteme[0] = 0;
            IwasRunnin = false;
            dygraph.Clear();
            time.Clear();
            dygraph.TrimExcess();
            time.TrimExcess();
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
