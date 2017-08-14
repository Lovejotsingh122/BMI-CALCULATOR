using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*GITHUB LINK:https://github.com/Lovejotsingh122/BMI-CALCULATOR
 * Name:Lovejot Singh
 * Student Number: 300928227
 * DATE:14 AUGUST 2017
 * DESC: creating splash form class
 * version :0.5 -Removed progress bar for timer
 */
namespace bMI_CALCULATOR
{
    public partial class Splash_form : Form
    {
        public Splash_form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// event handler for the "tick" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            BMI_CALCULATOR bmiCalculator = new BMI_CALCULATOR();
            bmiCalculator.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            //progressBar1.Increment(100);
        }

        private void Splash_form_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SplashFormTimer_Tick_1(object sender, EventArgs e)
        {
            BMI_CALCULATOR bmiCalculator = new BMI_CALCULATOR();
            bmiCalculator.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;//it is used to turn timer off

        }
    }
}
