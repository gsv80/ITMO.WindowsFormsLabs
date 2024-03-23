namespace lab2
{
    partial class TestList
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
            this.contestantsList = new System.Windows.Forms.GroupBox();
            this.memberList = new System.Windows.Forms.CheckedListBox();
            this.registeredUsersList = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contestantsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // contestantsList
            // 
            this.contestantsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contestantsList.Controls.Add(this.memberList);
            this.contestantsList.Location = new System.Drawing.Point(2, 0);
            this.contestantsList.Name = "contestantsList";
            this.contestantsList.Size = new System.Drawing.Size(829, 394);
            this.contestantsList.TabIndex = 0;
            this.contestantsList.TabStop = false;
            this.contestantsList.Text = "Contestants list";
            // 
            // memberList
            // 
            this.memberList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.memberList.FormattingEnabled = true;
            this.memberList.Location = new System.Drawing.Point(3, 79);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(823, 312);
            this.memberList.TabIndex = 0;
            // 
            // registeredUsersList
            // 
            this.registeredUsersList.FormattingEnabled = true;
            this.registeredUsersList.Items.AddRange(new object[] {
            "John",
            "Walter",
            "Dude"});
            this.registeredUsersList.Location = new System.Drawing.Point(5, 489);
            this.registeredUsersList.Name = "registeredUsersList";
            this.registeredUsersList.Size = new System.Drawing.Size(823, 33);
            this.registeredUsersList.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(880, 79);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(237, 82);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(880, 268);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(237, 82);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(880, 463);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(237, 82);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1165, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 82);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add from file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 1125);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.registeredUsersList);
            this.Controls.Add(this.contestantsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TestList";
            this.Text = "Test List";
            this.contestantsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox contestantsList;
        private System.Windows.Forms.CheckedListBox memberList;
        private System.Windows.Forms.ComboBox registeredUsersList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button button1;
    }
}

