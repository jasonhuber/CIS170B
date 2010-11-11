using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            double number1, number2;

            if (CheckInputs(txtNum1.Text, txtNum2.Text, out number1, out number2))
            {
                txtResult.Text = (number1 + number2).ToString();
            }
            else 
            {
                txtNum1.ForeColor = System.Drawing.Color.Red;
                txtResult.Text = "invalid entry";
            }
        }

        private bool CheckInputs(string inNum1, string inNum2, out double number1, out double number2)
        {
            number1 = 0;
            number2 = 0;
            if (double.TryParse(inNum1, out number1) &&
                double.TryParse(inNum2, out number2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double number1, number2;

            if (CheckInputs(txtNum1.Text, txtNum2.Text, out number1, out number2))
            {
                txtResult.Text = (number1 - number2).ToString();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double number1, number2;

            if (CheckInputs(txtNum1.Text, txtNum2.Text, out number1, out number2))
            {
                if (number2 != 0)
                {
                    txtResult.Text = (number1 / number2).ToString();
                    
                }
            }

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double number1, number2;

            if (CheckInputs(txtNum1.Text, txtNum2.Text, out number1, out number2))
            {
                txtResult.Text = (number1 * number2).ToString();
            }
        }

    }
}
