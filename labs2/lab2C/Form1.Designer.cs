namespace lab2C
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
            this.booksTab = new System.Windows.Forms.TabPage();
            this.magazinesTab = new System.Windows.Forms.TabPage();
            this.presenceCheckBox = new System.Windows.Forms.CheckBox();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.sortCheckBox = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.monthLabel = new System.Windows.Forms.Label();
            this.monthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.topicLabel = new System.Windows.Forms.Label();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.magazinesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.booksTab);
            this.tabControl1.Controls.Add(this.magazinesTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1194, 745);
            this.tabControl1.TabIndex = 0;
            // 
            // booksTab
            // 
            this.booksTab.Location = new System.Drawing.Point(8, 39);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(1178, 698);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Books";
            this.booksTab.UseVisualStyleBackColor = true;
            // 
            // magazinesTab
            // 
            this.magazinesTab.Controls.Add(this.presenceCheckBox);
            this.magazinesTab.Controls.Add(this.languageTextBox);
            this.magazinesTab.Controls.Add(this.languageLabel);
            this.magazinesTab.Controls.Add(this.showButton);
            this.magazinesTab.Controls.Add(this.sortCheckBox);
            this.magazinesTab.Controls.Add(this.addButton);
            this.magazinesTab.Controls.Add(this.monthLabel);
            this.magazinesTab.Controls.Add(this.monthNumericUpDown);
            this.magazinesTab.Controls.Add(this.yearLabel);
            this.magazinesTab.Controls.Add(this.yearNumericUpDown);
            this.magazinesTab.Controls.Add(this.topicTextBox);
            this.magazinesTab.Controls.Add(this.topicLabel);
            this.magazinesTab.Controls.Add(this.volumeTextBox);
            this.magazinesTab.Controls.Add(this.volumeLabel);
            this.magazinesTab.Controls.Add(this.titleTextBox);
            this.magazinesTab.Controls.Add(this.richTextBox1);
            this.magazinesTab.Controls.Add(this.titleLabel);
            this.magazinesTab.Location = new System.Drawing.Point(8, 39);
            this.magazinesTab.Name = "magazinesTab";
            this.magazinesTab.Padding = new System.Windows.Forms.Padding(3);
            this.magazinesTab.Size = new System.Drawing.Size(1178, 698);
            this.magazinesTab.TabIndex = 1;
            this.magazinesTab.Text = "Magazines";
            this.magazinesTab.UseVisualStyleBackColor = true;
            // 
            // presenceCheckBox
            // 
            this.presenceCheckBox.AutoSize = true;
            this.presenceCheckBox.Location = new System.Drawing.Point(45, 519);
            this.presenceCheckBox.Name = "presenceCheckBox";
            this.presenceCheckBox.Size = new System.Drawing.Size(135, 29);
            this.presenceCheckBox.TabIndex = 16;
            this.presenceCheckBox.Text = "Presence";
            this.presenceCheckBox.UseVisualStyleBackColor = true;
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(210, 277);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(270, 31);
            this.languageTextBox.TabIndex = 15;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(40, 280);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(108, 25);
            this.languageLabel.TabIndex = 14;
            this.languageLabel.Text = "Language";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(588, 601);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(284, 68);
            this.showButton.TabIndex = 13;
            this.showButton.Text = "SHOW";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // sortCheckBox
            // 
            this.sortCheckBox.AutoSize = true;
            this.sortCheckBox.Location = new System.Drawing.Point(1045, 622);
            this.sortCheckBox.Name = "sortCheckBox";
            this.sortCheckBox.Size = new System.Drawing.Size(83, 29);
            this.sortCheckBox.TabIndex = 12;
            this.sortCheckBox.Text = "Sort";
            this.sortCheckBox.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(45, 601);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(435, 68);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(40, 440);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(72, 25);
            this.monthLabel.TabIndex = 10;
            this.monthLabel.Text = "Month";
            // 
            // monthNumericUpDown
            // 
            this.monthNumericUpDown.Location = new System.Drawing.Point(210, 438);
            this.monthNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthNumericUpDown.Name = "monthNumericUpDown";
            this.monthNumericUpDown.Size = new System.Drawing.Size(150, 31);
            this.monthNumericUpDown.TabIndex = 9;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(40, 360);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(58, 25);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Year";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(210, 358);
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(150, 31);
            this.yearNumericUpDown.TabIndex = 7;
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(210, 197);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(270, 31);
            this.topicTextBox.TabIndex = 6;
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Location = new System.Drawing.Point(40, 200);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(65, 25);
            this.topicLabel.TabIndex = 5;
            this.topicLabel.Text = "Topic";
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Location = new System.Drawing.Point(210, 117);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(270, 31);
            this.volumeTextBox.TabIndex = 4;
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(40, 120);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(84, 25);
            this.volumeLabel.TabIndex = 3;
            this.volumeLabel.Text = "Volume";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(210, 37);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(270, 31);
            this.titleTextBox.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(588, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(540, 550);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(40, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(53, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 745);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Library";
            this.tabControl1.ResumeLayout(false);
            this.magazinesTab.ResumeLayout(false);
            this.magazinesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.TabPage magazinesTab;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox topicTextBox;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.NumericUpDown monthNumericUpDown;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.CheckBox sortCheckBox;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.CheckBox presenceCheckBox;
    }
}

