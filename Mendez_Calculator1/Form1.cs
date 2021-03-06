using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mendez_Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String firstNum;
        String operation;
        Boolean isOperationPerformed;
        Boolean isEqualPerformed;
       


        private void btn0_Click(object sender, EventArgs e)
        {
            EqualClear();
            RemoveZero();
            NumSave("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EqualClear();
            RemoveZero();
            NumSave("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EqualClear();
            RemoveZero();
            NumSave("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EqualClear();
            RemoveZero();
            NumSave("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EqualClear();
            RemoveZero();
            NumSave("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EqualClear();
            RemoveZero();
            NumSave("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EqualClear();
            RemoveZero();
            NumSave("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EqualClear();
            RemoveZero();
            NumSave("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EqualClear();
            RemoveZero();
            NumSave("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EqualClear();
            RemoveZero();
            NumSave("9");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtbxDisplay.Text += ".";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            OperationSave("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            OperationSave("-");
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            OperationSave("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            OperationSave("/");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtbxDisplay.Text = "0";
            isOperationPerformed = false;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            firstNum = "";
            txtbxDisplay.Text = "0";
            isOperationPerformed = false;
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtbxDisplay.Text.Length > 0)
            {
                txtbxDisplay.Text = txtbxDisplay.Text.Remove(txtbxDisplay.Text.Length - 1, 1);
            }

            if (txtbxDisplay.Text == "")
            {
                txtbxDisplay.Text = "0";
            }
        }

        private void NumSave(string number)
        {
            if (isOperationPerformed)
            {
                firstNum = txtbxDisplay.Text;
                numDisplay.Text = firstNum; 
                txtbxDisplay.Text = "";
            }

            txtbxDisplay.Text += number;
            isOperationPerformed = false;
        }

        private void OperationSave(string operand)
        {
            operation = operand;
            isOperationPerformed = true;
        }

        private void RemoveZero()
        {
            if (txtbxDisplay.Text == "0")
            {
                txtbxDisplay.Clear();
            }
        }

        private void EqualClear()
        {
            if (isEqualPerformed)
            {
                txtbxDisplay.Clear();
                isEqualPerformed = false;
            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            isEqualPerformed = true;
            float num1;
            float num2;
            num1 = float.Parse(firstNum);
            num2 = float.Parse(txtbxDisplay.Text);

            switch (operation)
            {
                case "+":
                    txtbxDisplay.Text = Convert.ToString(num1 + num2);
                    numDisplay.Text = Convert.ToString(num1) + " + " + Convert.ToString(num2);
                    break;

                case "-":
                    numDisplay.Text = Convert.ToString(num1) + " + " + Convert.ToString(num2);
                    txtbxDisplay.Text = Convert.ToString(num1 - num2);
                    break;

                case "*":
                    numDisplay.Text = Convert.ToString(num1) + " + " + Convert.ToString(num2);
                    txtbxDisplay.Text = Convert.ToString(num1 * num2);
                    break;

                case "/":
                    txtbxDisplay.Text = Convert.ToString(num1 / num2);
                    numDisplay.Text = Convert.ToString(num1) + " + " + Convert.ToString(num2);
                    if (num2 == 0)
                    {
                        txtbxDisplay.Text = "Error";
                    }
                    break;

                default:
                    break;
            }
        }

        private void txtbxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void numDisplay_Click(object sender, EventArgs e)
        {

        }
    }

        
}
