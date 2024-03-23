using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1C3
{
    public partial class Form1 : Form
    {
        private string textInput; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textInput = textBox1.Text.Trim();
            if(!string.IsNullOrWhiteSpace(textBox1.Text) )
            {
                listBox1.Items.Add(textInput);
                textBox1.Clear();
            }
            
            
        }
    }
}
