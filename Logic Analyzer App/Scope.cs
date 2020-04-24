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
        public int count = 1;
        public bool IwasRunnin = false;
        public delegate void DisplaySerial(int mbedstuff);
        public DisplaySerial mbedBAD;
        List<int> dygraph = new List<int>();
        public Scope(string ComPort)
        {
            InitializeComponent();
            Port.PortName = ComPort;
            mbedBAD = new DisplaySerial(SerialtoTextMethod);
            Port.Open();
            Port.Encoding = Encoding.GetEncoding(1252);
            PWMDisplay.Series["PWMShow"].Points.DataBindY(dygraph);
            //PWMDisplay.DataSource = dygraph; //Change to XY binding and disable X indexing when time implemented
        }
        private void PWM_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (IwasRunnin)
            {
                // Display a MsgBox asking the user to save changes or abort.
                if (MessageBox.Show("The analog read is still running. Do you want to close the form?", "Close Analog Application",
                   MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;
                    // Call method to save file...
                }
                else
                {
                    byteme[0] = 0;
                    Port.Write(byteme, 0, 1); //sends reset value before the window closes
                    Port.Close();
                }
            }
        }

        private void PWMStart_Click(object sender, EventArgs e)
        {
            byteme[0] += 128;
            if (Int32.Parse(TrigVoltEnter.Text) > 3.3)
            {
                MessageBox.Show("Invalid Trigger Value. Try again from 0 to 3.3 V", "Error: Invalid Choice", MessageBoxButtons.OK);
                return;
            }
            switch (ScopeTimeSelect.SelectedIndex)
            {
                case 0: byteme[0] += 0; break;
                case 1: byteme[0] += 1; break;
                case 2: byteme[0] += 2; break;
                case 3: byteme[0] += 3; break;
                case 4: byteme[0] += 4; break;
                case 5: byteme[0] += 5; break;
                case 6: byteme[0] += 6; break;
                case 7: byteme[0] += 7; break;
            }
            switch (RFChoice.SelectedIndex)
            {
                case 0: byteme[0] += 16; break;
                case 1: byteme[0] += 0;  break; 
            }
            Port.Write(byteme, 0, 1); //Writing PWM selection to MBED
            byteme[0] = 0;
            IwasRunnin = true;
        }
        public void SerialtoTextMethod(int TheValue)
        {
            TheValue -= 40; 
          /*  if (TheValue > 1)
            {
                MessageBox.Show("Invalid Number Received. Please make sure only using PWMs that range from 0 to 1.\nIf you are super sure you are, please file a bug report", "Error: Invalid Number!", MessageBoxButtons.OK);
                IwasRunnin = false;
                byteme[0] = 0;
                Port.Write(byteme, 0, 1); 
                Port.Close();
                MessageBox.Show("Please restart the PWM window.", "PWM Restart", MessageBoxButtons.OK);
            }*/
            dygraph.Add(TheValue);
            PWMDisplay.Series["PWMShow"].Points.DataBindY(dygraph);
        }
        private void CerealKiller(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Invoke(mbedBAD, Port.ReadChar());
        }

    }
}
