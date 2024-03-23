using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void extendedTabCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(extendedTabCheckBox.Checked)
            {
                Label lb1  = new Label();
                lb1.Location = new Point(10, 150);
                lb1.Size = new Size(70, 37);
                lb1.Name = "label1";
                lb1.TabIndex = 2;
                lb1.Text = "PIN2";
                groupBox1.Controls.Add(lb1);
                TextBox txt = new TextBox();
                txt.Location = new Point(115, 147);
                txt.Size = new Size(325, 22);
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);

                

               // txt.KeyPress += new KeyPressEventHandler(this.textBox2_KeyPress);
            }
            else
            {
                int elements;
                elements = groupBox1.Controls.Count;
                while( elements > 4 )
                {
                    groupBox1.Controls.RemoveAt(elements - 1);
                    elements--;
                }
            }

            
        }

        private void Txt_Validating(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Name should not have digits");
                errorProvider1.SetError(textBox1, "Should be a letter");
            }
            else
            {
                errorProvider1.Clear();
            }
           // errorProvider1.SetError(textBox1, "Should be a letter");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBox2.Text);
                    e.Cancel = false;
                }
                catch 
                {
                    e.Cancel= true;
                    MessageBox.Show("PIN can't contain letters");
                    textBox2.Text = "";
                }
            }
        }

        //private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("PIN should not have letters");
        //    }

        //}



    }
}
