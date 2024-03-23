using System;
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
    public partial class WinQuestion : Form
    {
        public WinQuestion()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exacctly as we thought");
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            btnNo.Top -= e.Y;
            btnNo.Left += e.X;
            if(btnNo.Top < -10|| btnNo.Top>450) 
            {
                btnNo.Top = 200;

            }
            if(btnNo.Left < -80|| btnNo.Left > 375)
            {
                btnNo.Left = 140;
            }
        }
    }
}
