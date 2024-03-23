using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5C
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSetInterval_Click(object sender, EventArgs e)
        {
            IntervalSet intervalSet = new IntervalSet();
            if(intervalSet.ShowDialog() != DialogResult.OK) { return; }
            StringBuilder stringBuilder = new StringBuilder();
            
            for (decimal x = intervalSet.minValue; x <= intervalSet.maxValue; x += intervalSet.Step) 
            {
                stringBuilder.Append("Value Sin("+x+"): "+" "+Math.Sin((double)x)+"\n");
            };
            richTextBox1.Text=stringBuilder.ToString();
            labelIntervalMinMax.Text = "Sin(x[rad]) from " + intervalSet.minValue + " " + "to " + intervalSet.maxValue;
        }
    }
}
