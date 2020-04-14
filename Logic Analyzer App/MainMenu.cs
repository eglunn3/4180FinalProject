using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Logic_Analyzer_App
{
    public partial class MainMenu : Form
    {
        public SerialPort Port;
        public bool PortOpen = false;
        public bool DigOpen = false;
        public string[] portnames;
        public string theCOM = "";
        
        /// <testing>
        
        /// </testing>


        public int numberCOM;
        public MainMenu()
        {
            InitializeComponent();
            portnames = SerialPort.GetPortNames();
            foreach (string portname in portnames)
            {
                comboBox1.Items.Add(portname);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DigOpen)
            {
                MessageBox.Show("This port is alreay connected. To continue, you must select a differe port.", "Serial Port Error");
            }
            else
            {
                numberCOM = comboBox1.SelectedIndex;
                theCOM = portnames[numberCOM];
                

            }
        }

        private void DigitalRead_Click(object sender, EventArgs e)
        {

            DigOpen = this.IsMdiContainer;
            if (!DigOpen & !string.IsNullOrEmpty(theCOM))
            {
                Digital dig = new Digital(theCOM, DigOpen);
                dig.Show();
                dig.DigOpen = true;
                DigOpen = dig.DigOpen;

            }
            else
            {
                if (PortOpen)
                { 
                    MessageBox.Show("Serial port connection already established.", "Serial Port Error"); 
                }
                else if (DigOpen)
                {
                    MessageBox.Show("Try exiting Digital Program", "Program already open");
                }
                else if (string.IsNullOrEmpty(theCOM))
                {
                    MessageBox.Show("Bad connection to serial port.", "Serial Port Error");
                }
                else
                {
                    //MessageBox.Show("Undescribed Behavior", "Undescribed Behavior");
                }
            }
        }
    }
}
