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
    public partial class FormMain : Form
    {
        //FormInputText formInputText;
        public FormMain()
        {
            InitializeComponent();
            //formInputText = new FormInputText();

            
        }
        public string SolData { 
            get 
            {
                return textBoxTextReceived.Text;
            }
            set 
            {
                textBoxTextReceived.Text = value;
            }
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {

            FormInputText formInputText = new FormInputText();
            formInputText.StartPosition = FormStartPosition.Manual;
            formInputText.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            formInputText.Show(this);
            //try
            //{
            //    formInputText.StartPosition = FormStartPosition.Manual ;
            //    formInputText.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            //    formInputText.Show();
            //    formInputText.Activate();
            //}
            //catch (ObjectDisposedException ex)
            //{
            //    formInputText = new FormInputText();
            //    formInputText.StartPosition = FormStartPosition.Manual;
            //    formInputText.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            //    formInputText.Show();
            //    formInputText.Activate();
            //}
        }
    }
}
