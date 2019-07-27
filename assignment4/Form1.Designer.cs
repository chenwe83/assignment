namespace assignment4
{
    partial class BmiCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculatorLable = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imperialButten = new System.Windows.Forms.RadioButton();
            this.metricButten = new System.Windows.Forms.RadioButton();
            this.heightlable = new System.Windows.Forms.Label();
            this.feetbox = new System.Windows.Forms.TextBox();
            this.inchebox = new System.Windows.Forms.TextBox();
            this.feetLabel = new System.Windows.Forms.Label();
            this.incheLabel = new System.Windows.Forms.Label();
            this.WeightLable = new System.Windows.Forms.Label();
            this.poundTextBox = new System.Windows.Forms.TextBox();
            this.kiloTextBox = new System.Windows.Forms.TextBox();
            this.poundLable = new System.Windows.Forms.Label();
            this.kiloLable = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorLable
            // 
            this.CalculatorLable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CalculatorLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CalculatorLable.Location = new System.Drawing.Point(57, 12);
            this.CalculatorLable.Name = "CalculatorLable";
            this.CalculatorLable.Size = new System.Drawing.Size(193, 38);
            this.CalculatorLable.TabIndex = 0;
            this.CalculatorLable.Text = "BMI Calculator";
            this.CalculatorLable.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.imperialButten, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metricButten, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(57, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 76);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // imperialButten
            // 
            this.imperialButten.AutoSize = true;
            this.imperialButten.Checked = true;
            this.imperialButten.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.imperialButten.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.imperialButten.Location = new System.Drawing.Point(3, 3);
            this.imperialButten.Name = "imperialButten";
            this.imperialButten.Size = new System.Drawing.Size(128, 32);
            this.imperialButten.TabIndex = 0;
            this.imperialButten.TabStop = true;
            this.imperialButten.Text = "Imperial";
            this.imperialButten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imperialButten.UseVisualStyleBackColor = true;
            // 
            // metricButten
            // 
            this.metricButten.AutoSize = true;
            this.metricButten.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.metricButten.Location = new System.Drawing.Point(3, 41);
            this.metricButten.Name = "metricButten";
            this.metricButten.Size = new System.Drawing.Size(106, 32);
            this.metricButten.TabIndex = 1;
            this.metricButten.Text = "Metric";
            this.metricButten.UseVisualStyleBackColor = true;
            // 
            // heightlable
            // 
            this.heightlable.AutoSize = true;
            this.heightlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.heightlable.Location = new System.Drawing.Point(12, 141);
            this.heightlable.Name = "heightlable";
            this.heightlable.Size = new System.Drawing.Size(106, 25);
            this.heightlable.TabIndex = 2;
            this.heightlable.Text = "My Height:";
            // 
            // feetbox
            // 
            this.feetbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.feetbox.Location = new System.Drawing.Point(124, 138);
            this.feetbox.Name = "feetbox";
            this.feetbox.Size = new System.Drawing.Size(64, 30);
            this.feetbox.TabIndex = 3;
            this.feetbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // inchebox
            // 
            this.inchebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inchebox.Location = new System.Drawing.Point(124, 175);
            this.inchebox.Name = "inchebox";
            this.inchebox.Size = new System.Drawing.Size(64, 30);
            this.inchebox.TabIndex = 4;
            // 
            // feetLabel
            // 
            this.feetLabel.AutoSize = true;
            this.feetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.feetLabel.Location = new System.Drawing.Point(194, 141);
            this.feetLabel.Name = "feetLabel";
            this.feetLabel.Size = new System.Drawing.Size(51, 25);
            this.feetLabel.TabIndex = 5;
            this.feetLabel.Text = "Feet";
            // 
            // incheLabel
            // 
            this.incheLabel.AutoSize = true;
            this.incheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.incheLabel.Location = new System.Drawing.Point(194, 175);
            this.incheLabel.Name = "incheLabel";
            this.incheLabel.Size = new System.Drawing.Size(60, 25);
            this.incheLabel.TabIndex = 6;
            this.incheLabel.Text = "Inche";
            this.incheLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // WeightLable
            // 
            this.WeightLable.AutoSize = true;
            this.WeightLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WeightLable.Location = new System.Drawing.Point(12, 229);
            this.WeightLable.Name = "WeightLable";
            this.WeightLable.Size = new System.Drawing.Size(112, 25);
            this.WeightLable.TabIndex = 2;
            this.WeightLable.Text = "My Weight:";
            // 
            // poundTextBox
            // 
            this.poundTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.poundTextBox.Location = new System.Drawing.Point(124, 226);
            this.poundTextBox.Name = "poundTextBox";
            this.poundTextBox.Size = new System.Drawing.Size(64, 30);
            this.poundTextBox.TabIndex = 3;
            this.poundTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // kiloTextBox
            // 
            this.kiloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.kiloTextBox.Location = new System.Drawing.Point(124, 263);
            this.kiloTextBox.Name = "kiloTextBox";
            this.kiloTextBox.Size = new System.Drawing.Size(64, 30);
            this.kiloTextBox.TabIndex = 4;
            // 
            // poundLable
            // 
            this.poundLable.AutoSize = true;
            this.poundLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.poundLable.Location = new System.Drawing.Point(194, 229);
            this.poundLable.Name = "poundLable";
            this.poundLable.Size = new System.Drawing.Size(79, 25);
            this.poundLable.TabIndex = 5;
            this.poundLable.Text = "Pounds";
            // 
            // kiloLable
            // 
            this.kiloLable.AutoSize = true;
            this.kiloLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.kiloLable.Location = new System.Drawing.Point(194, 263);
            this.kiloLable.Name = "kiloLable";
            this.kiloLable.Size = new System.Drawing.Size(99, 25);
            this.kiloLable.TabIndex = 6;
            this.kiloLable.Text = "Kilograms";
            this.kiloLable.Click += new System.EventHandler(this.label2_Click);
            // 
            // BmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.kiloLable);
            this.Controls.Add(this.incheLabel);
            this.Controls.Add(this.poundLable);
            this.Controls.Add(this.feetLabel);
            this.Controls.Add(this.kiloTextBox);
            this.Controls.Add(this.inchebox);
            this.Controls.Add(this.poundTextBox);
            this.Controls.Add(this.feetbox);
            this.Controls.Add(this.WeightLable);
            this.Controls.Add(this.heightlable);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CalculatorLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "BmiCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalculatorLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton metricButten;
        private System.Windows.Forms.RadioButton imperialButten;
        private System.Windows.Forms.Label heightlable;
        private System.Windows.Forms.TextBox feetbox;
        private System.Windows.Forms.TextBox inchebox;
        private System.Windows.Forms.Label feetLabel;
        private System.Windows.Forms.Label incheLabel;
        private System.Windows.Forms.Label WeightLable;
        private System.Windows.Forms.TextBox poundTextBox;
        private System.Windows.Forms.TextBox kiloTextBox;
        private System.Windows.Forms.Label poundLable;
        private System.Windows.Forms.Label kiloLable;
    }
}

