using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Excel.Application app = new Excel.Application();
        Excel.Workbook workbook;
        Excel.Worksheet worksheet;
        Excel.Range ShtRange;
        DataTable dt = new DataTable();



        private void button1_Click(object sender, EventArgs e)
        {
            workbook = app.Workbooks.Open(ofd.FileName);
            worksheet=(Excel.Worksheet)workbook.Sheets.get_Item(1);
            ShtRange = worksheet.UsedRange;
            for(int cNum = 1;cNum<= ShtRange.Columns.Count; cNum++)
            {
                dt.Columns.Add(new DataColumn((ShtRange.Cells[1, cNum] as Excel.Range).Value2.ToString()));
                dt.AcceptChanges();
            }
            string[] columnNames = new String[dt.Columns.Count];
            for(int cname = 0; cname < dt.Columns.Count; cname++)
            {
                columnNames[0] = dt.Columns[cname].ColumnName;
            }
            for(int rNumber=2;rNumber<= ShtRange.Rows.Count; rNumber++)
            {
                DataRow row = dt.NewRow();
                for(int cNum = 1;cNum <= ShtRange.Columns.Count; cNum++)
                {
                    if ((ShtRange.Cells[rNumber,cNum] as Excel.Range).Value2 != null)
                    {
                        row[cNum-1]= (ShtRange.Cells[(rNumber,cNum)] as Excel.Range).Value2.ToString();
                    }
                }
                dt.Rows.Add(row);
                dt.AcceptChanges();

                dataGridView1.DataSource = dt;
                app.Quit();
            }
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
            else
            {
                MessageBox.Show("Choose file", "Loading Data..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
