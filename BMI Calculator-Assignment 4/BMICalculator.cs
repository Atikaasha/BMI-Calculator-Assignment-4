using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator_Assignment_4
{
    public partial class BMICalculator : Form
    {
        public TextBox ActiveTextBox { get; set; }
        //public string OutPutString { get; set; }
        private double Result { get; set; }

        public BMICalculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var tag = button.Tag.ToString();
            int numericValue;
            bool numericButton = int.TryParse(tag, out numericValue);
            if(numericButton)
            {
                ActiveTextBox.Text += tag;
            }
            else
            {
                switch (tag)
                {
                    case "back":
                        if(ActiveTextBox.Text.Length !=0)
                        {
                            ActiveTextBox.Text = ActiveTextBox.Text.Remove(ActiveTextBox.Text.Length - 1);
                        }
                        else
                        {

                        }                       
                        break;
                    case "reset":
                        Reset();
                        break;
                    case "calculate":
                        CalculateResult();
                        ShowStatus();
                        break;                       
                }
            }
        }

        private void activeTextBox_Click(object sender, EventArgs e)
        {
            ActiveTextBox = sender as TextBox;
            //activeTextBox.Text = "";
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            ActiveTextBox = heightTextBox;
        }

        private void Reset()
        {
            heightTextBox.Text = "";
            weightTextBox.Text = "";
            resultTextBox.Text = "Your BMI";
            statusTextBox.Text = "";
            progressBar.Value = 0;

        }

        private void CalculateResult()
        {
            bool heightIsNumeric = int.TryParse(heightTextBox.Text, out int myHeight);
            bool weightIsNumeric = int.TryParse(weightTextBox.Text, out int myWeight);
            if (heightTextBox.Text != "" && weightTextBox.Text != "" && heightIsNumeric && weightIsNumeric)
            {   
                double height = Convert.ToDouble(heightTextBox.Text);
                double weight = Convert.ToDouble(weightTextBox.Text);
                //double result;
                if (metricButton.Checked == true)
                {
                    Result = (weight / height / height) * 10000;
                    resultTextBox.Text = String.Format($"{Result:F2}".ToString());
                }
                else
                {
                    Result = weight * 703 / (height * height);
                    resultTextBox.Text = String.Format($"{Result:F2}".ToString());
                }            
            }
            else if(Result<=0)
            { 
                resultTextBox.Text="Invalid value!!!";
                resultTextBox.ForeColor = Color.Red;
                progressBar.Value = 0;
                statusTextBox.Text = "";
            }
          
        }

        private void metricButton_Checked(object sender, EventArgs e)
        {
            heightUnitLabel.Text = "cm";
            weightUnitLabel.Text = "kg";
        }

        private void imperialButton_Checked(object sender, EventArgs e)
        {
            heightUnitLabel.Text = "inch";
            weightUnitLabel.Text = "lb";
        }
        private void ShowStatus()
        {
            progressBar.Maximum = 4;
            if(Result<18.5 && Result>0)
            {
                statusTextBox.Text = "Underweight";
                statusTextBox.ForeColor = Color.Blue;
                progressBar.Value = 1;
                progressBar.ForeColor = Color.Blue;
            }
            else if(Result>=18.5 && Result<=24.9)
            {
                statusTextBox.Text = "Normal";
                statusTextBox.ForeColor = Color.Green;
                progressBar.Value = 2;
                progressBar.ForeColor = Color.Green;
            }
            else if (Result >= 25 && Result <= 29.9)
            {
                statusTextBox.Text = "Overweight";
                statusTextBox.ForeColor = Color.Firebrick;
                progressBar.Value = 3;
                progressBar.ForeColor = Color.Firebrick;
            }
            else if (Result > 30)
            {
                statusTextBox.Text = "Obese";
                statusTextBox.ForeColor = Color.Red;
                progressBar.Value = 4;
                progressBar.ForeColor = Color.Red;
            }
        }
    }
}
