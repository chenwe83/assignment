using System;
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
            inchebox.Visible = true;
            poundTextBox.Visible = true;
            kiloLable.Text = "Pounds";

        }

        private void imperialButten_CheckedChanged(object sender, EventArgs e)
        {
            feetbox.Visible = true;
            kiloTextBox.Visible = true;
            inchebox.Visible = false;
            poundTextBox.Visible = false;
            feetLabel.Text = "Feet";
            kiloLable.Text = "Kilograms";
        }

        private void BmiCalculator_Load(object sender, EventArgs e)
        {

        }

        private void calculatButten_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculatButten_Click(object sender, EventArgs e)
        {

            double feet = Convert.ToDouble(feetbox.Text);
            double kilo = Convert.ToDouble(kiloTextBox.Text);
            double inche = Convert.ToDouble(inchebox.Text);
            double pound = Convert.ToDouble(poundTextBox.Text);




            double result = 0;
            if (imperialButten.Checked)
            {

                result = (kilo * 703) / (feet * feet);
            }
            else if (metricButten.Checked)
            {

                result = (pound) / (inche / 100) * (inche / 100);
            }
            bmiTextBox.Text = result.ToString();

            if (result < 18.5)
            {
                underTextbox.Visible = true;
            }
            else if (result >= 18.5 && result < 25)
            {
                normalTextbox.Visible = true;
            }
            else if (result >= 25 && result < 30)
            {
                overTextbox.Visible = true;
            }
            else if (result >= 30)
            {
                obeseTextbox.Visible = true;
            }
        }

        private void resetButten_Click(object sender, EventArgs e)
        {
            feetbox.Visible = true;
            kiloTextBox.Visible = true;
            feetLabel.Text = "Feet";
            kiloLable.Text = "Kilograms";
            kiloTextBox.Text = "";
            feetbox.Text = "";
            inchebox.Visible = false;
            poundTextBox.Visible = false;
            bmiTextBox.Text = "Result";
        }

        private void bmiTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}