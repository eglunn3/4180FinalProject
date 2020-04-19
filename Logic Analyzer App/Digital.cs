using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
// Is 5 too many or too few?
// I was thinking user selects from predetermined pins in combo box
namespace Logic_Analyzer_App
{
    public partial class Digital : Form
    {
        static SerialPort Port;
        public bool DigOpen { get; set; }
        byte[] bits = new byte[1] { 0 }; //string used for mbed communication
        static int pinNum1;
        static int pinNum2;
        static int pinNum3;
        static int pinNum4;
        static int pinNum5;
        static string mbed;
        //Thread readThread = new Thread(Read);
        public delegate void DisplaySerial(int mbedstuff);
        public DisplaySerial mbedSerial;

        public Digital(string ComPort, bool IsOpen)
        {

            InitializeComponent();
            mbedSerial = new DisplaySerial(SerialtoTextMethod);

            if (!IsOpen & !string.IsNullOrEmpty(ComPort))
            {
                Port = new SerialPort(ComPort, 9600, Parity.None, 8, StopBits.One);
                Port.Open();
                Port.DataReceived += new SerialDataReceivedEventHandler(YouveGotCereal);
                IsOpen = true;
                
            }
            else if(IsOpen)
            {
                MessageBox.Show("Serial port connection already established.", "Serial Port Error");
                this.Close();
            }
            else if(string.IsNullOrEmpty(ComPort))
            {
                MessageBox.Show("Must Select a port to continue.", "Serial Port Error");
            }
            else
            {
                MessageBox.Show("Unhandled Behavior", "Unknown");
            }

        }

        private void Digital_Load(object sender, EventArgs e)
        {

        }


        private void Digital_FormClosing(object sender, FormClosingEventArgs e)
        {
            DigOpen = false;
            bits[0] = 0;
            Port.Write(bits, 0, 1);
            Port.Close();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            bits[0] += 32; //first and third bit in array tell mbed to read data and to use digital
            if (Pin21_Select.Checked) { bits[0] += 16; }
            if (Pin22_Select.Checked) { bits[0] += 8; } 
            if (Pin23_Select.Checked) { bits[0] += 4; }
            if (Pin24_Select.Checked) { bits[0] += 2; }
            if (Pin25_Select.Checked) { bits[0] += 1; }
            //_readon = true;//serial communication ready, used in Read thread
            //readThread.Start();//starts thread
            //Port.Write(ConvertStringArrayToString(bits));//tells mbed to start
            Port.Write(bits, 0, 1);
            bits[0] = 0; //Clears the bits
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            bits[0] = 0; //sets the R bit to 0 to stop digital collection
                         //Port.Write(ConvertStringArrayToString(bits)); //tells mbed to stop
            if (Pin21_Select.Checked) { Pin1Out.Text = "0"; } else { Pin1Out.Text = ""; }
            if (Pin22_Select.Checked) { Pin2Out.Text = "0"; } else { Pin2Out.Text = ""; }
            if (Pin23_Select.Checked) { Pin3Out.Text = "0"; } else { Pin3Out.Text = ""; }
            if (Pin24_Select.Checked) { Pin4Out.Text = "0"; } else { Pin4Out.Text = ""; }
            if (Pin25_Select.Checked) { Pin5Out.Text = "0"; } else { Pin5Out.Text = ""; }
            Port.Write(bits, 0, 1);


        }
        private void Pin1Out_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void SerialtoTextMethod(int thestring)
        {
            thestring -= 32;
            if (thestring >= 16)
            {
                Pin1Out.Text = "High";
                thestring -= 16;
            }
            else if (thestring >= 8)
            {
                Pin2Out.Text = "High";
                thestring -= 8;
            }
            else if (thestring >= 4)
            {
                Pin3Out.Text = "High";
                thestring -= 4;
            }
            else if (thestring >= 2)
            {
                Pin4Out.Text = "High";
                thestring -= 2;
            }
            else if (thestring > 0)
            {
                Pin5Out.Text = "High";
                thestring -= 1;
            }
            else
            {
                if (Pin21_Select.Checked) { Pin1Out.Text = "0"; } else { Pin1Out.Text = ""; }
                if (Pin22_Select.Checked) { Pin2Out.Text = "0"; } else { Pin2Out.Text = ""; }
                if (Pin23_Select.Checked) { Pin3Out.Text = "0"; } else { Pin3Out.Text = ""; }
                if (Pin24_Select.Checked) { Pin4Out.Text = "0"; } else { Pin4Out.Text = ""; }
                if (Pin25_Select.Checked) { Pin5Out.Text = "0"; } else { Pin5Out.Text = ""; }
            }
            
        }

        private void YouveGotCereal(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            int mbedstuff = Port.ReadChar();
            Invoke(mbedSerial, mbedstuff);
        }


        static string ConvertStringArrayToString(string[] array) //converts the string array to one string for serial communication
        {   //this was found online, thought it would be easy to use but have not verified its output
            // Concatenate all the elements into a StringBuilder.
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }

        private void Pin21_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (Pin21_Select.Checked)
            { 
                bits[0] += 16;
                Pin1Out.Text = "0";
            }
            else
            {
                Pin1Out.Text = "";
            }
            
        }


        private void Pin22_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (Pin22_Select.Checked)
            {
                bits[0] += 8;
                Pin2Out.Text = "0";
            }
            else
            {
                Pin2Out.Text = "";
            }
                
        }

        private void Pin23_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (Pin23_Select.Checked)
            { bits[0] += 4; Pin3Out.Text = "0"; }
            else
            { Pin3Out.Text = ""; }
        }
        private void Pin24_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (Pin24_Select.Checked)
            { bits[0] += 2; Pin4Out.Text = "0"; }
            else
            { Pin4Out.Text = ""; }
                
        }

        private void Pin25_Select_CheckedChanged(object sender, EventArgs e)
        {
            if (Pin25_Select.Checked)
            { bits[0] += 1; Pin5Out.Text = "0"; }
            else
            { Pin5Out.Text = ""; }
        }
        
    }
}
