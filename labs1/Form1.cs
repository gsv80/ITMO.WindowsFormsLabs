using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labs1
{
    public partial class Form1 : Form
    {

        nForm myF;
        public Form1()
        {
            InitializeComponent();
            myF = new nForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(600, 600);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            try { 
               myF.Show();
               myF.Activate();
            }
            catch(ObjectDisposedException ex) {
                myF = new nForm();
                myF.Text = "New opened window";
                myF.Show();
                myF.Activate();

            }
            myF.StartPosition = FormStartPosition.Manual;
            myF.Location = new Point(this.Location.X + this.Width + 20, this.Location.Y);

        }
    }
}
