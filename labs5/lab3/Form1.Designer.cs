namespace lab3
{
    partial class WinAnim
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
            this.btnAW_Blend = new System.Windows.Forms.Button();
            this.btnAW_HorSlide = new System.Windows.Forms.Button();
            this.btnAW_CenterSlide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAW_Blend
            // 
            this.btnAW_Blend.Location = new System.Drawing.Point(68, 161);
            this.btnAW_Blend.Name = "btnAW_Blend";
            this.btnAW_Blend.Size = new System.Drawing.Size(177, 90);
            this.btnAW_Blend.TabIndex = 0;
            this.btnAW_Blend.Text = "Show";
            this.btnAW_Blend.UseVisualStyleBackColor = true;
            this.btnAW_Blend.Click += new System.EventHandler(this.btnAW_Blend_Click);
            // 
            // btnAW_HorSlide
            // 
            this.btnAW_HorSlide.Location = new System.Drawing.Point(311, 161);
            this.btnAW_HorSlide.Name = "btnAW_HorSlide";
            this.btnAW_HorSlide.Size = new System.Drawing.Size(177, 90);
            this.btnAW_HorSlide.TabIndex = 1;
            this.btnAW_HorSlide.Text = "Horizontal Show";
            this.btnAW_HorSlide.UseVisualStyleBackColor = true;
            this.btnAW_HorSlide.Click += new System.EventHandler(this.btnAW_HorSlide_Click);
            // 
            // btnAW_CenterSlide
            // 
            this.btnAW_CenterSlide.Location = new System.Drawing.Point(556, 161);
            this.btnAW_CenterSlide.Name = "btnAW_CenterSlide";
            this.btnAW_CenterSlide.Size = new System.Drawing.Size(177, 90);
            this.btnAW_CenterSlide.TabIndex = 2;
            this.btnAW_CenterSlide.Text = "Center Show";
            this.btnAW_CenterSlide.UseVisualStyleBackColor = true;
            this.btnAW_CenterSlide.Click += new System.EventHandler(this.btnAW_CenterSlide_Click);
            // 
            // WinAnim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAW_CenterSlide);
            this.Controls.Add(this.btnAW_HorSlide);
            this.Controls.Add(this.btnAW_Blend);
            this.Name = "WinAnim";
            this.Text = "Animation Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAW_Blend;
        private System.Windows.Forms.Button btnAW_HorSlide;
        private System.Windows.Forms.Button btnAW_CenterSlide;
    }
}

