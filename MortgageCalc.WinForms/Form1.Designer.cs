namespace MortgageCalc.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.MonthlyPaymentLabel = new System.Windows.Forms.Label();
            this.MonthMortPaymentBox = new System.Windows.Forms.TextBox();
            this.MortgagePeriodLabel = new System.Windows.Forms.Label();
            this.InterestRateLabel = new System.Windows.Forms.Label();
            this.MortgageAmountLabel = new System.Windows.Forms.Label();
            this.MortPeriodBox = new System.Windows.Forms.TextBox();
            this.InterestRateAmountBox = new System.Windows.Forms.TextBox();
            this.MortAmountBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(249, 92);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 23);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(474, 92);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(163, 23);
            this.textBox5.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 769);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CalculateButton);
            this.tabPage1.Controls.Add(this.MonthlyPaymentLabel);
            this.tabPage1.Controls.Add(this.MonthMortPaymentBox);
            this.tabPage1.Controls.Add(this.MortgagePeriodLabel);
            this.tabPage1.Controls.Add(this.InterestRateLabel);
            this.tabPage1.Controls.Add(this.MortgageAmountLabel);
            this.tabPage1.Controls.Add(this.MortPeriodBox);
            this.tabPage1.Controls.Add(this.InterestRateAmountBox);
            this.tabPage1.Controls.Add(this.MortAmountBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 741);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(10, 152);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // MonthlyPaymentLabel
            // 
            this.MonthlyPaymentLabel.AutoSize = true;
            this.MonthlyPaymentLabel.Location = new System.Drawing.Point(10, 331);
            this.MonthlyPaymentLabel.Name = "MonthlyPaymentLabel";
            this.MonthlyPaymentLabel.Size = new System.Drawing.Size(232, 15);
            this.MonthlyPaymentLabel.TabIndex = 4;
            this.MonthlyPaymentLabel.Text = "Monthly Mortgage Payment (before taxes)";
            this.MonthlyPaymentLabel.Click += new System.EventHandler(this.MonthlyPaymentLabel_Click);
            // 
            // MonthMortPaymentBox
            // 
            this.MonthMortPaymentBox.Location = new System.Drawing.Point(10, 368);
            this.MonthMortPaymentBox.Name = "MonthMortPaymentBox";
            this.MonthMortPaymentBox.ReadOnly = true;
            this.MonthMortPaymentBox.Size = new System.Drawing.Size(234, 23);
            this.MonthMortPaymentBox.TabIndex = 0;
            this.MonthMortPaymentBox.TextChanged += new System.EventHandler(this.MonthMortPaymentBox_TextChanged);
            // 
            // MortgagePeriodLabel
            // 
            this.MortgagePeriodLabel.AutoSize = true;
            this.MortgagePeriodLabel.Location = new System.Drawing.Point(623, 52);
            this.MortgagePeriodLabel.Name = "MortgagePeriodLabel";
            this.MortgagePeriodLabel.Size = new System.Drawing.Size(147, 15);
            this.MortgagePeriodLabel.TabIndex = 3;
            this.MortgagePeriodLabel.Text = "Mortgage Period (in years)";
            // 
            // InterestRateLabel
            // 
            this.InterestRateLabel.AutoSize = true;
            this.InterestRateLabel.Location = new System.Drawing.Point(322, 52);
            this.InterestRateLabel.Name = "InterestRateLabel";
            this.InterestRateLabel.Size = new System.Drawing.Size(159, 15);
            this.InterestRateLabel.TabIndex = 2;
            this.InterestRateLabel.Text = "Interest Rate (ex. 0.03 for 3%)";
            // 
            // MortgageAmountLabel
            // 
            this.MortgageAmountLabel.AutoSize = true;
            this.MortgageAmountLabel.Location = new System.Drawing.Point(10, 52);
            this.MortgageAmountLabel.Name = "MortgageAmountLabel";
            this.MortgageAmountLabel.Size = new System.Drawing.Size(136, 15);
            this.MortgageAmountLabel.TabIndex = 1;
            this.MortgageAmountLabel.Text = "Mortgage Amount (in $)";
            // 
            // MortPeriodBox
            // 
            this.MortPeriodBox.Location = new System.Drawing.Point(623, 88);
            this.MortPeriodBox.Name = "MortPeriodBox";
            this.MortPeriodBox.Size = new System.Drawing.Size(234, 23);
            this.MortPeriodBox.TabIndex = 0;
            // 
            // InterestRateAmountBox
            // 
            this.InterestRateAmountBox.Location = new System.Drawing.Point(322, 88);
            this.InterestRateAmountBox.Name = "InterestRateAmountBox";
            this.InterestRateAmountBox.Size = new System.Drawing.Size(234, 23);
            this.InterestRateAmountBox.TabIndex = 0;
            // 
            // MortAmountBox
            // 
            this.MortAmountBox.Location = new System.Drawing.Point(10, 88);
            this.MortAmountBox.Name = "MortAmountBox";
            this.MortAmountBox.Size = new System.Drawing.Size(234, 23);
            this.MortAmountBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 741);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 771);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label MortgagePeriodLabel;
        private System.Windows.Forms.Label InterestRateLabel;
        private System.Windows.Forms.Label MortgageAmountLabel;
        private System.Windows.Forms.TextBox MortPeriodBox;
        private System.Windows.Forms.TextBox InterestRateAmountBox;
        private System.Windows.Forms.TextBox MortAmountBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label MonthlyPaymentLabel;
        private System.Windows.Forms.TextBox MonthMortPaymentBox;
        private System.Windows.Forms.Button CalculateButton;
    }
}

