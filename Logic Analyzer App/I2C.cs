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
        List<double> trev = new List<double>();
        public I2C()
        {
            InitializeComponent();
        }

        private void I2CChart_Click(object sender, EventArgs e)
        {
            trev.Add(TimeSpan.FromMilliseconds(0.001).TotalMilliseconds);
            dygraph.Add(1); //Add data 
            trev.Add(TimeSpan.FromMilliseconds(0.002).TotalMilliseconds);
            dygraph.Add(0);
            trev.Add(TimeSpan.FromMilliseconds(0.003).TotalMilliseconds);
            dygraph.Add(1);
            trev.Add(TimeSpan.FromMilliseconds(0.004).TotalMilliseconds);
            dygraph.Add(0);
            I2CChart.Series["I2C"].Points.DataBindXY(trev, dygraph); //Update graph
        }
    }
}
