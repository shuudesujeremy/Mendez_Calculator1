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
       


        private void btn0_Click(object sender, EventArgs e)
        {
            NumSave("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NumSave("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NumSave("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NumSave("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NumSave("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NumSave("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NumSave("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NumSave("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NumSave("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
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
    }

        
}
