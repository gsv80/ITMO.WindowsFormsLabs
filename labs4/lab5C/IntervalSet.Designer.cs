namespace lab5C
{
    partial class IntervalSet
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
            this.labelIntervalBounds = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIntervalBounds
            // 
            this.labelIntervalBounds.AutoSize = true;
            this.labelIntervalBounds.Location = new System.Drawing.Point(54, 66);
            this.labelIntervalBounds.Name = "labelIntervalBounds";
            this.labelIntervalBounds.Size = new System.Drawing.Size(303, 25);
            this.labelIntervalBounds.TabIndex = 0;
            this.labelIntervalBounds.Text = "Interval bounds (Min and Max)";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.DecimalPlaces = 1;
            this.numericUpDownMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMin.Location = new System.Drawing.Point(59, 138);
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(216, 31);
            this.numericUpDownMin.TabIndex = 1;
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.DecimalPlaces = 1;
            this.numericUpDownMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMax.Location = new System.Drawing.Point(410, 138);
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(216, 31);
            this.numericUpDownMax.TabIndex = 2;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSubmit.Location = new System.Drawing.Point(59, 213);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(567, 70);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(59, 314);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(567, 70);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // IntervalSet
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 446);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.labelIntervalBounds);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IntervalSet";
            this.ShowInTaskbar = false;
            this.Text = "IntervalSet";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIntervalBounds;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
    }
}