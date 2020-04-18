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
        List<UInt16> dygraph = new List<UInt16>();
        List<string> trev = new List<string>();
        public I2C()
        {
            InitializeComponent();
        }

        private void I2CChart_Click(object sender, EventArgs e)
        {
            trev.Add(DateTime.Now.ToString());
            dygraph.Add(1); //Add data 
            trev.Add(DateTime.Now.ToString());
            dygraph.Add(0);
            trev.Add(DateTime.Now.ToString());
            dygraph.Add(1);
            trev.Add(DateTime.Now.ToString());
            dygraph.Add(0);
            I2CChart.Series["I2C"].Points.DataBindXY(trev, dygraph); //Update graph
        }
    }
}
