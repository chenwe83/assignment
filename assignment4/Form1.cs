﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4
{
    public partial class BmiCalculator : Form
    {
        public BmiCalculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metricButten_CheckedChanged(object sender, EventArgs e)
        {

            feetLabel.Text = "Inche";
            feetbox.Visible = false;
            kiloTextBox.Visible = false;
            kiloLable.Text = "Pounds";

        }

        private void imperialButten_CheckedChanged(object sender, EventArgs e)
        {
            feetbox.Visible = true;
            kiloTextBox.Visible = true;
            feetLabel.Text = "Feet";
            kiloLable.Text = "Kilograms";
        }
    }
}