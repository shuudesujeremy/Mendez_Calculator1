﻿using System;
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

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnTimes_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {

        }

        private void btnAC_Click(object sender, EventArgs e)
        {

        }

        private void btnBS_Click(object sender, EventArgs e)
        {

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
    }
}
