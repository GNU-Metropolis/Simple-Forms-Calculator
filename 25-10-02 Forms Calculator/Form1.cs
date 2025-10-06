using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_10_02_Forms_Calculator
{
    public partial class Form1 : Form
    {
        double total = 0;
        bool firstPress = true;
        bool replaceTextBoxValue = true;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            valueAddReplace(btn5.Text);
        }

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    txtDisplay.Text += btn1.Text;
        //}

        //private void btn2_Click(object sender, EventArgs e)
        //{
        //    txtDisplay.Text += btn2.Text;
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    txtDisplay.Text += btn1.Text;
        //}

        private void btn1_Click(object sender, EventArgs e)
        {
            valueAddReplace(btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            valueAddReplace(btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            valueAddReplace(btn3.Text); 
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            valueAddReplace(btn4.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            valueAddReplace(btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            valueAddReplace(btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            valueAddReplace(btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            valueAddReplace(btn9.Text);

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (firstPress)
            {
                total += Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "0";
                firstPress = false;
            }
            else
            {
                if (operation == "add")
                {
                    total += Convert.ToDouble(txtDisplay.Text);
                    
                }
                else if (operation == "subtract")
                {
                    total -= Convert.ToDouble(txtDisplay.Text);
                }
                txtDisplay.Text = total.ToString();
            }
            operation = "add";
            replaceTextBoxValue = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
           if (operation == "add")
           {
                total += Convert.ToDouble(txtDisplay.Text);
           }
           else if (operation == "subtract")
           {
               total -= Convert.ToDouble(txtDisplay.Text); // TODO: fix weird interaction where equals swaps a value from positive to negative and vice versa
           }
           txtDisplay.Text = total.ToString();
           total = 0;
           replaceTextBoxValue = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            txtDisplay.Text = "0";
            firstPress = true;
            replaceTextBoxValue = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (firstPress)
            {
                total += Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "0";
                firstPress = false;
            }
            else
            {
                if (operation == "add")
                {
                    total += Convert.ToDouble(txtDisplay.Text);
                }
                else if (operation == "subtract")
                {
                    total -= Convert.ToDouble(txtDisplay.Text);
                }
                txtDisplay.Text = total.ToString();
            }
            operation = "subtract";
            replaceTextBoxValue = true;
        }
        private void valueAddReplace(string x)
        {
            if (replaceTextBoxValue)
            {
                txtDisplay.Text = x;
                replaceTextBoxValue = false; // Do not replace the text box value with user input, since they are now actively inputting values (button clicked) and thus this would remove the
            }                                // ability to add 2 or more digit numbers (seeing as it would just constantly replace the value)
            else
            {
                txtDisplay.Text += x;
            }
        }
    }
}
