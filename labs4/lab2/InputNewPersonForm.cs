using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab2
{
    public partial class InputNewPersonForm : Form
    {
        Person person;
        public InputNewPersonForm(Person person)
        {
            InitializeComponent();

            this.person = person;
            this.FirstName = person.FirstName;
            this.LastName = person.LastName;
            this.Age = person.Age;
            

        }
        public InputNewPersonForm()
        {
            InitializeComponent();
        }
        

        public string FirstName 
        { 
            get { return textBoxFName.Text; } 
            set { textBoxFName.Text = value; } 
        }
        public string LastName 
        { 
            get { return textBoxLName.Text; } 
            set { textBoxLName.Text = value; } 
        }
        public int Age 
        { 
            get { return (int)numericUpDownAge.Value; } 
            set { numericUpDownAge.Value = value; } 
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            person.FirstName = this.FirstName;
            person.LastName = this.LastName;
            person.Age = this.Age;
            MessageBox.Show("Employee: " + person.ToString());
        }
    }
}
