using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace Temperature_Analysis
{
    public partial class chartWindow : Form
    {
        public chartWindow()
        {
            InitializeComponent();

        }

        public static Series s1, s2;
        public static Legend legend;
        public static ChartArea area;
        public static double[] dataChart;

        private void chartWindow_Load(object sender, EventArgs e)
        {
            dataChart = Form1.data;
            chartData();

            colorProbs.SelectedIndex = 0;
            colorDiff.SelectedIndex = 0;
            legend = chart1.Legends[0];
            legend.Title = "Legend";
            area = chart1.ChartAreas[0];
            area.Axes[0].Title = "Measurement number";
            area.Axes[1].Title = "Measurement result";
        }

        private void checkBoxProbes_CheckedChanged(object sender, EventArgs e)
        {
            if (s1.Enabled) s1.Enabled = false;
            else s1.Enabled = true;     
        }

        private void checkBoxDiff_CheckedChanged(object sender, EventArgs e)
        {
            if (s2.Enabled) s2.Enabled = false;
            else s2.Enabled = true;
        }

        private void checkBoxLegend_CheckedChanged(object sender, EventArgs e)
        {
            legend = chart1.Legends[0];
            if (legend.Enabled) legend.Enabled = false;
            else  legend.Enabled = true;
        }

        private void colorProbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            area = chart1.ChartAreas[0];
            colorProbs.DropDownStyle = ComboBoxStyle.DropDownList;

            switch (colorProbs.SelectedIndex)
            {
                case 0:
                    s1.Color = Color.Blue;    
                    break;

                case 1:
                    s1.Color = Color.Green;
                    break;

                case 2:
                    s1.Color = Color.Red;
                    break;

                default:
                    break;

            }
        }

        private void colorDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            area = chart1.ChartAreas[0];
            colorDiff.DropDownStyle = ComboBoxStyle.DropDownList;

            switch (colorDiff.SelectedIndex)
            {
                case 0:
                    s2.Color = Color.Red;
                    break;

                case 1:
                    s2.Color = Color.Green;
                    break;

                case 2:
                    s2.Color = Color.Blue;
                    break;

                default:
                    break;

            }
        }

        private void chartData()
        {
            s1 = chart1.Series[0];
            s2 = chart1.Series[1];
            

            for (int i = 0; i < dataChart.Length; i++)
                s1.Points.AddXY(i+1, dataChart[i]);

            for (int i = 1; i < dataChart.Length; i++)
                s2.Points.AddXY(i, dataChart[i] - dataChart[i - 1]);
        }


    }
}
