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
        public TextBox activeTextBox { get; set; }
        public string outPutString { get; set; }

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
                activeTextBox.Text += tag;
            }
            else
            {
                switch (tag)
                {
                    case "back":
                        activeTextBox.Text = activeTextBox.Text.Remove(activeTextBox.Text.Length - 1);
                        break;
                    case "reset":
                        Reset();
                        break;
                    case "calculate":
                        CalculateResult();
                        break;

                }
            }
        }

        private void activeTextBox_Click(object sender, EventArgs e)
        {
            activeTextBox = sender as TextBox;
            //activeTextBox.Text = "";
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            activeTextBox = heightTextBox;
        }

        private void Reset()
        {
            heightTextBox.Text = "";
            weightTextBox.Text = "";
            resultTextBox.Text = "";
            statusTextBox.Text = "";
        }

        private string CalculateResult()
        {
            double height = Convert.ToDouble(heightTextBox.Text);
            double weight = Convert.ToDouble(weightTextBox.Text);
            double result;
            if(metricButton.Checked == true)
            {
                result = (weight / height / height) * 1000;
            }
            else
            {
                result = weight * 703 / (height * height);
            }
            return resultTextBox.Text = String.Format($"{result:F2}".ToString());
        }
    }
}
