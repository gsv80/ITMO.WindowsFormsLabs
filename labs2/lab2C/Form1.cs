using MyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2C
{
    public partial class Form1 : Form
    {
        List<Item> magazines = new List<Item>();
        private int invNum=0;

        private int invNumber()
        {
            return invNum++;
        }
        public Form1()
        {
            InitializeComponent();
            
            yearNumericUpDown.Maximum = System.DateTime.Now.Year;
            yearNumericUpDown.Value = System.DateTime.Now.Year;
            monthNumericUpDown.Minimum = 1;
            monthNumericUpDown.Maximum = 12;
            monthNumericUpDown.Value = System.DateTime.Now.Month;
        }

        public string Title
        {
            get { return titleTextBox.Text; }
            set { titleTextBox.Text = value; }
        }

        public string Volume
        {
            get { return volumeTextBox.Text; } 
            set { volumeTextBox.Text = value; }
        }
        public string Topic
        {
            get { return topicTextBox.Text; }   
            set { topicTextBox.Text = value; }
        }
        public string Language
        {
            get { return languageTextBox.Text; } 
            set { languageTextBox.Text = value; }  
        }
        public int Year
        {
            get { return (int)yearNumericUpDown.Value; }
            set { yearNumericUpDown.Value = value; }
        }
        public int Month
        {
            get { return (int)monthNumericUpDown.Value; }
            set { monthNumericUpDown.Value = value; }
            
        }

        public bool Presence
        {
            get { return presenceCheckBox.Checked; }
            set {  presenceCheckBox.Checked = value; }
        }
        public bool Sorted
        {
            get { return sortCheckBox.Checked; }
            set { sortCheckBox.Checked = value; }
        }
        
        


        private void addButton_Click(object sender, EventArgs e)
        {
            Magazine mag = new Magazine(Title, Volume, Topic, Language, Year, Month, invNumber(), Presence);
            magazines.Add(mag);
            Title = Volume = Topic = Language = "";
            Month = System.DateTime.Now.Month;
            Year = System.DateTime.Now.Year;
            Presence = false;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (sortCheckBox.Checked)
            {
                magazines.Sort();
            }
            StringBuilder sb = new StringBuilder();
            foreach(Item item in magazines)
            {
                sb.Append("\n"+item.ToString());
            }
            richTextBox1.Text = sb.ToString();
            
        }
    }
}
