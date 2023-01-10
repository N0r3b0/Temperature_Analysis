namespace Temperature_Analysis
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
            this.openFile = new System.Windows.Forms.Button();
            this.chartButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAvgValue = new System.Windows.Forms.TextBox();
            this.textBoxMinValue = new System.Windows.Forms.TextBox();
            this.textBoxVariance = new System.Windows.Forms.TextBox();
            this.textBoxMaxValue = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(507, 96);
            this.openFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(102, 26);
            this.openFile.TabIndex = 0;
            this.openFile.Text = "Open..";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // chartButton
            // 
            this.chartButton.Enabled = false;
            this.chartButton.Location = new System.Drawing.Point(507, 220);
            this.chartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(102, 26);
            this.chartButton.TabIndex = 1;
            this.chartButton.Text = "Chart...";
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(280, 417);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 26);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(79, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. Load the file with measurement results:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(79, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. Presentation of loaded samples:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(79, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "3. Calculated parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(79, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "4. Save the results";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(232, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(431, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Analysis of temperature measurement results";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(100, 193);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(718, 21);
            this.textBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(97, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Average value:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(97, 359);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Minimal value:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(504, 320);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Variance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 359);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Maximal value:";
            // 
            // textBoxAvgValue
            // 
            this.textBoxAvgValue.Enabled = false;
            this.textBoxAvgValue.Location = new System.Drawing.Point(236, 317);
            this.textBoxAvgValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAvgValue.Name = "textBoxAvgValue";
            this.textBoxAvgValue.Size = new System.Drawing.Size(146, 21);
            this.textBoxAvgValue.TabIndex = 13;
            // 
            // textBoxMinValue
            // 
            this.textBoxMinValue.Enabled = false;
            this.textBoxMinValue.Location = new System.Drawing.Point(236, 353);
            this.textBoxMinValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMinValue.Name = "textBoxMinValue";
            this.textBoxMinValue.Size = new System.Drawing.Size(146, 21);
            this.textBoxMinValue.TabIndex = 14;
            // 
            // textBoxVariance
            // 
            this.textBoxVariance.Enabled = false;
            this.textBoxVariance.Location = new System.Drawing.Point(672, 314);
            this.textBoxVariance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxVariance.Name = "textBoxVariance";
            this.textBoxVariance.Size = new System.Drawing.Size(146, 21);
            this.textBoxVariance.TabIndex = 15;
            // 
            // textBoxMaxValue
            // 
            this.textBoxMaxValue.Enabled = false;
            this.textBoxMaxValue.Location = new System.Drawing.Point(672, 353);
            this.textBoxMaxValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxMaxValue.Name = "textBoxMaxValue";
            this.textBoxMaxValue.Size = new System.Drawing.Size(146, 21);
            this.textBoxMaxValue.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(97, 226);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Open in chart:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files | *.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxMaxValue);
            this.Controls.Add(this.textBoxVariance);
            this.Controls.Add(this.textBoxMinValue);
            this.Controls.Add(this.textBoxAvgValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.chartButton);
            this.Controls.Add(this.openFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Value measurement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAvgValue;
        private System.Windows.Forms.TextBox textBoxMinValue;
        private System.Windows.Forms.TextBox textBoxVariance;
        private System.Windows.Forms.TextBox textBoxMaxValue;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

