namespace lab3
{
    partial class AsyncStart
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
            this.btnSum = new System.Windows.Forms.Button();
            this.btnOperate = new System.Windows.Forms.Button();
            this.labelValueA = new System.Windows.Forms.Label();
            this.labelValueB = new System.Windows.Forms.Label();
            this.textBoxAVal = new System.Windows.Forms.TextBox();
            this.textBoxBVal = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(116, 164);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(197, 80);
            this.btnSum.TabIndex = 0;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnOperate
            // 
            this.btnOperate.Location = new System.Drawing.Point(429, 366);
            this.btnOperate.Name = "btnOperate";
            this.btnOperate.Size = new System.Drawing.Size(197, 80);
            this.btnOperate.TabIndex = 1;
            this.btnOperate.Text = "Operate";
            this.btnOperate.UseVisualStyleBackColor = true;
            this.btnOperate.Click += new System.EventHandler(this.btnOperate_Click);
            // 
            // labelValueA
            // 
            this.labelValueA.AutoSize = true;
            this.labelValueA.Location = new System.Drawing.Point(111, 98);
            this.labelValueA.Name = "labelValueA";
            this.labelValueA.Size = new System.Drawing.Size(87, 25);
            this.labelValueA.TabIndex = 2;
            this.labelValueA.Text = "Value A";
            // 
            // labelValueB
            // 
            this.labelValueB.AutoSize = true;
            this.labelValueB.Location = new System.Drawing.Point(526, 98);
            this.labelValueB.Name = "labelValueB";
            this.labelValueB.Size = new System.Drawing.Size(87, 25);
            this.labelValueB.TabIndex = 3;
            this.labelValueB.Text = "Value B";
            // 
            // textBoxAVal
            // 
            this.textBoxAVal.Location = new System.Drawing.Point(242, 95);
            this.textBoxAVal.Name = "textBoxAVal";
            this.textBoxAVal.Size = new System.Drawing.Size(181, 31);
            this.textBoxAVal.TabIndex = 4;
            // 
            // textBoxBVal
            // 
            this.textBoxBVal.Location = new System.Drawing.Point(683, 95);
            this.textBoxBVal.Name = "textBoxBVal";
            this.textBoxBVal.Size = new System.Drawing.Size(198, 31);
            this.textBoxBVal.TabIndex = 5;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(111, 269);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 25);
            this.labelResult.TabIndex = 6;
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(531, 164);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(197, 80);
            this.buttonSubtract.TabIndex = 7;
            this.buttonSubtract.Text = "Subtraction";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // AsyncStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 547);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxBVal);
            this.Controls.Add(this.textBoxAVal);
            this.Controls.Add(this.labelValueB);
            this.Controls.Add(this.labelValueA);
            this.Controls.Add(this.btnOperate);
            this.Controls.Add(this.btnSum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AsyncStart";
            this.Text = "Async Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnOperate;
        private System.Windows.Forms.Label labelValueA;
        private System.Windows.Forms.Label labelValueB;
        private System.Windows.Forms.TextBox textBoxAVal;
        private System.Windows.Forms.TextBox textBoxBVal;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonSubtract;
    }
}

