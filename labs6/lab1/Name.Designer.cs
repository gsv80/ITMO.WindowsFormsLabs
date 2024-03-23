namespace lab1
{
    partial class EditValues
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(161, 94);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(144, 31);
            this.textBoxA.TabIndex = 0;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(330, 97);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(24, 25);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "a";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(330, 162);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(24, 25);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "b";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(161, 159);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(144, 31);
            this.textBoxB.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(161, 220);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(239, 51);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(156, 43);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(292, 25);
            this.labelHeader.TabIndex = 5;
            this.labelHeader.Text = "Enter new values for a and b:";
            // 
            // EditValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 321);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditValues";
            this.Text = "Edit Values";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelHeader;
    }
}