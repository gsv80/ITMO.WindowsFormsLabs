using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace lab2
{
    public partial class TestList : Form
    {
        public TestList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(registeredUsersList.Text.Length != 0) 
            {
                memberList.Items.Add(registeredUsersList.Text);
            }
            else
            {
                MessageBox.Show("Select an item or create new one");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while(memberList.CheckedIndices.Count > 0) 
            {
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registeredUsersList.Items.Clear();

            //FileStream fstream = new FileStream("..\\..\\datalist.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(fstream);

            //for(int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
            //{
            //    registeredUsersList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
            //}

            //fstream.Close();

            using(FileStream fstream = new FileStream("..\\..\\datalist.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) 
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(fstream);
                for (int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++)
                {
                    registeredUsersList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);
                }
            }
        }
    }
}
