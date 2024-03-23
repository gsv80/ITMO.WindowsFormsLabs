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
    public partial class EditValues : Form
    {
        public EditValues()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form1 form1 = this.Owner as Form1;

            try
            {
                form1.a = double.Parse(textBoxA.Text);
                form1.b = double.Parse(textBoxB.Text);
                form1.DataA = textBoxA.Text;
                form1.DataB = textBoxB.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured + \n" + ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
            form1.Refresh();

        }
    }
}
