namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonShowEmpList = new System.Windows.Forms.Button();
            this.richTextBoxShowList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFName,
            this.columnHeaderLName,
            this.columnHeaderAge});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(867, 295);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.VirtualMode = true;
            this.listView1.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listView1_RetrieveVirtualItem);
            // 
            // columnHeaderFName
            // 
            this.columnHeaderFName.Text = "First name";
            this.columnHeaderFName.Width = 185;
            // 
            // columnHeaderLName
            // 
            this.columnHeaderLName.Text = "Last name";
            this.columnHeaderLName.Width = 188;
            // 
            // columnHeaderAge
            // 
            this.columnHeaderAge.Text = "Age";
            this.columnHeaderAge.Width = 241;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(236, 312);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(158, 87);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(465, 312);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(158, 87);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonShowEmpList
            // 
            this.buttonShowEmpList.Location = new System.Drawing.Point(236, 408);
            this.buttonShowEmpList.Name = "buttonShowEmpList";
            this.buttonShowEmpList.Size = new System.Drawing.Size(387, 87);
            this.buttonShowEmpList.TabIndex = 3;
            this.buttonShowEmpList.Text = "Show Employees List";
            this.buttonShowEmpList.UseVisualStyleBackColor = true;
            this.buttonShowEmpList.Click += new System.EventHandler(this.buttonShowList_Click);
            // 
            // richTextBoxShowList
            // 
            this.richTextBoxShowList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxShowList.Location = new System.Drawing.Point(0, 504);
            this.richTextBoxShowList.Name = "richTextBoxShowList";
            this.richTextBoxShowList.Size = new System.Drawing.Size(867, 253);
            this.richTextBoxShowList.TabIndex = 4;
            this.richTextBoxShowList.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 757);
            this.Controls.Add(this.richTextBoxShowList);
            this.Controls.Add(this.buttonShowEmpList);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Edit Person";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderFName;
        private System.Windows.Forms.ColumnHeader columnHeaderLName;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonShowEmpList;
        private System.Windows.Forms.RichTextBox richTextBoxShowList;
    }
}

