using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace lab3
{
    public partial class Form1 : Form
    {
        static int k = 10;
        data data1 = new data(k);

        public Form1()
        {
            InitializeComponent();

            chartPlot(10, "Wind Speed, m/s");
        }

        private void chartPlot(int d, string legend)
        {
            chart1.Series["Series1"].Points.Clear();
            for(int j = 0; j <= k; j++)
            {
                chart1.Series["Series1"].Points.AddXY(j, data1.random(data1.random(d)));
            }
            if(checkBoxViewType.Checked)
            {
                chart1.Series["Series1"].ChartType= SeriesChartType.Spline;
            }
            else
            {
                chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            }

            chart1.Series["Series1"].IsValueShownAsLabel= true;
            chart1.Series["Series1"].LegendText = legend;
        }

        private void radioButtonHumodity_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonHumodity.Checked)
            {
                chartPlot(100, "Humidity");
            }
        }

        private void radioButtonTemperature_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTemperature.Checked)
            {
                chartPlot(30, "Temperature");
            }
        }

        private void radioButtonWind_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWind.Checked)
            {
                chartPlot(10, "Wind Speed, m/s");
            }
        }

       
    }
}
