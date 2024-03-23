namespace lab1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textBoxDataA = new System.Windows.Forms.TextBox();
            this.textBoxDataB = new System.Windows.Forms.TextBox();
            this.labelOne = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.labelThree = new System.Windows.Forms.Label();
            this.groupBoxExpression = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBoxExpression.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(718, 79);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(188, 67);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBoxDataA
            // 
            this.textBoxDataA.Location = new System.Drawing.Point(80, 48);
            this.textBoxDataA.Name = "textBoxDataA";
            this.textBoxDataA.Size = new System.Drawing.Size(130, 31);
            this.textBoxDataA.TabIndex = 1;
            // 
            // textBoxDataB
            // 
            this.textBoxDataB.Location = new System.Drawing.Point(357, 48);
            this.textBoxDataB.Name = "textBoxDataB";
            this.textBoxDataB.Size = new System.Drawing.Size(130, 31);
            this.textBoxDataB.TabIndex = 2;
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Location = new System.Drawing.Point(11, 51);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(56, 25);
            this.labelOne.TabIndex = 3;
            this.labelOne.Text = "Sin (";
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Location = new System.Drawing.Point(226, 51);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(112, 25);
            this.labelTwo.TabIndex = 4;
            this.labelTwo.Text = "* x) + Sin (";
            // 
            // labelThree
            // 
            this.labelThree.AutoSize = true;
            this.labelThree.Location = new System.Drawing.Point(493, 51);
            this.labelThree.Name = "labelThree";
            this.labelThree.Size = new System.Drawing.Size(50, 25);
            this.labelThree.TabIndex = 5;
            this.labelThree.Text = "* x) ";
            // 
            // groupBoxExpression
            // 
            this.groupBoxExpression.Controls.Add(this.textBoxDataA);
            this.groupBoxExpression.Controls.Add(this.labelThree);
            this.groupBoxExpression.Controls.Add(this.textBoxDataB);
            this.groupBoxExpression.Controls.Add(this.labelTwo);
            this.groupBoxExpression.Controls.Add(this.labelOne);
            this.groupBoxExpression.Location = new System.Drawing.Point(86, 49);
            this.groupBoxExpression.Name = "groupBoxExpression";
            this.groupBoxExpression.Size = new System.Drawing.Size(582, 119);
            this.groupBoxExpression.TabIndex = 6;
            this.groupBoxExpression.TabStop = false;
            this.groupBoxExpression.Text = "Sum of sines";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(86, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 394);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(718, 181);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(178, 42);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 659);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxExpression);
            this.Controls.Add(this.btnCalculate);
            this.MinimumSize = new System.Drawing.Size(1033, 730);
            this.Name = "Form1";
            this.Text = "Sum of sines calculation";
            this.groupBoxExpression.ResumeLayout(false);
            this.groupBoxExpression.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textBoxDataA;
        private System.Windows.Forms.TextBox textBoxDataB;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.Label labelThree;
        private System.Windows.Forms.GroupBox groupBoxExpression;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
    }
}

