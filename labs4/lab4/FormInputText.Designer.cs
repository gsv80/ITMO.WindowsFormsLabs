namespace lab4
{
    partial class FormInputText
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
            this.textBoxStringOne = new System.Windows.Forms.TextBox();
            this.labelTextOne = new System.Windows.Forms.Label();
            this.labelTextTwo = new System.Windows.Forms.Label();
            this.textBoxStringTwo = new System.Windows.Forms.TextBox();
            this.labelTextThree = new System.Windows.Forms.Label();
            this.textBoxStringThree = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStringOne
            // 
            this.textBoxStringOne.Location = new System.Drawing.Point(13, 47);
            this.textBoxStringOne.Name = "textBoxStringOne";
            this.textBoxStringOne.Size = new System.Drawing.Size(416, 31);
            this.textBoxStringOne.TabIndex = 0;
            // 
            // labelTextOne
            // 
            this.labelTextOne.AutoSize = true;
            this.labelTextOne.Location = new System.Drawing.Point(458, 50);
            this.labelTextOne.Name = "labelTextOne";
            this.labelTextOne.Size = new System.Drawing.Size(114, 25);
            this.labelTextOne.TabIndex = 1;
            this.labelTextOne.Text = "String One";
            // 
            // labelTextTwo
            // 
            this.labelTextTwo.AutoSize = true;
            this.labelTextTwo.Location = new System.Drawing.Point(458, 127);
            this.labelTextTwo.Name = "labelTextTwo";
            this.labelTextTwo.Size = new System.Drawing.Size(114, 25);
            this.labelTextTwo.TabIndex = 3;
            this.labelTextTwo.Text = "String Two";
            // 
            // textBoxStringTwo
            // 
            this.textBoxStringTwo.Location = new System.Drawing.Point(13, 124);
            this.textBoxStringTwo.Name = "textBoxStringTwo";
            this.textBoxStringTwo.Size = new System.Drawing.Size(416, 31);
            this.textBoxStringTwo.TabIndex = 2;
            // 
            // labelTextThree
            // 
            this.labelTextThree.AutoSize = true;
            this.labelTextThree.Location = new System.Drawing.Point(458, 207);
            this.labelTextThree.Name = "labelTextThree";
            this.labelTextThree.Size = new System.Drawing.Size(130, 25);
            this.labelTextThree.TabIndex = 5;
            this.labelTextThree.Text = "String Three";
            // 
            // textBoxStringThree
            // 
            this.textBoxStringThree.Location = new System.Drawing.Point(13, 204);
            this.textBoxStringThree.Name = "textBoxStringThree";
            this.textBoxStringThree.Size = new System.Drawing.Size(416, 31);
            this.textBoxStringThree.TabIndex = 4;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(13, 274);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(416, 58);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // FormInputText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelTextThree);
            this.Controls.Add(this.textBoxStringThree);
            this.Controls.Add(this.labelTextTwo);
            this.Controls.Add(this.textBoxStringTwo);
            this.Controls.Add(this.labelTextOne);
            this.Controls.Add(this.textBoxStringOne);
            this.Name = "FormInputText";
            this.Text = "Input Text to summarize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStringOne;
        private System.Windows.Forms.Label labelTextOne;
        private System.Windows.Forms.Label labelTextTwo;
        private System.Windows.Forms.TextBox textBoxStringTwo;
        private System.Windows.Forms.Label labelTextThree;
        private System.Windows.Forms.TextBox textBoxStringThree;
        private System.Windows.Forms.Button buttonApply;
    }
}