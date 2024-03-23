using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab3C_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowUsers_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(User user in userControl_loginForm1.Users)
            {
                sb.Append("\n" + user.ToString());
            }
            richTextBoxShowUsers.Text = sb.ToString();
        }
    }
}
