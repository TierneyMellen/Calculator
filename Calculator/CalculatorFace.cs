using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorFace : Form
    {
        int displayNumber;
        public CalculatorFace()
        {
            InitializeComponent();
        }

        private void updateNumber(String num)
        {
            txtDisplay.Text += num;
            /*displayNumber = Integer(txtDisplay.Text);
            
            if(txtDisplay.Text.Length > 3)
            {
                int leftover = txtDisplay.Text.Length % 3;
               // for(int i = 0; i < txtDisplay.Text.Length; i++)
                //{
                    txtDisplay.Text = txtDisplay.Text.Substring(0,leftover + 1 ) + "," 
                        + txtDisplay.Text.Substring(leftover + 1);
                //}
            }*/
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            updateNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            updateNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            updateNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            updateNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            updateNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            updateNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            updateNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            updateNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            updateNumber("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            updateNumber("0");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
    }
}
