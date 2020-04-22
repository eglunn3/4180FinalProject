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
    public partial class Analog : Form
    {
        byte[] byteme = new byte[1] { 0 }; //string used for mbed communication
        public int count = 1;
        public bool IwasRunnin = false;
        public double last2 = 3.3;
        public double last3 = 3.3;
        public double last4 = 3.3;
        public double last5 = 3.3;
        public double last6 = 3.3;
        public delegate void DisplaySerial(int mbedstuff);
        public DisplaySerial mbedBAD;
        public Analog(string ComPort)
        {
            InitializeComponent();
            mbedBAD = new DisplaySerial(SerialtoTextMethod);
            Port.PortName = ComPort;
            
            Port.Open();
            Port.Encoding = Encoding.GetEncoding(1252);
            //Port.DataReceived += new SerialDataReceivedEventHandler(CerealKiller);
            
        }

        private void Analog_Load(object sender, EventArgs e)
        {

        }

        private void Analog_FormClosing(object sender, FormClosingEventArgs e)
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

        private void StartButton_Click(object sender, EventArgs e)
        {
            byteme[0] += 64; //Number corresponding to analog
            if (Pin16_Select.Checked) { byteme[0] += 16;}
            if (Pin17_Select.Checked) { byteme[0] += 8; }
            if (Pin18_Select.Checked) { byteme[0] += 4; }
            if (Pin19_Select.Checked) { byteme[0] += 2; }
            if (Pin20_Select.Checked) { byteme[0] += 1; }
            Port.Write(byteme, 0, 1); //writes analog select and selected pin to serial port
            byteme[0] = 0;
            IwasRunnin = true;

            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            byteme[0] = 0;
            Port.Write(byteme, 0, 1); //sends reset value
            IwasRunnin = false;
            {
                Pin16_Value.Text = "";
                Pin17_Value.Text = "";
                Pin18_Value.Text = "";
                Pin19_Value.Text = "";
                Pin20_Value.Text = "";

                Pin16_03.BackColor = SystemColors.Control;
                Pin17_03.BackColor = SystemColors.Control;
                Pin18_03.BackColor = SystemColors.Control;
                Pin19_03.BackColor = SystemColors.Control;
                Pin20_03.BackColor = SystemColors.Control;

                Pin16_06.BackColor = SystemColors.Control;
                Pin17_06.BackColor = SystemColors.Control;
                Pin18_06.BackColor = SystemColors.Control;
                Pin19_06.BackColor = SystemColors.Control;
                Pin20_06.BackColor = SystemColors.Control;

                Pin16_09.BackColor = SystemColors.Control;
                Pin17_09.BackColor = SystemColors.Control;
                Pin18_09.BackColor = SystemColors.Control;
                Pin19_09.BackColor = SystemColors.Control;
                Pin20_09.BackColor = SystemColors.Control;

                Pin16_12.BackColor = SystemColors.Control;
                Pin17_12.BackColor = SystemColors.Control;
                Pin18_12.BackColor = SystemColors.Control;
                Pin19_12.BackColor = SystemColors.Control;
                Pin20_12.BackColor = SystemColors.Control;

                Pin16_15.BackColor = SystemColors.Control;
                Pin17_15.BackColor = SystemColors.Control;
                Pin18_15.BackColor = SystemColors.Control;
                Pin19_15.BackColor = SystemColors.Control;
                Pin20_15.BackColor = SystemColors.Control;

                Pin16_18.BackColor = SystemColors.Control;
                Pin17_18.BackColor = SystemColors.Control;
                Pin18_18.BackColor = SystemColors.Control;
                Pin19_18.BackColor = SystemColors.Control;
                Pin20_18.BackColor = SystemColors.Control;

                Pin16_21.BackColor = SystemColors.Control;
                Pin17_21.BackColor = SystemColors.Control;
                Pin18_21.BackColor = SystemColors.Control;
                Pin19_21.BackColor = SystemColors.Control;
                Pin20_21.BackColor = SystemColors.Control;

                Pin16_24.BackColor = SystemColors.Control;
                Pin17_24.BackColor = SystemColors.Control;
                Pin18_24.BackColor = SystemColors.Control;
                Pin19_24.BackColor = SystemColors.Control;
                Pin20_24.BackColor = SystemColors.Control;

                Pin16_27.BackColor = SystemColors.Control;
                Pin17_27.BackColor = SystemColors.Control;
                Pin18_27.BackColor = SystemColors.Control;
                Pin19_27.BackColor = SystemColors.Control;
                Pin20_27.BackColor = SystemColors.Control;

                Pin16_30.BackColor = SystemColors.Control;
                Pin17_30.BackColor = SystemColors.Control;
                Pin18_30.BackColor = SystemColors.Control;
                Pin19_30.BackColor = SystemColors.Control;
                Pin20_30.BackColor = SystemColors.Control;

                Pin16_33.BackColor = SystemColors.Control;
                Pin17_33.BackColor = SystemColors.Control;
                Pin18_33.BackColor = SystemColors.Control;
                Pin19_33.BackColor = SystemColors.Control;
                Pin20_33.BackColor = SystemColors.Control;
            }
        }

        private void CerealKiller(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int mbedstuff1 = Port.ReadChar();//start bit, should be 255
            int mbedstuff2 = Port.ReadChar();
            int mbedstuff3 = Port.ReadChar();
            int mbedstuff4 = Port.ReadChar();
            int mbedstuff5 = Port.ReadChar();
            int mbedstuff6 = Port.ReadChar();
            int mbedstuff7 = Port.ReadChar();//stop bit should be equal to the command
            Invoke(mbedBAD, mbedstuff2);
            Invoke(mbedBAD, mbedstuff3);
            Invoke(mbedBAD, mbedstuff4);
            Invoke(mbedBAD, mbedstuff5);
            Invoke(mbedBAD, mbedstuff6);

        }

        public void SerialtoTextMethod(int TheValue)
        {
            count++;
            if (count > 6) { count = 2; }
            //Pin16_Value.Text = Convert.ToString(TheValue);
            double ShowMe = TheValue;
            ShowMe *= (3.3d/254);
            if ((count == 2) & Pin16_Select.Checked)
            {
                ShowMe = Math.Ceiling(ShowMe * 100) / 100;
                if (ShowMe > 3.3d) { ShowMe = last2; }
                Pin16_Value.Text = ShowMe.ToString();
                if (ShowMe >= 3.3d ) 
                { 
                    Pin16_03.BackColor = SystemColors.Highlight;
                    Pin16_06.BackColor = SystemColors.Highlight;
                    Pin16_09.BackColor = SystemColors.Highlight;
                    Pin16_12.BackColor = SystemColors.Highlight;
                    Pin16_15.BackColor = SystemColors.Highlight;
                    Pin16_18.BackColor = SystemColors.Highlight;
                    Pin16_21.BackColor = SystemColors.Highlight;
                    Pin16_24.BackColor = SystemColors.Highlight;
                    Pin16_27.BackColor = SystemColors.Highlight;
                    Pin16_30.BackColor = SystemColors.Highlight;
                    Pin16_33.BackColor = SystemColors.Highlight;
                }
                else if (ShowMe >= 3.0d)
                {
                    Pin16_03.BackColor = SystemColors.Highlight;
                    Pin16_06.BackColor = SystemColors.Highlight;
                    Pin16_09.BackColor = SystemColors.Highlight;
                    Pin16_12.BackColor = SystemColors.Highlight;
                    Pin16_15.BackColor = SystemColors.Highlight;
                    Pin16_18.BackColor = SystemColors.Highlight;
                    Pin16_21.BackColor = SystemColors.Highlight;
                    Pin16_24.BackColor = SystemColors.Highlight;
                    Pin16_27.BackColor = SystemColors.Highlight;
                    Pin16_30.BackColor = SystemColors.Highlight;
                    Pin16_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.7d)
                {
                    Pin16_03.BackColor = SystemColors.Highlight;
                    Pin16_06.BackColor = SystemColors.Highlight;
                    Pin16_09.BackColor = SystemColors.Highlight;
                    Pin16_12.BackColor = SystemColors.Highlight;
                    Pin16_15.BackColor = SystemColors.Highlight;
                    Pin16_18.BackColor = SystemColors.Highlight;
                    Pin16_21.BackColor = SystemColors.Highlight;
                    Pin16_24.BackColor = SystemColors.Highlight;
                    Pin16_27.BackColor = SystemColors.Highlight;
                    Pin16_30.BackColor = SystemColors.Control;
                    Pin16_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.4d)
                {
                    Pin16_03.BackColor = SystemColors.Highlight;
                    Pin16_06.BackColor = SystemColors.Highlight;
                    Pin16_09.BackColor = SystemColors.Highlight;
                    Pin16_12.BackColor = SystemColors.Highlight;
                    Pin16_15.BackColor = SystemColors.Highlight;
                    Pin16_18.BackColor = SystemColors.Highlight;
                    Pin16_21.BackColor = SystemColors.Highlight;
                    Pin16_24.BackColor = SystemColors.Highlight;
                    Pin16_27.BackColor = SystemColors.Control;
                    Pin16_30.BackColor = SystemColors.Control;
                    Pin16_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.1d)
                {
                    Pin16_03.BackColor = SystemColors.Highlight;
                    Pin16_06.BackColor = SystemColors.Highlight;
                    Pin16_09.BackColor = SystemColors.Highlight;
                    Pin16_12.BackColor = SystemColors.Highlight;
                    Pin16_15.BackColor = SystemColors.Highlight;
                    Pin16_18.BackColor = SystemColors.Highlight;
                    Pin16_21.BackColor = SystemColors.Highlight;
                    Pin16_24.BackColor = SystemColors.Control;
                    Pin16_27.BackColor = SystemColors.Control;
                    Pin16_30.BackColor = SystemColors.Control;
                    Pin16_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.8d)
                {
                    Pin16_03.BackColor = SystemColors.Highlight;
                    Pin16_06.BackColor = SystemColors.Highlight;
                    Pin16_09.BackColor = SystemColors.Highlight;
                    Pin16_12.BackColor = SystemColors.Highlight;
                    Pin16_15.BackColor = SystemColors.Highlight;
                    Pin16_18.BackColor = SystemColors.Highlight;
                    Pin16_21.BackColor = SystemColors.Control;
                    Pin16_24.BackColor = SystemColors.Control;
                    Pin16_27.BackColor = SystemColors.Control;
                    Pin16_30.BackColor = SystemColors.Control;
                    Pin16_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.5d)
                {
                    Pin16_03.BackColor = SystemColors.Highlight;
                    Pin16_06.BackColor = SystemColors.Highlight;
                    Pin16_09.BackColor = SystemColors.Highlight;
                    Pin16_12.BackColor = SystemColors.Highlight;
                    Pin16_15.BackColor = SystemColors.Highlight;
                    Pin16_18.BackColor = SystemColors.Control;
                    Pin16_21.BackColor = SystemColors.Control;
                    Pin16_24.BackColor = SystemColors.Control;
                    Pin16_27.BackColor = SystemColors.Control;
                    Pin16_30.BackColor = SystemColors.Control;
                    Pin16_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.2d)
                {
                    Pin16_03.BackColor = SystemColors.Highlight;
                    Pin16_06.BackColor = SystemColors.Highlight;
                    Pin16_09.BackColor = SystemColors.Highlight;
                    Pin16_12.BackColor = SystemColors.Highlight;
                    Pin16_15.BackColor = SystemColors.Control;
                    Pin16_18.BackColor = SystemColors.Control;
                    Pin16_21.BackColor = SystemColors.Control;
                    Pin16_24.BackColor = SystemColors.Control;
                    Pin16_27.BackColor = SystemColors.Control;
                    Pin16_30.BackColor = SystemColors.Control;
                    Pin16_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.9d)
                {
                    Pin16_03.BackColor = SystemColors.Highlight;
                    Pin16_06.BackColor = SystemColors.Highlight;
                    Pin16_09.BackColor = SystemColors.Highlight;
                    Pin16_12.BackColor = SystemColors.Control;
                    Pin16_15.BackColor = SystemColors.Control;
                    Pin16_18.BackColor = SystemColors.Control;
                    Pin16_21.BackColor = SystemColors.Control;
                    Pin16_24.BackColor = SystemColors.Control;
                    Pin16_27.BackColor = SystemColors.Control;
                    Pin16_30.BackColor = SystemColors.Control;
                    Pin16_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.6d)
                {
                    Pin16_03.BackColor = SystemColors.Highlight;
                    Pin16_06.BackColor = SystemColors.Highlight;
                    Pin16_09.BackColor = SystemColors.Control;
                    Pin16_12.BackColor = SystemColors.Control;
                    Pin16_15.BackColor = SystemColors.Control;
                    Pin16_18.BackColor = SystemColors.Control;
                    Pin16_21.BackColor = SystemColors.Control;
                    Pin16_24.BackColor = SystemColors.Control;
                    Pin16_27.BackColor = SystemColors.Control;
                    Pin16_30.BackColor = SystemColors.Control;
                    Pin16_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.3d)
                {
                    Pin16_03.BackColor = SystemColors.Highlight;
                    Pin16_06.BackColor = SystemColors.Control;
                    Pin16_09.BackColor = SystemColors.Control;
                    Pin16_12.BackColor = SystemColors.Control;
                    Pin16_15.BackColor = SystemColors.Control;
                    Pin16_18.BackColor = SystemColors.Control;
                    Pin16_21.BackColor = SystemColors.Control;
                    Pin16_24.BackColor = SystemColors.Control;
                    Pin16_27.BackColor = SystemColors.Control;
                    Pin16_30.BackColor = SystemColors.Control;
                    Pin16_33.BackColor = SystemColors.Control;
                }
                else
                {
                    Pin16_03.BackColor = SystemColors.Control;
                    Pin16_06.BackColor = SystemColors.Control;
                    Pin16_09.BackColor = SystemColors.Control;
                    Pin16_12.BackColor = SystemColors.Control;
                    Pin16_15.BackColor = SystemColors.Control;
                    Pin16_18.BackColor = SystemColors.Control;
                    Pin16_21.BackColor = SystemColors.Control;
                    Pin16_24.BackColor = SystemColors.Control;
                    Pin16_27.BackColor = SystemColors.Control;
                    Pin16_30.BackColor = SystemColors.Control;
                    Pin16_33.BackColor = SystemColors.Control;
                }
                last2 = ShowMe;
            }
            else if ((count == 3) & Pin17_Select.Checked)
            {
                ShowMe = Math.Ceiling(ShowMe * 100) / 100;
                if (ShowMe > 3.3d) { ShowMe = last3; }
                Pin17_Value.Text = ShowMe.ToString();
                if (ShowMe >= 3.3d)
                {
                    Pin17_03.BackColor = SystemColors.Highlight;
                    Pin17_06.BackColor = SystemColors.Highlight;
                    Pin17_09.BackColor = SystemColors.Highlight;
                    Pin17_12.BackColor = SystemColors.Highlight;
                    Pin17_15.BackColor = SystemColors.Highlight;
                    Pin17_18.BackColor = SystemColors.Highlight;
                    Pin17_21.BackColor = SystemColors.Highlight;
                    Pin17_24.BackColor = SystemColors.Highlight;
                    Pin17_27.BackColor = SystemColors.Highlight;
                    Pin17_30.BackColor = SystemColors.Highlight;
                    Pin17_33.BackColor = SystemColors.Highlight;
                }
                else if (ShowMe >= 3.0d)
                {
                    Pin17_03.BackColor = SystemColors.Highlight;
                    Pin17_06.BackColor = SystemColors.Highlight;
                    Pin17_09.BackColor = SystemColors.Highlight;
                    Pin17_12.BackColor = SystemColors.Highlight;
                    Pin17_15.BackColor = SystemColors.Highlight;
                    Pin17_18.BackColor = SystemColors.Highlight;
                    Pin17_21.BackColor = SystemColors.Highlight;
                    Pin17_24.BackColor = SystemColors.Highlight;
                    Pin17_27.BackColor = SystemColors.Highlight;
                    Pin17_30.BackColor = SystemColors.Highlight;
                    Pin17_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.7d)
                {
                    Pin17_03.BackColor = SystemColors.Highlight;
                    Pin17_06.BackColor = SystemColors.Highlight;
                    Pin17_09.BackColor = SystemColors.Highlight;
                    Pin17_12.BackColor = SystemColors.Highlight;
                    Pin17_15.BackColor = SystemColors.Highlight;
                    Pin17_18.BackColor = SystemColors.Highlight;
                    Pin17_21.BackColor = SystemColors.Highlight;
                    Pin17_24.BackColor = SystemColors.Highlight;
                    Pin17_27.BackColor = SystemColors.Highlight;
                    Pin17_30.BackColor = SystemColors.Control;
                    Pin17_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.4d)
                {
                    Pin17_03.BackColor = SystemColors.Highlight;
                    Pin17_06.BackColor = SystemColors.Highlight;
                    Pin17_09.BackColor = SystemColors.Highlight;
                    Pin17_12.BackColor = SystemColors.Highlight;
                    Pin17_15.BackColor = SystemColors.Highlight;
                    Pin17_18.BackColor = SystemColors.Highlight;
                    Pin17_21.BackColor = SystemColors.Highlight;
                    Pin17_24.BackColor = SystemColors.Highlight;
                    Pin17_27.BackColor = SystemColors.Control;
                    Pin17_30.BackColor = SystemColors.Control;
                    Pin17_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.1d)
                {
                    Pin17_03.BackColor = SystemColors.Highlight;
                    Pin17_06.BackColor = SystemColors.Highlight;
                    Pin17_09.BackColor = SystemColors.Highlight;
                    Pin17_12.BackColor = SystemColors.Highlight;
                    Pin17_15.BackColor = SystemColors.Highlight;
                    Pin17_18.BackColor = SystemColors.Highlight;
                    Pin17_21.BackColor = SystemColors.Highlight;
                    Pin17_24.BackColor = SystemColors.Control;
                    Pin17_27.BackColor = SystemColors.Control;
                    Pin17_30.BackColor = SystemColors.Control;
                    Pin17_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.8d)
                {
                    Pin17_03.BackColor = SystemColors.Highlight;
                    Pin17_06.BackColor = SystemColors.Highlight;
                    Pin17_09.BackColor = SystemColors.Highlight;
                    Pin17_12.BackColor = SystemColors.Highlight;
                    Pin17_15.BackColor = SystemColors.Highlight;
                    Pin17_18.BackColor = SystemColors.Highlight;
                    Pin17_21.BackColor = SystemColors.Control;
                    Pin17_24.BackColor = SystemColors.Control;
                    Pin17_27.BackColor = SystemColors.Control;
                    Pin17_30.BackColor = SystemColors.Control;
                    Pin17_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.5d)
                {
                    Pin17_03.BackColor = SystemColors.Highlight;
                    Pin17_06.BackColor = SystemColors.Highlight;
                    Pin17_09.BackColor = SystemColors.Highlight;
                    Pin17_12.BackColor = SystemColors.Highlight;
                    Pin17_15.BackColor = SystemColors.Highlight;
                    Pin17_18.BackColor = SystemColors.Control;
                    Pin17_21.BackColor = SystemColors.Control;
                    Pin17_24.BackColor = SystemColors.Control;
                    Pin17_27.BackColor = SystemColors.Control;
                    Pin17_30.BackColor = SystemColors.Control;
                    Pin17_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.2d)
                {
                    Pin17_03.BackColor = SystemColors.Highlight;
                    Pin17_06.BackColor = SystemColors.Highlight;
                    Pin17_09.BackColor = SystemColors.Highlight;
                    Pin17_12.BackColor = SystemColors.Highlight;
                    Pin17_15.BackColor = SystemColors.Control;
                    Pin17_18.BackColor = SystemColors.Control;
                    Pin17_21.BackColor = SystemColors.Control;
                    Pin17_24.BackColor = SystemColors.Control;
                    Pin17_27.BackColor = SystemColors.Control;
                    Pin17_30.BackColor = SystemColors.Control;
                    Pin17_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.9d)
                {
                    Pin17_03.BackColor = SystemColors.Highlight;
                    Pin17_06.BackColor = SystemColors.Highlight;
                    Pin17_09.BackColor = SystemColors.Highlight;
                    Pin17_12.BackColor = SystemColors.Control;
                    Pin17_15.BackColor = SystemColors.Control;
                    Pin17_18.BackColor = SystemColors.Control;
                    Pin17_21.BackColor = SystemColors.Control;
                    Pin17_24.BackColor = SystemColors.Control;
                    Pin17_27.BackColor = SystemColors.Control;
                    Pin17_30.BackColor = SystemColors.Control;
                    Pin17_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.6d)
                {
                    Pin17_03.BackColor = SystemColors.Highlight;
                    Pin17_06.BackColor = SystemColors.Highlight;
                    Pin17_09.BackColor = SystemColors.Control;
                    Pin17_12.BackColor = SystemColors.Control;
                    Pin17_15.BackColor = SystemColors.Control;
                    Pin17_18.BackColor = SystemColors.Control;
                    Pin17_21.BackColor = SystemColors.Control;
                    Pin17_24.BackColor = SystemColors.Control;
                    Pin17_27.BackColor = SystemColors.Control;
                    Pin17_30.BackColor = SystemColors.Control;
                    Pin17_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.3d)
                {
                    Pin17_03.BackColor = SystemColors.Highlight;
                    Pin17_06.BackColor = SystemColors.Control;
                    Pin17_09.BackColor = SystemColors.Control;
                    Pin17_12.BackColor = SystemColors.Control;
                    Pin17_15.BackColor = SystemColors.Control;
                    Pin17_18.BackColor = SystemColors.Control;
                    Pin17_21.BackColor = SystemColors.Control;
                    Pin17_24.BackColor = SystemColors.Control;
                    Pin17_27.BackColor = SystemColors.Control;
                    Pin17_30.BackColor = SystemColors.Control;
                    Pin17_33.BackColor = SystemColors.Control;
                }
                else
                {
                    Pin17_03.BackColor = SystemColors.Control;
                    Pin17_06.BackColor = SystemColors.Control;
                    Pin17_09.BackColor = SystemColors.Control;
                    Pin17_12.BackColor = SystemColors.Control;
                    Pin17_15.BackColor = SystemColors.Control;
                    Pin17_18.BackColor = SystemColors.Control;
                    Pin17_21.BackColor = SystemColors.Control;
                    Pin17_24.BackColor = SystemColors.Control;
                    Pin17_27.BackColor = SystemColors.Control;
                    Pin17_30.BackColor = SystemColors.Control;
                    Pin17_33.BackColor = SystemColors.Control;
                }
                last3 = ShowMe;
            }
            else if ((count == 4) & Pin18_Select.Checked)
            {
                ShowMe = Math.Ceiling(ShowMe * 100) / 100;
                if (ShowMe > 3.3d) { ShowMe = last4; }
                Pin18_Value.Text = ShowMe.ToString();
                if (ShowMe >= 3.3d)
                {
                    Pin18_03.BackColor = SystemColors.Highlight;
                    Pin18_06.BackColor = SystemColors.Highlight;
                    Pin18_09.BackColor = SystemColors.Highlight;
                    Pin18_12.BackColor = SystemColors.Highlight;
                    Pin18_15.BackColor = SystemColors.Highlight;
                    Pin18_18.BackColor = SystemColors.Highlight;
                    Pin18_21.BackColor = SystemColors.Highlight;
                    Pin18_24.BackColor = SystemColors.Highlight;
                    Pin18_27.BackColor = SystemColors.Highlight;
                    Pin18_30.BackColor = SystemColors.Highlight;
                    Pin18_33.BackColor = SystemColors.Highlight;
                }
                else if (ShowMe >= 3.0d)
                {
                    Pin18_03.BackColor = SystemColors.Highlight;
                    Pin18_06.BackColor = SystemColors.Highlight;
                    Pin18_09.BackColor = SystemColors.Highlight;
                    Pin18_12.BackColor = SystemColors.Highlight;
                    Pin18_15.BackColor = SystemColors.Highlight;
                    Pin18_18.BackColor = SystemColors.Highlight;
                    Pin18_21.BackColor = SystemColors.Highlight;
                    Pin18_24.BackColor = SystemColors.Highlight;
                    Pin18_27.BackColor = SystemColors.Highlight;
                    Pin18_30.BackColor = SystemColors.Highlight;
                    Pin18_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.7d)
                {
                    Pin18_03.BackColor = SystemColors.Highlight;
                    Pin18_06.BackColor = SystemColors.Highlight;
                    Pin18_09.BackColor = SystemColors.Highlight;
                    Pin18_12.BackColor = SystemColors.Highlight;
                    Pin18_15.BackColor = SystemColors.Highlight;
                    Pin18_18.BackColor = SystemColors.Highlight;
                    Pin18_21.BackColor = SystemColors.Highlight;
                    Pin18_24.BackColor = SystemColors.Highlight;
                    Pin18_27.BackColor = SystemColors.Highlight;
                    Pin18_30.BackColor = SystemColors.Control;
                    Pin18_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.4d)
                {
                    Pin18_03.BackColor = SystemColors.Highlight;
                    Pin18_06.BackColor = SystemColors.Highlight;
                    Pin18_09.BackColor = SystemColors.Highlight;
                    Pin18_12.BackColor = SystemColors.Highlight;
                    Pin18_15.BackColor = SystemColors.Highlight;
                    Pin18_18.BackColor = SystemColors.Highlight;
                    Pin18_21.BackColor = SystemColors.Highlight;
                    Pin18_24.BackColor = SystemColors.Highlight;
                    Pin18_27.BackColor = SystemColors.Control;
                    Pin18_30.BackColor = SystemColors.Control;
                    Pin18_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.1d)
                {
                    Pin18_03.BackColor = SystemColors.Highlight;
                    Pin18_06.BackColor = SystemColors.Highlight;
                    Pin18_09.BackColor = SystemColors.Highlight;
                    Pin18_12.BackColor = SystemColors.Highlight;
                    Pin18_15.BackColor = SystemColors.Highlight;
                    Pin18_18.BackColor = SystemColors.Highlight;
                    Pin18_21.BackColor = SystemColors.Highlight;
                    Pin18_24.BackColor = SystemColors.Control;
                    Pin18_27.BackColor = SystemColors.Control;
                    Pin18_30.BackColor = SystemColors.Control;
                    Pin18_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.8d)
                {
                    Pin18_03.BackColor = SystemColors.Highlight;
                    Pin18_06.BackColor = SystemColors.Highlight;
                    Pin18_09.BackColor = SystemColors.Highlight;
                    Pin18_12.BackColor = SystemColors.Highlight;
                    Pin18_15.BackColor = SystemColors.Highlight;
                    Pin18_18.BackColor = SystemColors.Highlight;
                    Pin18_21.BackColor = SystemColors.Control;
                    Pin18_24.BackColor = SystemColors.Control;
                    Pin18_27.BackColor = SystemColors.Control;
                    Pin18_30.BackColor = SystemColors.Control;
                    Pin18_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.5d)
                {
                    Pin18_03.BackColor = SystemColors.Highlight;
                    Pin18_06.BackColor = SystemColors.Highlight;
                    Pin18_09.BackColor = SystemColors.Highlight;
                    Pin18_12.BackColor = SystemColors.Highlight;
                    Pin18_15.BackColor = SystemColors.Highlight;
                    Pin18_18.BackColor = SystemColors.Control;
                    Pin18_21.BackColor = SystemColors.Control;
                    Pin18_24.BackColor = SystemColors.Control;
                    Pin18_27.BackColor = SystemColors.Control;
                    Pin18_30.BackColor = SystemColors.Control;
                    Pin18_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.2d)
                {
                    Pin18_03.BackColor = SystemColors.Highlight;
                    Pin18_06.BackColor = SystemColors.Highlight;
                    Pin18_09.BackColor = SystemColors.Highlight;
                    Pin18_12.BackColor = SystemColors.Highlight;
                    Pin18_15.BackColor = SystemColors.Control;
                    Pin18_18.BackColor = SystemColors.Control;
                    Pin18_21.BackColor = SystemColors.Control;
                    Pin18_24.BackColor = SystemColors.Control;
                    Pin18_27.BackColor = SystemColors.Control;
                    Pin18_30.BackColor = SystemColors.Control;
                    Pin18_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.9d)
                {
                    Pin18_03.BackColor = SystemColors.Highlight;
                    Pin18_06.BackColor = SystemColors.Highlight;
                    Pin18_09.BackColor = SystemColors.Highlight;
                    Pin18_12.BackColor = SystemColors.Control;
                    Pin18_15.BackColor = SystemColors.Control;
                    Pin18_18.BackColor = SystemColors.Control;
                    Pin18_21.BackColor = SystemColors.Control;
                    Pin18_24.BackColor = SystemColors.Control;
                    Pin18_27.BackColor = SystemColors.Control;
                    Pin18_30.BackColor = SystemColors.Control;
                    Pin18_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.6d)
                {
                    Pin18_03.BackColor = SystemColors.Highlight;
                    Pin18_06.BackColor = SystemColors.Highlight;
                    Pin18_09.BackColor = SystemColors.Control;
                    Pin18_12.BackColor = SystemColors.Control;
                    Pin18_15.BackColor = SystemColors.Control;
                    Pin18_18.BackColor = SystemColors.Control;
                    Pin18_21.BackColor = SystemColors.Control;
                    Pin18_24.BackColor = SystemColors.Control;
                    Pin18_27.BackColor = SystemColors.Control;
                    Pin18_30.BackColor = SystemColors.Control;
                    Pin18_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.3d)
                {
                    Pin18_03.BackColor = SystemColors.Highlight;
                    Pin18_06.BackColor = SystemColors.Control;
                    Pin18_09.BackColor = SystemColors.Control;
                    Pin18_12.BackColor = SystemColors.Control;
                    Pin18_15.BackColor = SystemColors.Control;
                    Pin18_18.BackColor = SystemColors.Control;
                    Pin18_21.BackColor = SystemColors.Control;
                    Pin18_24.BackColor = SystemColors.Control;
                    Pin18_27.BackColor = SystemColors.Control;
                    Pin18_30.BackColor = SystemColors.Control;
                    Pin18_33.BackColor = SystemColors.Control;
                }
                else
                {
                    Pin18_03.BackColor = SystemColors.Control;
                    Pin18_06.BackColor = SystemColors.Control;
                    Pin18_09.BackColor = SystemColors.Control;
                    Pin18_12.BackColor = SystemColors.Control;
                    Pin18_15.BackColor = SystemColors.Control;
                    Pin18_18.BackColor = SystemColors.Control;
                    Pin18_21.BackColor = SystemColors.Control;
                    Pin18_24.BackColor = SystemColors.Control;
                    Pin18_27.BackColor = SystemColors.Control;
                    Pin18_30.BackColor = SystemColors.Control;
                    Pin18_33.BackColor = SystemColors.Control;
                }
                last4 = ShowMe;
            }
            else if ((count == 5) & Pin19_Select.Checked)
            {
                ShowMe = Math.Ceiling(ShowMe * 100) / 100;
                if (ShowMe > 3.3d) { ShowMe = last5; }
                Pin19_Value.Text = ShowMe.ToString();
                if (ShowMe >= 3.3d)
                {
                    Pin19_03.BackColor = SystemColors.Highlight;
                    Pin19_06.BackColor = SystemColors.Highlight;
                    Pin19_09.BackColor = SystemColors.Highlight;
                    Pin19_12.BackColor = SystemColors.Highlight;
                    Pin19_15.BackColor = SystemColors.Highlight;
                    Pin19_18.BackColor = SystemColors.Highlight;
                    Pin19_21.BackColor = SystemColors.Highlight;
                    Pin19_24.BackColor = SystemColors.Highlight;
                    Pin19_27.BackColor = SystemColors.Highlight;
                    Pin19_30.BackColor = SystemColors.Highlight;
                    Pin19_33.BackColor = SystemColors.Highlight;
                }
                else if (ShowMe >= 3.0d)
                {
                    Pin19_03.BackColor = SystemColors.Highlight;
                    Pin19_06.BackColor = SystemColors.Highlight;
                    Pin19_09.BackColor = SystemColors.Highlight;
                    Pin19_12.BackColor = SystemColors.Highlight;
                    Pin19_15.BackColor = SystemColors.Highlight;
                    Pin19_18.BackColor = SystemColors.Highlight;
                    Pin19_21.BackColor = SystemColors.Highlight;
                    Pin19_24.BackColor = SystemColors.Highlight;
                    Pin19_27.BackColor = SystemColors.Highlight;
                    Pin19_30.BackColor = SystemColors.Highlight;
                    Pin19_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.7d)
                {
                    Pin19_03.BackColor = SystemColors.Highlight;
                    Pin19_06.BackColor = SystemColors.Highlight;
                    Pin19_09.BackColor = SystemColors.Highlight;
                    Pin19_12.BackColor = SystemColors.Highlight;
                    Pin19_15.BackColor = SystemColors.Highlight;
                    Pin19_18.BackColor = SystemColors.Highlight;
                    Pin19_21.BackColor = SystemColors.Highlight;
                    Pin19_24.BackColor = SystemColors.Highlight;
                    Pin19_27.BackColor = SystemColors.Highlight;
                    Pin19_30.BackColor = SystemColors.Control;
                    Pin19_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.4d)
                {
                    Pin19_03.BackColor = SystemColors.Highlight;
                    Pin19_06.BackColor = SystemColors.Highlight;
                    Pin19_09.BackColor = SystemColors.Highlight;
                    Pin19_12.BackColor = SystemColors.Highlight;
                    Pin19_15.BackColor = SystemColors.Highlight;
                    Pin19_18.BackColor = SystemColors.Highlight;
                    Pin19_21.BackColor = SystemColors.Highlight;
                    Pin19_24.BackColor = SystemColors.Highlight;
                    Pin19_27.BackColor = SystemColors.Control;
                    Pin19_30.BackColor = SystemColors.Control;
                    Pin19_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.1d)
                {
                    Pin19_03.BackColor = SystemColors.Highlight;
                    Pin19_06.BackColor = SystemColors.Highlight;
                    Pin19_09.BackColor = SystemColors.Highlight;
                    Pin19_12.BackColor = SystemColors.Highlight;
                    Pin19_15.BackColor = SystemColors.Highlight;
                    Pin19_18.BackColor = SystemColors.Highlight;
                    Pin19_21.BackColor = SystemColors.Highlight;
                    Pin19_24.BackColor = SystemColors.Control;
                    Pin19_27.BackColor = SystemColors.Control;
                    Pin19_30.BackColor = SystemColors.Control;
                    Pin19_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.8d)
                {
                    Pin19_03.BackColor = SystemColors.Highlight;
                    Pin19_06.BackColor = SystemColors.Highlight;
                    Pin19_09.BackColor = SystemColors.Highlight;
                    Pin19_12.BackColor = SystemColors.Highlight;
                    Pin19_15.BackColor = SystemColors.Highlight;
                    Pin19_18.BackColor = SystemColors.Highlight;
                    Pin19_21.BackColor = SystemColors.Control;
                    Pin19_24.BackColor = SystemColors.Control;
                    Pin19_27.BackColor = SystemColors.Control;
                    Pin19_30.BackColor = SystemColors.Control;
                    Pin19_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.5d)
                {
                    Pin19_03.BackColor = SystemColors.Highlight;
                    Pin19_06.BackColor = SystemColors.Highlight;
                    Pin19_09.BackColor = SystemColors.Highlight;
                    Pin19_12.BackColor = SystemColors.Highlight;
                    Pin19_15.BackColor = SystemColors.Highlight;
                    Pin19_18.BackColor = SystemColors.Control;
                    Pin19_21.BackColor = SystemColors.Control;
                    Pin19_24.BackColor = SystemColors.Control;
                    Pin19_27.BackColor = SystemColors.Control;
                    Pin19_30.BackColor = SystemColors.Control;
                    Pin19_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.2d)
                {
                    Pin19_03.BackColor = SystemColors.Highlight;
                    Pin19_06.BackColor = SystemColors.Highlight;
                    Pin19_09.BackColor = SystemColors.Highlight;
                    Pin19_12.BackColor = SystemColors.Highlight;
                    Pin19_15.BackColor = SystemColors.Control;
                    Pin19_18.BackColor = SystemColors.Control;
                    Pin19_21.BackColor = SystemColors.Control;
                    Pin19_24.BackColor = SystemColors.Control;
                    Pin19_27.BackColor = SystemColors.Control;
                    Pin19_30.BackColor = SystemColors.Control;
                    Pin19_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.9d)
                {
                    Pin19_03.BackColor = SystemColors.Highlight;
                    Pin19_06.BackColor = SystemColors.Highlight;
                    Pin19_09.BackColor = SystemColors.Highlight;
                    Pin19_12.BackColor = SystemColors.Control;
                    Pin19_15.BackColor = SystemColors.Control;
                    Pin19_18.BackColor = SystemColors.Control;
                    Pin19_21.BackColor = SystemColors.Control;
                    Pin19_24.BackColor = SystemColors.Control;
                    Pin19_27.BackColor = SystemColors.Control;
                    Pin19_30.BackColor = SystemColors.Control;
                    Pin19_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.6d)
                {
                    Pin19_03.BackColor = SystemColors.Highlight;
                    Pin19_06.BackColor = SystemColors.Highlight;
                    Pin19_09.BackColor = SystemColors.Control;
                    Pin19_12.BackColor = SystemColors.Control;
                    Pin19_15.BackColor = SystemColors.Control;
                    Pin19_18.BackColor = SystemColors.Control;
                    Pin19_21.BackColor = SystemColors.Control;
                    Pin19_24.BackColor = SystemColors.Control;
                    Pin19_27.BackColor = SystemColors.Control;
                    Pin19_30.BackColor = SystemColors.Control;
                    Pin19_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.3d)
                {
                    Pin19_03.BackColor = SystemColors.Highlight;
                    Pin19_06.BackColor = SystemColors.Control;
                    Pin19_09.BackColor = SystemColors.Control;
                    Pin19_12.BackColor = SystemColors.Control;
                    Pin19_15.BackColor = SystemColors.Control;
                    Pin19_18.BackColor = SystemColors.Control;
                    Pin19_21.BackColor = SystemColors.Control;
                    Pin19_24.BackColor = SystemColors.Control;
                    Pin19_27.BackColor = SystemColors.Control;
                    Pin19_30.BackColor = SystemColors.Control;
                    Pin19_33.BackColor = SystemColors.Control;
                }
                else
                {
                    Pin19_03.BackColor = SystemColors.Control;
                    Pin19_06.BackColor = SystemColors.Control;
                    Pin19_09.BackColor = SystemColors.Control;
                    Pin19_12.BackColor = SystemColors.Control;
                    Pin19_15.BackColor = SystemColors.Control;
                    Pin19_18.BackColor = SystemColors.Control;
                    Pin19_21.BackColor = SystemColors.Control;
                    Pin19_24.BackColor = SystemColors.Control;
                    Pin19_27.BackColor = SystemColors.Control;
                    Pin19_30.BackColor = SystemColors.Control;
                    Pin19_33.BackColor = SystemColors.Control;
                }
                last5 = ShowMe;
            }
            else if ((count == 6) & Pin20_Select.Checked)
            {
                ShowMe = Math.Ceiling(ShowMe * 100) / 100;
                if (ShowMe > 3.3d) { ShowMe = last6; }
                Pin20_Value.Text = ShowMe.ToString();
                if (ShowMe >= 3.3d)
                {
                    Pin20_03.BackColor = SystemColors.Highlight;
                    Pin20_06.BackColor = SystemColors.Highlight;
                    Pin20_09.BackColor = SystemColors.Highlight;
                    Pin20_12.BackColor = SystemColors.Highlight;
                    Pin20_15.BackColor = SystemColors.Highlight;
                    Pin20_18.BackColor = SystemColors.Highlight;
                    Pin20_21.BackColor = SystemColors.Highlight;
                    Pin20_24.BackColor = SystemColors.Highlight;
                    Pin20_27.BackColor = SystemColors.Highlight;
                    Pin20_30.BackColor = SystemColors.Highlight;
                    Pin20_33.BackColor = SystemColors.Highlight;
                }
                else if (ShowMe >= 3.0d)
                {
                    Pin20_03.BackColor = SystemColors.Highlight;
                    Pin20_06.BackColor = SystemColors.Highlight;
                    Pin20_09.BackColor = SystemColors.Highlight;
                    Pin20_12.BackColor = SystemColors.Highlight;
                    Pin20_15.BackColor = SystemColors.Highlight;
                    Pin20_18.BackColor = SystemColors.Highlight;
                    Pin20_21.BackColor = SystemColors.Highlight;
                    Pin20_24.BackColor = SystemColors.Highlight;
                    Pin20_27.BackColor = SystemColors.Highlight;
                    Pin20_30.BackColor = SystemColors.Highlight;
                    Pin20_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.7d)
                {
                    Pin20_03.BackColor = SystemColors.Highlight;
                    Pin20_06.BackColor = SystemColors.Highlight;
                    Pin20_09.BackColor = SystemColors.Highlight;
                    Pin20_12.BackColor = SystemColors.Highlight;
                    Pin20_15.BackColor = SystemColors.Highlight;
                    Pin20_18.BackColor = SystemColors.Highlight;
                    Pin20_21.BackColor = SystemColors.Highlight;
                    Pin20_24.BackColor = SystemColors.Highlight;
                    Pin20_27.BackColor = SystemColors.Highlight;
                    Pin20_30.BackColor = SystemColors.Control;
                    Pin20_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.4d)
                {
                    Pin20_03.BackColor = SystemColors.Highlight;
                    Pin20_06.BackColor = SystemColors.Highlight;
                    Pin20_09.BackColor = SystemColors.Highlight;
                    Pin20_12.BackColor = SystemColors.Highlight;
                    Pin20_15.BackColor = SystemColors.Highlight;
                    Pin20_18.BackColor = SystemColors.Highlight;
                    Pin20_21.BackColor = SystemColors.Highlight;
                    Pin20_24.BackColor = SystemColors.Highlight;
                    Pin20_27.BackColor = SystemColors.Control;
                    Pin20_30.BackColor = SystemColors.Control;
                    Pin20_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 2.1d)
                {
                    Pin20_03.BackColor = SystemColors.Highlight;
                    Pin20_06.BackColor = SystemColors.Highlight;
                    Pin20_09.BackColor = SystemColors.Highlight;
                    Pin20_12.BackColor = SystemColors.Highlight;
                    Pin20_15.BackColor = SystemColors.Highlight;
                    Pin20_18.BackColor = SystemColors.Highlight;
                    Pin20_21.BackColor = SystemColors.Highlight;
                    Pin20_24.BackColor = SystemColors.Control;
                    Pin20_27.BackColor = SystemColors.Control;
                    Pin20_30.BackColor = SystemColors.Control;
                    Pin20_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.8d)
                {
                    Pin20_03.BackColor = SystemColors.Highlight;
                    Pin20_06.BackColor = SystemColors.Highlight;
                    Pin20_09.BackColor = SystemColors.Highlight;
                    Pin20_12.BackColor = SystemColors.Highlight;
                    Pin20_15.BackColor = SystemColors.Highlight;
                    Pin20_18.BackColor = SystemColors.Highlight;
                    Pin20_21.BackColor = SystemColors.Control;
                    Pin20_24.BackColor = SystemColors.Control;
                    Pin20_27.BackColor = SystemColors.Control;
                    Pin20_30.BackColor = SystemColors.Control;
                    Pin20_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.5d)
                {
                    Pin20_03.BackColor = SystemColors.Highlight;
                    Pin20_06.BackColor = SystemColors.Highlight;
                    Pin20_09.BackColor = SystemColors.Highlight;
                    Pin20_12.BackColor = SystemColors.Highlight;
                    Pin20_15.BackColor = SystemColors.Highlight;
                    Pin20_18.BackColor = SystemColors.Control;
                    Pin20_21.BackColor = SystemColors.Control;
                    Pin20_24.BackColor = SystemColors.Control;
                    Pin20_27.BackColor = SystemColors.Control;
                    Pin20_30.BackColor = SystemColors.Control;
                    Pin20_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 1.2d)
                {
                    Pin20_03.BackColor = SystemColors.Highlight;
                    Pin20_06.BackColor = SystemColors.Highlight;
                    Pin20_09.BackColor = SystemColors.Highlight;
                    Pin20_12.BackColor = SystemColors.Highlight;
                    Pin20_15.BackColor = SystemColors.Control;
                    Pin20_18.BackColor = SystemColors.Control;
                    Pin20_21.BackColor = SystemColors.Control;
                    Pin20_24.BackColor = SystemColors.Control;
                    Pin20_27.BackColor = SystemColors.Control;
                    Pin20_30.BackColor = SystemColors.Control;
                    Pin20_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.9d)
                {
                    Pin20_03.BackColor = SystemColors.Highlight;
                    Pin20_06.BackColor = SystemColors.Highlight;
                    Pin20_09.BackColor = SystemColors.Highlight;
                    Pin20_12.BackColor = SystemColors.Control;
                    Pin20_15.BackColor = SystemColors.Control;
                    Pin20_18.BackColor = SystemColors.Control;
                    Pin20_21.BackColor = SystemColors.Control;
                    Pin20_24.BackColor = SystemColors.Control;
                    Pin20_27.BackColor = SystemColors.Control;
                    Pin20_30.BackColor = SystemColors.Control;
                    Pin20_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.6d)
                {
                    Pin20_03.BackColor = SystemColors.Highlight;
                    Pin20_06.BackColor = SystemColors.Highlight;
                    Pin20_09.BackColor = SystemColors.Control;
                    Pin20_12.BackColor = SystemColors.Control;
                    Pin20_15.BackColor = SystemColors.Control;
                    Pin20_18.BackColor = SystemColors.Control;
                    Pin20_21.BackColor = SystemColors.Control;
                    Pin20_24.BackColor = SystemColors.Control;
                    Pin20_27.BackColor = SystemColors.Control;
                    Pin20_30.BackColor = SystemColors.Control;
                    Pin20_33.BackColor = SystemColors.Control;
                }
                else if (ShowMe >= 0.3d)
                {
                    Pin20_03.BackColor = SystemColors.Highlight;
                    Pin20_06.BackColor = SystemColors.Control;
                    Pin20_09.BackColor = SystemColors.Control;
                    Pin20_12.BackColor = SystemColors.Control;
                    Pin20_15.BackColor = SystemColors.Control;
                    Pin20_18.BackColor = SystemColors.Control;
                    Pin20_21.BackColor = SystemColors.Control;
                    Pin20_24.BackColor = SystemColors.Control;
                    Pin20_27.BackColor = SystemColors.Control;
                    Pin20_30.BackColor = SystemColors.Control;
                    Pin20_33.BackColor = SystemColors.Control;
                }
                else
                {
                    Pin20_03.BackColor = SystemColors.Control;
                    Pin20_06.BackColor = SystemColors.Control;
                    Pin20_09.BackColor = SystemColors.Control;
                    Pin20_12.BackColor = SystemColors.Control;
                    Pin20_15.BackColor = SystemColors.Control;
                    Pin20_18.BackColor = SystemColors.Control;
                    Pin20_21.BackColor = SystemColors.Control;
                    Pin20_24.BackColor = SystemColors.Control;
                    Pin20_27.BackColor = SystemColors.Control;
                    Pin20_30.BackColor = SystemColors.Control;
                    Pin20_33.BackColor = SystemColors.Control;
                }
                last6 = ShowMe;

            }
            //else
            //{
            //    if (!Pin16_Select.Checked) { Pin16_03.BackColor = SystemColors.Control; Pin16_Value.Text = ""; }
            //    if (!Pin17_Select.Checked) { Pin17_03.BackColor = SystemColors.Control; Pin17_Value.Text = ""; }
            //    if (!Pin18_Select.Checked) { Pin18_03.BackColor = SystemColors.Control; Pin18_Value.Text = ""; }
            //    if (!Pin19_Select.Checked) { Pin19_03.BackColor = SystemColors.Control; Pin19_Value.Text = ""; }
            //    if (!Pin20_Select.Checked) { Pin20_03.BackColor = SystemColors.Control; Pin20_Value.Text = ""; }
            //}
        }
    }
}
