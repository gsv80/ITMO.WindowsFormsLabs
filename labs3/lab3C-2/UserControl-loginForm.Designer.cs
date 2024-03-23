namespace lab3C_2
{
    partial class UserControl_loginForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.checkBoxRegistered = new System.Windows.Forms.CheckBox();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 258);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(371, 102);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // checkBoxRegistered
            // 
            this.checkBoxRegistered.AutoSize = true;
            this.checkBoxRegistered.Location = new System.Drawing.Point(22, 202);
            this.checkBoxRegistered.Name = "checkBoxRegistered";
            this.checkBoxRegistered.Size = new System.Drawing.Size(219, 29);
            this.checkBoxRegistered.TabIndex = 1;
            this.checkBoxRegistered.Text = "Already registered";
            this.checkBoxRegistered.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(12, 67);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(361, 33);
            this.comboBoxName.TabIndex = 4;
            this.comboBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxName_Validating);
            // 
            // UserControl_loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.checkBoxRegistered);
            this.Controls.Add(this.btnSubmit);
            this.Name = "UserControl_loginForm";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox checkBoxRegistered;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxName;
    }
}
