﻿namespace lab7C
{
    partial class EratoAlgForm
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
            this.MaxValueText = new System.Windows.Forms.TextBox();
            this.labelEnterANum = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MaxValueText
            // 
            this.MaxValueText.Location = new System.Drawing.Point(690, 110);
            this.MaxValueText.Name = "MaxValueText";
            this.MaxValueText.Size = new System.Drawing.Size(246, 31);
            this.MaxValueText.TabIndex = 0;
            this.MaxValueText.Text = "N";
            this.MaxValueText.MouseEnter += new System.EventHandler(this.MaxValueText_MouseEnter);
            // 
            // labelEnterANum
            // 
            this.labelEnterANum.AutoSize = true;
            this.labelEnterANum.Location = new System.Drawing.Point(421, 113);
            this.labelEnterANum.Name = "labelEnterANum";
            this.labelEnterANum.Size = new System.Drawing.Size(221, 25);
            this.labelEnterANum.TabIndex = 1;
            this.labelEnterANum.Text = "Enter a whole number";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(319, 160);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(427, 102);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Show prime numbers from 2 to \'N\'";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(12, 304);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(1050, 406);
            this.resultRichTextBox.TabIndex = 3;
            this.resultRichTextBox.Text = "";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 716);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(1050, 78);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear result";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(807, 184);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(209, 54);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "Check Status";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // EratoAlgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 827);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelEnterANum);
            this.Controls.Add(this.MaxValueText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EratoAlgForm";
            this.Text = "Erathosfen Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaxValueText;
        private System.Windows.Forms.Label labelEnterANum;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCheck;
    }
}

