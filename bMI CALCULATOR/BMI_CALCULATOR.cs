using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 *Name: Lovejot Singh
 *StudentId:300928227
 *Desc: BMI CALCULATOR
 *Version:0.2 Coding to calculate BMI */
namespace bMI_CALCULATOR
{
    public partial class BMI_CALCULATOR : Form
    {
        public BMI_CALCULATOR()
        {
            InitializeComponent();
        }
        private double _height;
        private double _weight;
        public double _BMIResult;
        double h;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BMI_Value.BackColor = Color.White;
            // if radio button metric or imperial is selected then
            if (_METRIC.Checked)
            {
                radioButton1_CheckedChanged(sender, e);
                h = _height / 100;
                Height.ReadOnly.ToString();
                Weight.ReadOnly.ToString();
                _BMIResult = (_weight / (h * h));
                BMI_Value.Text = _BMIResult.ToString();
                BMI_Value.BackColor = Color.White;
            }
            if (_IMPERIAL.Checked)
            {
                _IMPERIAL_CheckedChanged(sender, e);
                Height.ReadOnly.ToString();
                Weight.ReadOnly.ToString();
                _BMIResult = (_weight / (_height * _height)) * 702;
                BMI_Value.Text = _BMIResult.ToString();
                BMI_Value.BackColor = Color.White;
            }
            if (_BMIResult <= 18.5)
            {
                BMI_Value.Text = _BMIResult + " Underweight";
            }
            else if (_BMIResult <= 24.9)
            {
                BMI_Value.Text = _BMIResult + " Healthy";
            }
            else if (_BMIResult <= 29.9)
            {
                BMI_Value.Text = _BMIResult + " Overweight";
            }
            else if (_BMIResult >= 30.0)
            {
                BMI_Value.Text = _BMIResult + " Obese";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // WHEN USER CLICK METRIC THE FORMAT OF BMI WILL BE CHANGED
            if (_METRIC.Checked)
            {
                cm.Text = "cm";
                kg.Text = "kg";
            }
        }

        private void BMI_Value_TextChanged(object sender, EventArgs e)
        {

        }

        private void Height_TextChanged(object sender, EventArgs e)
        {
            // adding value to the text box of My height
            _height = double.Parse(Height.Text);
        }

        private void Weight_TextChanged(object sender, EventArgs e)
        {         
            // adding value to the text box of My Weight
            _weight = double.Parse(Weight.Text);

        }

        private void _IMPERIAL_CheckedChanged(object sender, EventArgs e)
        {
            if (_IMPERIAL.Checked)
            {
                cm.Text = "inch";
                kg.Text = "lbs";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void _clear()
        {
        }
        private void kg_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {

            //NameTextBox.Text = "";
            //AgeTextBox.Text = "";
            //HeightTextBox.Text = "";
            //WeightTextBox.Text = "";
            // ResultextBox.Text = "";
            // RemarkTextBox.Text = "";
            BMI_CALCULATOR NewForm = new BMI_CALCULATOR();
            NewForm.Show();
            this.Dispose(false);
        }

        private void BMI_CALCULATOR_Load(object sender, EventArgs e)
        {

        }
    }
    }
