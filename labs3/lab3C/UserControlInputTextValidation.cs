using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Forms.VisualStyles;

namespace lab3C
{
    public partial class UserControlInputTextValidation : UserControl
    {


        public UserControlInputTextValidation()
        {
            InitializeComponent();
        }


        public InputFormDataModel IFDM {  get; set; } = new InputFormDataModel();
        private void Form_Load(object sender, EventArgs e)
        {
            Model.FormToModel.Add(this, IFDM);
        }
        public string TxtFNameValue
        {
            get { return txtFName.Text; }
            set { txtFName.Text = value; }
        }
        public string txtLNameValue
        {
            get { return txtLName.Text; }
            set { txtLName.Text = value; }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFName_Enter(object sender, EventArgs e)
        {
            txtFName.Text = "";
        }

        private void txtLName_Enter(object sender, EventArgs e)
        {
            txtLName.Text = "";
        }
    }
}
