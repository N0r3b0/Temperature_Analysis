using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Temperature_Analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double[] data;
        public static double avarageValue, minValue, variance, maxValue;

     
        public static double[] dataDoubleParse(string[] lines) //parsowanie danych
        {
            double[] data = new double[lines.Length - 1]; //-1 bo pierwszy element lines to "wyniki pomiarow"
            for (int i = 0; i < data.Length; i++) //-1 bo dlugosc data tyle wynosi
            {
                lines[i + 1] = lines[i + 1].Replace(";", ""); //i+1 bo wykluczam element 0
                data[i] = double.Parse(lines[i + 1]); //i+1 bo wykluczam element 0
            }
            return data;
        }


        public void results(double[] data) //oblicza wyniki
        {
            //wart srednia
            double sum = 0;
            double varianceSum = 0;
            for (int i = 0; i < data.Length; i++) sum += data[i];
            avarageValue = sum / data.Length;
            textBoxAvgValue.Text = avarageValue.ToString("0.000000");

            //wart min
            minValue = data.Min();
            textBoxMinValue.Text = minValue.ToString("0.000000");

            //wariancja
            for (int i = 0; i < data.Length; i++)
            {
                varianceSum += Math.Pow(data[i] - data.Average(), 2);
            }
            variance = varianceSum / data.Length;
            textBoxVariance.Text = variance.ToString("0.000000");


            //wart maks
            maxValue = data.Max();
            textBoxMaxValue.Text = maxValue.ToString("0.000000");
        }


        private void openFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string filedata = File.ReadAllText(filename);
                try 
                {
                    string[] fileLines = File.ReadAllLines(filename);
                    double[] data = dataDoubleParse(fileLines); //double array z danymi                 

                    textBox1.Text = filedata;   // wyswietla zawartosc pliku z danymi

                    chartButton.Enabled = true;
                    saveButton.Enabled = true;

                    Form1.data = data;
                    results(data);
                }
                catch (Exception) 
                {
                    MessageBox.Show("Failed to read the file", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
        }


        private void chartButton_Click(object sender, EventArgs e)
        {
            chartWindow chart = new chartWindow();
            chart.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            //wartSr, wartMin, wariancja, wartMax;
              
            if(result == DialogResult.OK)
            {
                string save = "Avarage value: " + avarageValue + "\n" + "Minimal value: " + minValue + "\n" 
                    + "Variance: " + variance + "\n" + "Maximal value: " + maxValue;
                string filename = saveFileDialog1.FileName;

                if (filename.EndsWith(".txt"))
                {
                    File.WriteAllText(filename, save);          //save file
                    MessageBox.Show("Saved correctly");
                }
                if (!filename.EndsWith(".txt")) MessageBox.Show("The file has not been saved, incorrect format", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // /\if not txt error
            }
            if(result != DialogResult.OK) MessageBox.Show("The file has not been saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // /\if not ok error
        }

    }
}
