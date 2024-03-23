namespace lab6
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Books = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.onStockCheckBox = new System.Windows.Forms.CheckBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.InUseLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.IDLabel = new System.Windows.Forms.Label();
            this.pagesLabel = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.publYearLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Magazines = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.sortByIdcheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.Books.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Books);
            this.tabControl1.Controls.Add(this.Magazines);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1409, 845);
            this.tabControl1.TabIndex = 0;
            // 
            // Books
            // 
            this.Books.Controls.Add(this.sortByIdcheckBox);
            this.Books.Controls.Add(this.button1);
            this.Books.Controls.Add(this.panel1);
            this.Books.Controls.Add(this.richTextBox1);
            this.Books.Location = new System.Drawing.Point(8, 39);
            this.Books.Name = "Books";
            this.Books.Padding = new System.Windows.Forms.Padding(3);
            this.Books.Size = new System.Drawing.Size(1393, 798);
            this.Books.TabIndex = 0;
            this.Books.Text = "Books";
            this.Books.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.authorTextBox);
            this.panel1.Controls.Add(this.authorLabel);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.onStockCheckBox);
            this.panel1.Controls.Add(this.publisherTextBox);
            this.panel1.Controls.Add(this.InUseLabel);
            this.panel1.Controls.Add(this.publisherLabel);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.IDLabel);
            this.panel1.Controls.Add(this.pagesLabel);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.publYearLabel);
            this.panel1.Location = new System.Drawing.Point(-8, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 803);
            this.panel1.TabIndex = 18;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(298, 36);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(298, 31);
            this.authorTextBox.TabIndex = 0;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(64, 39);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(75, 25);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(69, 679);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(527, 60);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(298, 116);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(298, 31);
            this.titleTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(64, 119);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(53, 25);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title";
            // 
            // onStockCheckBox
            // 
            this.onStockCheckBox.AutoSize = true;
            this.onStockCheckBox.Location = new System.Drawing.Point(69, 599);
            this.onStockCheckBox.Name = "onStockCheckBox";
            this.onStockCheckBox.Size = new System.Drawing.Size(132, 29);
            this.onStockCheckBox.TabIndex = 14;
            this.onStockCheckBox.Text = "On Stock";
            this.onStockCheckBox.UseVisualStyleBackColor = true;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(298, 196);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(298, 31);
            this.publisherTextBox.TabIndex = 4;
            // 
            // InUseLabel
            // 
            this.InUseLabel.AutoSize = true;
            this.InUseLabel.Location = new System.Drawing.Point(64, 519);
            this.InUseLabel.Name = "InUseLabel";
            this.InUseLabel.Size = new System.Drawing.Size(0, 25);
            this.InUseLabel.TabIndex = 13;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(64, 199);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(102, 25);
            this.publisherLabel.TabIndex = 5;
            this.publisherLabel.Text = "Publisher";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(298, 277);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(298, 31);
            this.numericUpDown1.TabIndex = 6;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(64, 439);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(79, 25);
            this.IDLabel.TabIndex = 11;
            this.IDLabel.Text = "ID num";
            // 
            // pagesLabel
            // 
            this.pagesLabel.AutoSize = true;
            this.pagesLabel.Location = new System.Drawing.Point(64, 279);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(73, 25);
            this.pagesLabel.TabIndex = 7;
            this.pagesLabel.Text = "Pages";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(298, 437);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(298, 31);
            this.numericUpDown3.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(298, 357);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(298, 31);
            this.numericUpDown2.TabIndex = 8;
            // 
            // publYearLabel
            // 
            this.publYearLabel.AutoSize = true;
            this.publYearLabel.Location = new System.Drawing.Point(64, 359);
            this.publYearLabel.Name = "publYearLabel";
            this.publYearLabel.Size = new System.Drawing.Size(170, 25);
            this.publYearLabel.TabIndex = 9;
            this.publYearLabel.Text = "Publication Year";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(706, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(625, 594);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // Magazines
            // 
            this.Magazines.Location = new System.Drawing.Point(8, 39);
            this.Magazines.Name = "Magazines";
            this.Magazines.Padding = new System.Windows.Forms.Padding(3);
            this.Magazines.Size = new System.Drawing.Size(1393, 798);
            this.Magazines.TabIndex = 1;
            this.Magazines.Text = "Magazines";
            this.Magazines.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 60);
            this.button1.TabIndex = 17;
            this.button1.Text = "VIEW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sortByIdcheckBox
            // 
            this.sortByIdcheckBox.AutoSize = true;
            this.sortByIdcheckBox.Location = new System.Drawing.Point(1193, 699);
            this.sortByIdcheckBox.Name = "sortByIdcheckBox";
            this.sortByIdcheckBox.Size = new System.Drawing.Size(138, 29);
            this.sortByIdcheckBox.TabIndex = 19;
            this.sortByIdcheckBox.Text = "Sort by ID";
            this.sortByIdcheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 845);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Library";
            this.tabControl1.ResumeLayout(false);
            this.Books.ResumeLayout(false);
            this.Books.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Books;
        private System.Windows.Forms.TabPage Magazines;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label pagesLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label InUseLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label publYearLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckBox onStockCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox sortByIdcheckBox;
    }
}

