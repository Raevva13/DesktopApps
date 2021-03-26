
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.number1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.operationComboBox1 = new System.Windows.Forms.ComboBox();
            this.number2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.number1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "=";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(324, 85);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(16, 17);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(49, 121);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // number1NumericUpDown
            // 
            this.number1NumericUpDown.DecimalPlaces = 2;
            this.number1NumericUpDown.Location = new System.Drawing.Point(49, 80);
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
            this.operationComboBox1.FormattingEnabled = true;
            this.operationComboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operationComboBox1.Location = new System.Drawing.Point(140, 81);
            this.operationComboBox1.Name = "operationComboBox1";
            this.operationComboBox1.Size = new System.Drawing.Size(59, 21);
            this.operationComboBox1.TabIndex = 4;
            // 
            // number2NumericUpDown
            // 
            this.number2NumericUpDown.DecimalPlaces = 2;
            this.number2NumericUpDown.Location = new System.Drawing.Point(220, 83);
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
            // KalkulackaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 327);
            this.Controls.Add(this.number2NumericUpDown);
            this.Controls.Add(this.operationComboBox1);
            this.Controls.Add(this.number1NumericUpDown);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.NumericUpDown number1NumericUpDown;
        private System.Windows.Forms.ComboBox operationComboBox1;
        private System.Windows.Forms.NumericUpDown number2NumericUpDown;
    }
}

