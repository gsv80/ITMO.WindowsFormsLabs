namespace lab3C_2
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
            this.userControl_loginForm1 = new lab3C_2.UserControl_loginForm();
            this.richTextBoxShowUsers = new System.Windows.Forms.RichTextBox();
            this.buttonShowUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl_loginForm1
            // 
            this.userControl_loginForm1.Location = new System.Drawing.Point(108, 98);
            this.userControl_loginForm1.Name = "userControl_loginForm1";
            this.userControl_loginForm1.Size = new System.Drawing.Size(400, 400);
            this.userControl_loginForm1.TabIndex = 0;
            // 
            // richTextBoxShowUsers
            // 
            this.richTextBoxShowUsers.Location = new System.Drawing.Point(573, 162);
            this.richTextBoxShowUsers.Name = "richTextBoxShowUsers";
            this.richTextBoxShowUsers.Size = new System.Drawing.Size(625, 297);
            this.richTextBoxShowUsers.TabIndex = 1;
            this.richTextBoxShowUsers.Text = "";
            // 
            // buttonShowUsers
            // 
            this.buttonShowUsers.Location = new System.Drawing.Point(573, 486);
            this.buttonShowUsers.Name = "buttonShowUsers";
            this.buttonShowUsers.Size = new System.Drawing.Size(625, 89);
            this.buttonShowUsers.TabIndex = 2;
            this.buttonShowUsers.Text = "Show Users";
            this.buttonShowUsers.UseVisualStyleBackColor = true;
            this.buttonShowUsers.Click += new System.EventHandler(this.buttonShowUsers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 662);
            this.Controls.Add(this.buttonShowUsers);
            this.Controls.Add(this.richTextBoxShowUsers);
            this.Controls.Add(this.userControl_loginForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl_loginForm userControl_loginForm1;
        private System.Windows.Forms.RichTextBox richTextBoxShowUsers;
        private System.Windows.Forms.Button buttonShowUsers;
    }
}

