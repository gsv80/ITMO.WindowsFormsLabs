using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class ParentForm : Form

    {
        private int openDocs = 0;
        public ParentForm()
        {
            InitializeComponent();
            spDate.Text = Convert.ToString(DateTime.Today.ToLongDateString());
            spWin.Text = "";
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            spWin.Text = "Windows in tile";
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi (System.Windows.Forms.MdiLayout.Cascade);
            spWin.Text = "Windows in cascade";
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.Text = newChild.Text + " #" + ++openDocs;
            newChild.MdiParent = this;
            newChild.Show();
        }

        

        

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.Tag.ToString())
            {
                case "NewDocument":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent=this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " #" + ++openDocs;
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    spWin.Text = "Windows in cascade";
                    break;
                case "Tile":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    spWin.Text = "Windows in tile";
                    break;

            }
        }
    }
}
