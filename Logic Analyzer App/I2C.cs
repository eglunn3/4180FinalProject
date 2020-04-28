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
    public partial class I2C : Form
    {
        byte[] byteme = new byte[1] { 0 }; //string used for mbed communication
        bool IwasRunnin = false;
        delegate void DisplaySerial(int mbedstuff);
        DisplaySerial mbedBAD;
        List<Int32> dygraph = new List<Int32>();
        List<double> time = new List<double>();
        bool StopThePresses = false;
        double timespace = 50E-6;
        bool FirstCereal = true;
        List<ToolTipInfo> HexStor = new List<ToolTipInfo>();
        uint Total4s = 0;
        uint ScanTrack = 0;
        public I2C(string ComPort)
        {
            InitializeComponent();
            Port.PortName = ComPort;
            mbedBAD = new DisplaySerial(SerialtoTextMethod);
            Port.Open();
            Port.Encoding = Encoding.GetEncoding(1252);
            Port.ReceivedBytesThreshold = 1;
        }
        private void I2C_FormClosing(object sender, FormClosingEventArgs e)
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
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

        private void I2CStart_Click(object sender, EventArgs e)
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

            switch (I2CTimeSelect.SelectedIndex)
            {
                case 0: byteme[0] += 0; break;
                case 1: byteme[0] += 1; break;
                case 2: byteme[0] += 2; break;
                case 3: byteme[0] += 3; break;
                case 4: byteme[0] += 4; break;
                case 5: byteme[0] += 5; break;
                case 6: byteme[0] += 6; break;
                case 7: byteme[0] += 7; break;
                default: MessageBox.Show("Please Select a Time Duration.", "Error: No Time Duration Selected.", MessageBoxButtons.OK, MessageBoxIcon.Error); return; break;
            }
            byteme[0] += 0; //Always on the fall start, since start command

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
            temp = ((double)TheValue / 254.0);
            if (temp > 1)
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
            else if (temp > 0.5 && temp < 1)
            {
                dygraph.Add(1);
            }
            else if (temp < 0.5)
            {
                dygraph.Add(0);
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
                I2CDisplay.Series["SDA"].Points.DataBindXY(time, dygraph);
            }
            catch
            {
                MessageBox.Show("Critical error: Mismatch of time/dygraph. Please restart the program and try again.", "Error: Invalid lengths of list objects.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if ((dygraph.Count - 1) % 9 == 0)
            {
                HexStor.Add(new ToolTipInfo { TimeLoc = time[dygraph.Count - 1 - 5], HexInfo = "20", ArrayTrack = dygraph.Count - 1 - 5 }); 
                HexStor.Add(new ToolTipInfo { TimeLoc = time[dygraph.Count - 1 - 1], HexInfo = "20", ArrayTrack = dygraph.Count - 1 - 1 });
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

        private void I2CStop_Click(object sender, EventArgs e)
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

        private void I2CDisplay_GetToolTipText(object sender, System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs e)
        {
            var working = new ToolTipInfo();
            working=HexStor.Find(f=> e.X==f.TimeLoc);
            if (working.HexInfo != "20")
            {
                e.Text = working.HexInfo;
                return;
            }
            string find = dygraph[working.ArrayTrack-3].ToString()+ dygraph[working.ArrayTrack - 2].ToString()+dygraph[working.ArrayTrack - 1].ToString() + dygraph[working.ArrayTrack].ToString();
            HexDetect(find,working);
            e.Text = working.HexInfo;
        }
        private void HexDetect(String find, ToolTipInfo stor)
        {
            switch (find)
            {
                case "0000": stor.HexInfo = "0x0"; break;
                case "0001": stor.HexInfo = "0x1"; break;
                case "0010": stor.HexInfo = "0x2"; break;
                case "0011": stor.HexInfo = "0x3"; break;
                case "0100": stor.HexInfo = "0x4"; break;
                case "0101": stor.HexInfo = "0x5"; break;
                case "0110": stor.HexInfo = "0x6"; break;
                case "0111": stor.HexInfo = "0x7"; break;
                case "1000": stor.HexInfo = "0x8"; break;
                case "1001": stor.HexInfo = "0x9"; break;
                case "1010": stor.HexInfo = "0xA"; break;
                case "1011": stor.HexInfo = "0xB"; break;
                case "1100": stor.HexInfo = "0xC"; break;
                case "1101": stor.HexInfo = "0xD"; break;
                case "1110": stor.HexInfo = "0xE"; break;
                case "1111": stor.HexInfo = "0xF"; break;
            }
        }
     
    
    }
}