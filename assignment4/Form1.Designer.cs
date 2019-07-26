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
            this.tableLayoutPanel1.Controls.Add(this.metricButten, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.imperialButten, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(57, 74);
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
            // BmiCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 441);
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
    }
}

