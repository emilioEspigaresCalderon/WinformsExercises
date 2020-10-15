﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsExercise4B
{
    public partial class Form1 : Form
    {
        int op1, op2, res;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToInt32(textBox1.Text);
            op2 = Convert.ToInt32(textBox2.Text);

            switch (listBox1.Text)
            {
                case "-":
                    res = op1 - op2;
                    textBox3.Text = Convert.ToString(res);
                    break;
                case "+":
                    res = op1 + op2;
                    textBox3.Text = Convert.ToString(res);
                    break;
                case "--Select--":
                    MessageBox.Show("Warning! Operation not selected!");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }
    }
}
