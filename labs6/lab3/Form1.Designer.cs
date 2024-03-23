namespace lab3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTemperature = new System.Windows.Forms.RadioButton();
            this.radioButtonHumodity = new System.Windows.Forms.RadioButton();
            this.radioButtonWind = new System.Windows.Forms.RadioButton();
            this.checkBoxViewType = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(-2, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 429);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 31);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(881, 395);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxViewType);
            this.groupBox1.Controls.Add(this.radioButtonWind);
            this.groupBox1.Controls.Add(this.radioButtonTemperature);
            this.groupBox1.Controls.Add(this.radioButtonHumodity);
            this.groupBox1.Location = new System.Drawing.Point(1, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose parameter to view";
            // 
            // radioButtonTemperature
            // 
            this.radioButtonTemperature.AutoSize = true;
            this.radioButtonTemperature.Location = new System.Drawing.Point(337, 44);
            this.radioButtonTemperature.Name = "radioButtonTemperature";
            this.radioButtonTemperature.Size = new System.Drawing.Size(165, 29);
            this.radioButtonTemperature.TabIndex = 1;
            this.radioButtonTemperature.Text = "Temperature";
            this.radioButtonTemperature.UseVisualStyleBackColor = true;
            this.radioButtonTemperature.CheckedChanged += new System.EventHandler(this.radioButtonTemperature_CheckedChanged);
            // 
            // radioButtonHumodity
            // 
            this.radioButtonHumodity.AutoSize = true;
            this.radioButtonHumodity.Location = new System.Drawing.Point(136, 44);
            this.radioButtonHumodity.Name = "radioButtonHumodity";
            this.radioButtonHumodity.Size = new System.Drawing.Size(126, 29);
            this.radioButtonHumodity.TabIndex = 0;
            this.radioButtonHumodity.Text = "Humidity";
            this.radioButtonHumodity.UseVisualStyleBackColor = true;
            this.radioButtonHumodity.CheckedChanged += new System.EventHandler(this.radioButtonHumodity_CheckedChanged);
            // 
            // radioButtonWind
            // 
            this.radioButtonWind.AutoSize = true;
            this.radioButtonWind.Checked = true;
            this.radioButtonWind.Location = new System.Drawing.Point(561, 44);
            this.radioButtonWind.Name = "radioButtonWind";
            this.radioButtonWind.Size = new System.Drawing.Size(92, 29);
            this.radioButtonWind.TabIndex = 2;
            this.radioButtonWind.TabStop = true;
            this.radioButtonWind.Text = "Wind";
            this.radioButtonWind.UseVisualStyleBackColor = true;
            this.radioButtonWind.CheckedChanged += new System.EventHandler(this.radioButtonWind_CheckedChanged);
            // 
            // checkBoxViewType
            // 
            this.checkBoxViewType.AutoSize = true;
            this.checkBoxViewType.Location = new System.Drawing.Point(136, 90);
            this.checkBoxViewType.Name = "checkBoxViewType";
            this.checkBoxViewType.Size = new System.Drawing.Size(156, 29);
            this.checkBoxViewType.TabIndex = 3;
            this.checkBoxViewType.Text = "Switch view";
            this.checkBoxViewType.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 642);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonTemperature;
        private System.Windows.Forms.RadioButton radioButtonHumodity;
        private System.Windows.Forms.RadioButton radioButtonWind;
        private System.Windows.Forms.CheckBox checkBoxViewType;
    }
}

