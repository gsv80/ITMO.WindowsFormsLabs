namespace lab2
{
    partial class InputNewPersonForm
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
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(289, 114);
            this.textBoxFName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(505, 43);
            this.textBoxFName.TabIndex = 0;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(54, 118);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(139, 37);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First name";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(54, 206);
            this.labelLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(137, 37);
            this.labelLName.TabIndex = 3;
            this.labelLName.Text = "Last name";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(289, 202);
            this.textBoxLName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(505, 43);
            this.textBoxLName.TabIndex = 2;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(54, 299);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(64, 37);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Age";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSubmit.Location = new System.Drawing.Point(115, 449);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(205, 89);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(589, 449);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(205, 89);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(289, 293);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(171, 43);
            this.numericUpDownAge.TabIndex = 8;
            // 
            // InputNewPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 666);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxFName);
            this.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InputNewPersonForm";
            this.ShowInTaskbar = false;
            this.Text = "Input New Person";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
    }
}