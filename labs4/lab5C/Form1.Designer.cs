namespace lab5C
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonSetInterval = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelIntervalMinMax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 102);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 527);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonSetInterval
            // 
            this.buttonSetInterval.Location = new System.Drawing.Point(455, 102);
            this.buttonSetInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSetInterval.Name = "buttonSetInterval";
            this.buttonSetInterval.Size = new System.Drawing.Size(119, 118);
            this.buttonSetInterval.TabIndex = 1;
            this.buttonSetInterval.Text = "Set Interval";
            this.buttonSetInterval.UseVisualStyleBackColor = true;
            this.buttonSetInterval.Click += new System.EventHandler(this.buttonSetInterval_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(13, 13);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(490, 30);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Please set interval to count Sin(x) values, in Radians";
            // 
            // labelIntervalMinMax
            // 
            this.labelIntervalMinMax.AutoSize = true;
            this.labelIntervalMinMax.Location = new System.Drawing.Point(13, 53);
            this.labelIntervalMinMax.Name = "labelIntervalMinMax";
            this.labelIntervalMinMax.Size = new System.Drawing.Size(206, 30);
            this.labelIntervalMinMax.TabIndex = 3;
            this.labelIntervalMinMax.Text = "Sin(x[rad]) from.. to.. ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 785);
            this.Controls.Add(this.labelIntervalMinMax);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonSetInterval);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Sin () Count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonSetInterval;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelIntervalMinMax;
    }
}

