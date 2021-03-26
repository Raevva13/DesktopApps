using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class KalkulackaForm : Form
    {
        public KalkulackaForm()
        {
            InitializeComponent();
            operationComboBox1.SelectedIndex = 0;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            // definování proměnných
            string operation = operationComboBox1.SelectedItem.ToString();
            double number1 = Convert.ToDouble(number1NumericUpDown.Value);
            double number2 = Convert.ToDouble(number2NumericUpDown.Value);
            double result = 0;

            // vypocet
            switch(operation)
            {
                case "+":
                    result = number1 + number2;
                    break;

                case "-":
                    result = number1 - number2;
                    break;

                case "*":
                    result = number1 * number2;
                    break;

                case "/":
                    if (number2 != 0)
                    { result = number1 / number2; }
                    else { MessageBox.Show("Nulou nelze delit"); }
                    break;
            }
            resultLabel.Text = result.ToString();




        }
    }
}
