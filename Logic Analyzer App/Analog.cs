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
        public delegate void DisplaySerial(int mbedstuff);
        public DisplaySerial mbedBAD;
        public Analog(string ComPort)
        {
            InitializeComponent();
            Port.PortName = ComPort;
            Port.Open();
        }

        private void Analog_Load(object sender, EventArgs e)
        {

        }

        private void Analog_FormClosing(object sender, FormClosingEventArgs e)
        {
            byteme[0] = 0;
            Port.Write( byteme , 0, 1); //sends reset value before the window closes
            Port.Close();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            byteme[0] = 64; //Number corresponding to analog
            if (Pin16_Select.Checked) { byteme[0] += 16;}
            if (Pin17_Select.Checked) { byteme[0] += 8; }
            if (Pin18_Select.Checked) { byteme[0] += 4; }
            if (Pin19_Select.Checked) { byteme[0] += 2; }
            if (Pin20_Select.Checked) { byteme[0] += 1; }
            Port.Write(byteme, 0, 1); //writes analog select and selected pin to serial port
            byteme[0] = 0;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            byteme[0] = 0;

            Port.Write(byteme, 0, 1); //sends reset value
        }

        private void CerealKiller(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int mbedstuff = Port.ReadChar();
            if (mbedstuff == 255) { count = 1; }
            else
            {

                Invoke(mbedBAD, mbedstuff);
            }

        }

        public void SerialtoTextMethod(int TheValue)
        {
            ++count;
            if (count > 7) { count = 1; }
            float ShowMe = TheValue;
            if ((count == 2) & Pin16_Select.Checked)
            {

            }
            if ((count == 3) & Pin17_Select.Checked)
            {

            }
            if ((count == 4) & Pin18_Select.Checked)
            {

            }
            if ((count == 5) & Pin19_Select.Checked)
            {

            }
            if ((count == 6) & Pin20_Select.Checked)
            {

            }
        }
    }
}
