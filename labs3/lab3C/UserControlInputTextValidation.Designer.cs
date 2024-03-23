namespace lab3C
{
    partial class UserControlInputTextValidation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(5, 66);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "First name";
            // 
            // txtFName
            // 
            this.txtFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFName.Location = new System.Drawing.Point(4, 99);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(365, 35);
            this.txtFName.TabIndex = 1;
            this.txtFName.Text = "First Name";
            this.txtFName.Enter += new System.EventHandler(this.txtFName_Enter);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Location = new System.Drawing.Point(0, 3);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(365, 49);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "@Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtLName
            // 
            this.txtLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLName.Location = new System.Drawing.Point(4, 185);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(365, 35);
            this.txtLName.TabIndex = 2;
            this.txtLName.Text = "Last Name";
            this.txtLName.Enter += new System.EventHandler(this.txtLName_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Last name";
            // 
            // UserControlInputTextValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(370, 400);
            this.MinimumSize = new System.Drawing.Size(370, 400);
            this.Name = "UserControlInputTextValidation";
            this.Size = new System.Drawing.Size(370, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label1;
    }
}
