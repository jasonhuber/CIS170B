using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsFiveInputs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                TextBox txtNum1 = new TextBox();
                txtNum1.Visible = true;
                txtNum1.Location = new Point(10, 35 * i);
                txtNum1.Width = 100;
                txtNum1.Height = 30;
                txtNum1.Name = "txtNum" + i.ToString();
                this.Controls.Add(txtNum1);
            }

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            double high =0 , low =11110, average = 0;
//            MessageBox.Show(this.Controls.Count.ToString());
            foreach (Control xcontrol in this.Controls)
            {
               if (xcontrol.GetType().ToString().EndsWith("TextBox"))
                {
                    if (double.Parse(xcontrol.Text)> high)
                    {
                        high = double.Parse(xcontrol.Text);
                    }
                    if (double.Parse(xcontrol.Text) < low)
                    {
                        low = double.Parse(xcontrol.Text);
                    }
                    average += double.Parse(xcontrol.Text);

                }
            }
            average -= low + high;
            average /= 3;
            MessageBox.Show(string.Format("{0:0.##}",average.ToString()));
        }
    }
}
