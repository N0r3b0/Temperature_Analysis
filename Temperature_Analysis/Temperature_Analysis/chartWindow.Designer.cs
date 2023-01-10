namespace Temperature_Analysis
{
    partial class chartWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxProbes = new System.Windows.Forms.CheckBox();
            this.checkBoxDiff = new System.Windows.Forms.CheckBox();
            this.checkBoxLegend = new System.Windows.Forms.CheckBox();
            this.colorProbs = new System.Windows.Forms.ComboBox();
            this.colorDiff = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(215, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Measurement results analysis - chart";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(122, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chart options";
            // 
            // checkBoxProbes
            // 
            this.checkBoxProbes.AutoSize = true;
            this.checkBoxProbes.Checked = true;
            this.checkBoxProbes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProbes.Location = new System.Drawing.Point(125, 401);
            this.checkBoxProbes.Name = "checkBoxProbes";
            this.checkBoxProbes.Size = new System.Drawing.Size(119, 17);
            this.checkBoxProbes.TabIndex = 11;
            this.checkBoxProbes.Text = "Show sample series";
            this.checkBoxProbes.UseVisualStyleBackColor = true;
            this.checkBoxProbes.CheckedChanged += new System.EventHandler(this.checkBoxProbes_CheckedChanged);
            // 
            // checkBoxDiff
            // 
            this.checkBoxDiff.AutoSize = true;
            this.checkBoxDiff.Checked = true;
            this.checkBoxDiff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDiff.Location = new System.Drawing.Point(125, 434);
            this.checkBoxDiff.Name = "checkBoxDiff";
            this.checkBoxDiff.Size = new System.Drawing.Size(160, 17);
            this.checkBoxDiff.TabIndex = 12;
            this.checkBoxDiff.Text = "Show series with differences";
            this.checkBoxDiff.UseVisualStyleBackColor = true;
            this.checkBoxDiff.CheckedChanged += new System.EventHandler(this.checkBoxDiff_CheckedChanged);
            // 
            // checkBoxLegend
            // 
            this.checkBoxLegend.AutoSize = true;
            this.checkBoxLegend.Checked = true;
            this.checkBoxLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLegend.Location = new System.Drawing.Point(488, 401);
            this.checkBoxLegend.Name = "checkBoxLegend";
            this.checkBoxLegend.Size = new System.Drawing.Size(88, 17);
            this.checkBoxLegend.TabIndex = 13;
            this.checkBoxLegend.Text = "Show legend";
            this.checkBoxLegend.UseVisualStyleBackColor = true;
            this.checkBoxLegend.CheckedChanged += new System.EventHandler(this.checkBoxLegend_CheckedChanged);
            // 
            // colorProbs
            // 
            this.colorProbs.FormattingEnabled = true;
            this.colorProbs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colorProbs.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red"});
            this.colorProbs.Location = new System.Drawing.Point(302, 399);
            this.colorProbs.Name = "colorProbs";
            this.colorProbs.Size = new System.Drawing.Size(121, 21);
            this.colorProbs.TabIndex = 14;
            this.colorProbs.SelectedIndexChanged += new System.EventHandler(this.colorProbs_SelectedIndexChanged);
            // 
            // colorDiff
            // 
            this.colorDiff.FormattingEnabled = true;
            this.colorDiff.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.colorDiff.Location = new System.Drawing.Point(302, 434);
            this.colorDiff.Name = "colorDiff";
            this.colorDiff.Size = new System.Drawing.Size(121, 21);
            this.colorDiff.TabIndex = 15;
            this.colorDiff.SelectedIndexChanged += new System.EventHandler(this.colorDiff_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(99, 89);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series1.Legend = "Legend1";
            series1.Name = "Probes";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Differences";
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(628, 248);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // chartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.colorDiff);
            this.Controls.Add(this.colorProbs);
            this.Controls.Add(this.checkBoxLegend);
            this.Controls.Add(this.checkBoxDiff);
            this.Controls.Add(this.checkBoxProbes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "chartWindow";
            this.Text = "Chart window";
            this.Load += new System.EventHandler(this.chartWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxProbes;
        private System.Windows.Forms.CheckBox checkBoxDiff;
        private System.Windows.Forms.CheckBox checkBoxLegend;
        private System.Windows.Forms.ComboBox colorDiff;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox colorProbs;
    }
}