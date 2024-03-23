namespace lab4
{
    partial class FormMain
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
            this.textBoxTextReceived = new System.Windows.Forms.TextBox();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTextReceived
            // 
            this.textBoxTextReceived.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTextReceived.Location = new System.Drawing.Point(0, 0);
            this.textBoxTextReceived.Name = "textBoxTextReceived";
            this.textBoxTextReceived.Size = new System.Drawing.Size(800, 31);
            this.textBoxTextReceived.TabIndex = 0;
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(13, 55);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(157, 82);
            this.buttonGetData.TabIndex = 1;
            this.buttonGetData.Text = "Get Text";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 165);
            this.Controls.Add(this.buttonGetData);
            this.Controls.Add(this.textBoxTextReceived);
            this.Name = "FormMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTextReceived;
        private System.Windows.Forms.Button buttonGetData;
    }
}

