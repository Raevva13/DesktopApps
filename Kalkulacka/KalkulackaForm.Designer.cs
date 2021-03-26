
namespace Kalkulacka
{
    partial class KalkulackaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.number1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.operationComboBox1 = new System.Windows.Forms.ComboBox();
            this.number2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxCalculation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.number1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "=";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(286, 16);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // number1NumericUpDown
            // 
            this.number1NumericUpDown.Location = new System.Drawing.Point(12, 49);
            this.number1NumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.number1NumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.number1NumericUpDown.Name = "number1NumericUpDown";
            this.number1NumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.number1NumericUpDown.TabIndex = 3;
            // 
            // operationComboBox1
            // 
            this.operationComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationComboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%",
            "sin°",
            "cos°",
            "tan°",
            "cotan°",
            "x^2",
            "x^3",
            "x^y"});
            this.operationComboBox1.Location = new System.Drawing.Point(103, 49);
            this.operationComboBox1.Name = "operationComboBox1";
            this.operationComboBox1.Size = new System.Drawing.Size(63, 21);
            this.operationComboBox1.TabIndex = 4;
            this.operationComboBox1.SelectedValueChanged += new System.EventHandler(this.calculateButton_Click);
            // 
            // number2NumericUpDown
            // 
            this.number2NumericUpDown.Location = new System.Drawing.Point(182, 50);
            this.number2NumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.number2NumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.number2NumericUpDown.Name = "number2NumericUpDown";
            this.number2NumericUpDown.Size = new System.Drawing.Size(79, 20);
            this.number2NumericUpDown.TabIndex = 5;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(286, 51);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 7;
            this.textBoxResult.Text = "vysledek";
            // 
            // textBoxCalculation
            // 
            this.textBoxCalculation.Location = new System.Drawing.Point(11, 19);
            this.textBoxCalculation.Name = "textBoxCalculation";
            this.textBoxCalculation.ReadOnly = true;
            this.textBoxCalculation.Size = new System.Drawing.Size(250, 20);
            this.textBoxCalculation.TabIndex = 8;
            this.textBoxCalculation.Text = "vypocet";
            // 
            // KalkulackaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 111);
            this.Controls.Add(this.textBoxCalculation);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.number2NumericUpDown);
            this.Controls.Add(this.operationComboBox1);
            this.Controls.Add(this.number1NumericUpDown);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(430, 150);
            this.MinimumSize = new System.Drawing.Size(430, 150);
            this.Name = "KalkulackaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulacka";
            ((System.ComponentModel.ISupportInitialize)(this.number1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.NumericUpDown number1NumericUpDown;
        private System.Windows.Forms.ComboBox operationComboBox1;
        private System.Windows.Forms.NumericUpDown number2NumericUpDown;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxCalculation;
    }
}

