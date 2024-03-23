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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Person> persons = new List<Person>();


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //InputNewPersonForm newPerson = new InputNewPersonForm();
            //if(newPerson.ShowDialog() != DialogResult.OK)
            //{
            //    return;
            //}
            //ListViewItem newItem = listView1.Items.Add(newPerson.FirstName);
            //newItem.SubItems.Add(newPerson.LastName);
            //newItem.SubItems.Add(newPerson.Age.ToString());

            Person p = new Person();
            InputNewPersonForm newPers = new InputNewPersonForm(p);
            if(newPers.ShowDialog() != DialogResult.OK) { return; }
            persons.Add(p);

            listView1.VirtualListSize = persons.Count;
            listView1.Invalidate();



        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count == 0) { return; }
            Person personToEdit = persons[listView1.SelectedIndices[0]];
            InputNewPersonForm editForm = new InputNewPersonForm(personToEdit);
            if(editForm.ShowDialog() == DialogResult.OK)
            {
                listView1.Invalidate();
            }

        }

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if(e.ItemIndex>=0 && e.ItemIndex < persons.Count) 
            {
                e.Item = new ListViewItem(persons[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(persons[e.ItemIndex].LastName);
                e.Item.SubItems.Add(persons[e.ItemIndex].Age.ToString());
            }
        }

        private void buttonShowList_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Person person in persons)
            {
                sb.Append("Employee: "+person.ToString());
            }
            richTextBoxShowList.Text = sb.ToString();
        }
    }
}
