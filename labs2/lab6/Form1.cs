using MyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            numericUpDown1.Maximum = 5000;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Value = 1;
            numericUpDown2.Maximum = System.DateTime.Now.Year;
        }

        public string Author
        {
            get { return authorTextBox.Text; }
            set { authorTextBox.Text = value; }
        }

        public string Title
        {
            get { return titleTextBox.Text; }
            set { titleTextBox.Text = value; }
        }
        public string Publisher
        {
            get { return publisherTextBox.Text; }
            set { publisherTextBox.Text = value; }
        }

        public int Pages
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public int PubYear
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }

        public int IDNum
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool OnStock
        {
            get { return onStockCheckBox.Checked; }
            set { onStockCheckBox.Checked = value; }
        }

        public bool SortByID
        {
            get { return sortByIdcheckBox.Checked; }
            set {  sortByIdcheckBox.Checked = value; }
        }

        List<Item> items = new List<Item>();

        private void addButton_Click(object sender, EventArgs e)
        {
            Book book = new Book(Author, Title, Publisher, Pages, PubYear, IDNum, OnStock);
            items.Add(book);
            Author = Title = Publisher = "";
            Pages = IDNum = 1;
            PubYear = 2023;
            OnStock = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SortByID)
            {
                items.Sort();
            }
            StringBuilder sb = new StringBuilder();
            foreach (Item item in items)
            {
                sb.Append("\n"+item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
