using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsFibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
         //   Console.WriteLine("Please enter a number of times to loop!");
            int numloop;
            numloop = int.Parse(txtLoops.Text);
            int prevnum = 1;
            int newnum = 1;
            int placeholdernum = 1;
            for (int i = 0; i < numloop; i++)
            {
                placeholdernum = prevnum + newnum;
                newnum = prevnum;
                prevnum = placeholdernum;
            }
            lblResult.Text = "Your final number is: " + placeholdernum.ToString();
//            Console.ReadLine();
        }
    }
}
