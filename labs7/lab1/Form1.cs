﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("The input field should contain digits only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int i;
            i = int.Parse(e.Argument.ToString());
            for(int j = 0; j <= i; j++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                System.Threading.Thread.Sleep(1000);
                backgroundWorker1.ReportProgress((int)(j*100/i));
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(!(e.Cancelled)) 
            {
                MessageBox.Show("Operation completed","Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation camcelled");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(!(textBox1.Text == ""))
            {
                int i = int.Parse(textBox1.Text);
                backgroundWorker1.RunWorkerAsync(i);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}
