using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7C
{
    public partial class EratoAlgForm : Form
    {
        public EratoAlgForm()
        {
            InitializeComponent();
        }

        public string GoButt()
        {
            int maxValue = 0;
            StringBuilder resultText = new StringBuilder();
            if(int.TryParse(MaxValueText.Text, out maxValue) )
            {
                for(int trial = 2;trial<=maxValue;trial++)
                {
                    bool isPrime = true;
                    for (int divider =2; divider<=Math.Sqrt(trial);divider++)
                    {
                        if(trial%divider==0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if(isPrime) 
                    {
                        resultText.AppendFormat("{0} ", trial);
                    }
                }
            }
            else
            {
                resultText.Append("Unnable to parse max value");
            }
            return resultText.ToString();
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
