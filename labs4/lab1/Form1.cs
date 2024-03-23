﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt) | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "txt files (*.txt)| *.txt| All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if((myStream = openFileDialog1.OpenFile())!= null)
                    {
                        using (myStream)
                        {
                            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: cant't read file" + ex.Message);
                }
            }
         }
    }
}
