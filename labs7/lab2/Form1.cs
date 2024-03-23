using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        bool Cancel;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("The field should contain digits only","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void TimeConsumingMethod(int seconds)
        {
            for(int i = 0; i <= seconds; i++)
            {
                Thread.Sleep(1000);
                SetProgress((int)(i*100)/ seconds);
                if(Cancel)
                {
                    break;
                }
            }
            if(Cancel)
            {
                MessageBox.Show("Cancelled","Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Cancel = false;
            }
            else
            {
                MessageBox.Show("Completed", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private delegate void TimeConsumingMethodDelegate(int seconds);

        public delegate void SetProgressDelegate(int val);
        public void SetProgress(int val)
        {
            if(progressBar1.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value= val;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TimeConsumingMethodDelegate delegat = new TimeConsumingMethodDelegate(TimeConsumingMethod);
            delegat.BeginInvoke(int.Parse(textBox1.Text),null,null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }
    }
}
