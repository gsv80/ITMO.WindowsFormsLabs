using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class FormInputText : Form
    {
        public FormInputText()
        {
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string s = textBoxStringOne.Text + " "+ textBoxStringTwo.Text + " "+ textBoxStringThree.Text + " ";
            FormMain frm1 = this.Owner as FormMain;
            if (frm1 != null)
            {
                frm1.SolData = s;
            }
            this.Close();
        }
    }
}
