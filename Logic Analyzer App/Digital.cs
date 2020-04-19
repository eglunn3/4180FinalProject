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
        static bool _readon;
        static int pinNum1;
        static int pinNum2;
        static int pinNum3;
        static int pinNum4;
        static int pinNum5;
        static string mbed;
        static string text1;
        //Thread readThread = new Thread(Read);
        public delegate void DisplaySerial(string mbedstuff);
        public DisplaySerial mbedSerial;

        public Digital(string ComPort, bool IsOpen)
        {

            InitializeComponent();

            if (!IsOpen & !string.IsNullOrEmpty(ComPort))
            {
                Port = new SerialPort(ComPort, 9600, Parity.None, 8, StopBits.One);
                Port.Open();
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

        private void Pin1Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string activePin1 = this.Pin1Combo.GetItemText(this.Pin1Combo.SelectedItem);
            int pinNUM1 = (this.Pin1Combo.SelectedIndex);
            bits[0] = 0x30;
        }

        private void Digital_FormClosing(object sender, FormClosingEventArgs e)
        {
            DigOpen = false;
            Port.Close();
        }

        private void Pin2Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pinNUM2 = (this.Pin2Combo.SelectedIndex);
            bits[0] = 0x30;
        }

        private void Pin3Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pinNUM3 = (this.Pin3Combo.SelectedIndex);
            bits[0] = 0x30;
        }

        private void Pin4Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pinNUM4 = (this.Pin4Combo.SelectedIndex);
            bits[0] = 0x30;
        }

        private void Pin5Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pinNUM5 = (this.Pin5Combo.SelectedIndex);
            bits[0] = 0x30;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            bits[2] = bits[0] = 0x30; //first and third bit in array tell mbed to read data and to use digital
            //_readon = true;//serial communication ready, used in Read thread
            //readThread.Start();//starts thread
            //Port.Write(ConvertStringArrayToString(bits));//tells mbed to start
            Port.Write("00100000");
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            bits[0] = bits[1] = bits[2] = bits[3] = bits[4] = bits[5] = bits[6] = bits[7] = 0; //sets the R bit to 0 to stop digital collection
            //_readon = false; //tells the Read thead to stop
            //Port.Write(ConvertStringArrayToString(bits)); //tells mbed to stop
            Port.Write("0x00");

        }
        private void Pin1Out_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void SerialtoTextMethod(int thestring)
        {
            Pin1Out.Text = thestring.ToString();
        }

        private void YouveGotCereal(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int mbedstuff = Port.ReadChar();
            Invoke(mbedSerial, mbedstuff);
        }

        //public static void Read() // Read thread is for serial communication with the mbed
        //{
        //    while (_readon)
        //    {
        //        try
        //        {
        //            mbed = Port.ReadExisting();

        //        }
        //        catch { }
        //    }
        //}

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
    }
}
