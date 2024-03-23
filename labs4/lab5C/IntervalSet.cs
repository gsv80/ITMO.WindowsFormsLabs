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
    public partial class IntervalSet : Form
    {
        private const double V = 0.1;
        public decimal Step = (decimal)V;
        public decimal minValue
        {
            get { return (decimal)numericUpDownMin.Value; }
            set { numericUpDownMin.Value = (decimal)value; }
        }

        public decimal maxValue
        {
            get { return (decimal)numericUpDownMax.Value; }
            set { numericUpDownMax.Value = (decimal)value; }
        }

        public IntervalSet()
        {
            InitializeComponent();
            
            numericUpDownMin.Increment = Step;
            numericUpDownMax.Increment = Step;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this.minValue = (decimal)numericUpDownMin.Value;
            this.maxValue = (decimal)numericUpDownMax.Value;
        }
    }
}
