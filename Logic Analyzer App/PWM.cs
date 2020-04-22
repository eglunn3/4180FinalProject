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
    public partial class PWM : Form
    {
        public PWM(string ComPort)
        {
            InitializeComponent();
            
            Port.PortName = ComPort;
            Port.Open();
        }
    }
}
