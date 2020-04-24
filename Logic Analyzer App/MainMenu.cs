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
        public bool I2COpen = false; 
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DigOpen)
            {
                MessageBox.Show("This port is alreay connected. To continue, you must select a different port.", "Serial Port Error");
            }
            else
            {
                numberCOM = comboBox1.SelectedIndex;
                theCOM = portnames[numberCOM];
                

            }
        }

        private void DigitalRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(theCOM))
                {
                    Digital dig = new Digital(theCOM, DigOpen);
                    dig.StartPosition = FormStartPosition.CenterScreen;
                    dig.Show();

                }
                else
                {
                    MessageBox.Show("No serial port selected. Please select an unused serial port.", "Serial Port Error");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("This port is already in use. To use this port, close the current window. Otherwise, select a different port.", "Serial Port Error");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }


        private void I2CSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(theCOM))
                {
                    I2C I2CWindow = new I2C(theCOM);
                    I2CWindow.StartPosition = FormStartPosition.CenterScreen;
                    I2CWindow.Show();
                }
                else
                {
                    MessageBox.Show("No serial port selected. Please select an unused serial port.", "Serial Port Error");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("This port is already in use. To use this port, close the current window. Otherwise, select a different port.", "Serial Port Error");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error! If you see this message, a serious unknown problem has occured.\n Please report what happened and what lead up to this erorr. ");
            }

        }

        private void AnalogSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(theCOM))
                {
                    Analog AnnaBanana = new Analog(theCOM);
                    AnnaBanana.StartPosition = FormStartPosition.CenterScreen;
                    AnnaBanana.Show();
                }
                else
                {
                    MessageBox.Show("No serial port selected. Please select an unused serial port.", "Serial Port Error");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("This port is already in use. To use this port, close the current window. Otherwise, select a different port.", "Serial Port Error");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error! If you see this message, a serious unknown problem has occured.\n Please report what happened and what lead up to this erorr. ");
            }
        }

        private void PWMButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(theCOM))
                {
                    Scope ScopeWindow = new Scope(theCOM);
                    ScopeWindow.StartPosition = FormStartPosition.CenterScreen;
                    ScopeWindow.Show();
                }
                else
                {
                    MessageBox.Show("No serial port selected. Please select an unused serial port.", "Serial Port Error");
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("This port is already in use. To use this port, close the current window. Otherwise, select a different port.", "Serial Port Error");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error! If you see this message, a serious unknown problem has occured.\n Please report what happened and what lead up to this erorr. ");
            }
        }
    }
}
