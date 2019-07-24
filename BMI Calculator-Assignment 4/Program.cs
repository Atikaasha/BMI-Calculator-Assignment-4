using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* BMI Calculator
 * Description: COMP123 Assignment
 * Author: Chowdhury Atika Parvin
 * ID# 301007336
 * Version: 1.5 Exception Handling completed
 * Last modified: July 23, 2019
 */
namespace BMI_Calculator_Assignment_4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SplashForm splashForm;
        public static BMICalculator bMICalculator;
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashForm = new SplashForm();
            bMICalculator = new BMICalculator();
            Application.Run(new SplashForm());
        }
    }
}
