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
    public partial class UserControl_loginForm : UserControl
    {
        public UserControl_loginForm()
        {
            InitializeComponent();
        }

        public string NameField
        {
            get { return comboBoxName.Text; }
            set { comboBoxName.Text = value; }
        }
        List<User> users = new List<User>();

        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User u = new User(NameField);
            if( checkBoxRegistered.Checked )
            {
                u.Registered();
            }
            users.Add(u);
            comboBoxName.Text = "";

        }
        public List<User> Users
        {
            set { users = value; }
            get { return users; }
        }

        private void comboBoxName_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxName.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Don't do like this. Fill name field");
            }
        }
    }
}
