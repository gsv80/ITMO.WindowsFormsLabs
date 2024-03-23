using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1C2
{
    public partial class nForm : Form
    {
        Form1 myForm;
        public nForm()
        {
            InitializeComponent();
            
            myForm = new Form1();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               myForm.Show();
               myForm.Activate();
            }
            catch (ObjectDisposedException ex)
            {
                myForm = new Form1();
                myForm.BackColor = Color.Blue;
                myForm.Show();
                myForm.Activate();
            }
        }

        private void nForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }
    }
}
