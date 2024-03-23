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
    public partial class Form1 : Form
    {
        internal double a;
        internal double b;
        public Form1()
        {
            InitializeComponent();
            a = 0.1;
            b = 0.04;

        }
        public string DataA
        {
            get
            {
                return textBoxDataA.Text;
            }
            set 
            { 
                textBoxDataA.Text = value; 
            }

        }
        public string DataB
        {
            get
            {
                return textBoxDataB.Text;
            }
            set
            {
                textBoxDataB.Text = value;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            double t = 0;
            Point p1, p2;
            int w = (int)panel1.Width;
            int h = (int)panel1.Height;
            int y = h / 2;

            for (int x = 0; x < w; x++)
            {
                p1 = new Point(x,y);
                t = Operation.SummSin(x,a,b);
                y = (int)(t * h / 5);
                y = y + h / 2;
                p2 = new Point(x,y);

                Graphics dc = e.Graphics;
                Pen p = new Pen(Color.Red, 1);
                dc.DrawLine(p, p1, p2);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(DataA);
                b = double.Parse(DataB);
                panel1.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Message occured: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditValues edit = new EditValues();
            edit.Show(this);
        }
    }
}
