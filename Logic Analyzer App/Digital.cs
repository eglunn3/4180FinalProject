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
// Is 5 too many or too few?
// I was thinking user selects from predetermined pins in combo box
namespace Logic_Analyzer_App
{
    public partial class Digital : Form
    {
        public SerialPort Port;
        public bool DigOpen { get; set; }
        BitArray bitstowrite = new BitArray(8);
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
            int pinNUM = (this.Pin1Combo.SelectedIndex);
            bitstowrite[pinNUM + 3] = true;
        }

        private void Digital_FormClosing(object sender, FormClosingEventArgs e)
        {
            DigOpen = false;
            Port.Close();
        }

        private void Pin2Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pinNUM = (this.Pin2Combo.SelectedIndex);
            bitstowrite[pinNUM + 3] = true;
        }

        private void Pin3Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pinNUM = (this.Pin3Combo.SelectedIndex);
            bitstowrite[pinNUM + 3] = true;
        }

        private void Pin4Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pinNUM = (this.Pin4Combo.SelectedIndex);
            bitstowrite[pinNUM + 3] = true;
        }

        private void Pin5Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pinNUM = (this.Pin5Combo.SelectedIndex);
            bitstowrite[pinNUM + 3] = true;
        }
    }
}
