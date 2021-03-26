using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kalkulacka.DataHolders;


namespace Kalkulacka
{
    public partial class KalkulackaForm 
        : Form
    {
        public enum Operations
        {
            plus, minus, times, divided, modulo, sin, cos, tan, cotan, squereRoot, cubes, power
        };

        Variables variab;

        public KalkulackaForm()
        {
            variab = new Variables();

            InitializeComponent();
            operationComboBox1.SelectedIndex = 0;
        }


        //after click to the calculateButton
        private void calculateButton_Click(object sender, EventArgs e)
        {

            // properties 
            variab.operation = operationComboBox1.SelectedItem.ToString();
            variab.number1 = Convert.ToDouble(number1NumericUpDown.Value);
            variab.number2 = Convert.ToDouble(number2NumericUpDown.Value);


            /*Singleton call*/

            ResultHolder result = new ResultHolder();

            // choice from operations
            switch (variab.operation)
            {
                case "+":
                    result = OperationModul.Instance.Plus(variab.number1, variab.number2);
                    break;

                case "-":
                    result = OperationModul.Instance.Minus(variab.number1, variab.number2);
                    break;

                case "*":
                    result = OperationModul.Instance.Times(variab.number1, variab.number2);
                    break;

                case "/":
                    if (variab.number2 != 0)
                     result = OperationModul.Instance.Divided(variab.number1, variab.number2); 
                    else { MessageBox.Show("Nulou nelze delit"); }
                    break;

                case "%":
                    if (variab.number1 != 0)
                        result = OperationModul.Instance.Divided(variab.number1, variab.number2);
                    else MessageBox.Show("U modula nemuze byt 0");
                    break;

                case "sin°":
                    MessageBox.Show("zadejte jen leve cislo (predstavujici stupne)");
                    result = OperationModul.Instance.Sin(variab.number1);
                    break;

                case "cos°":
                    MessageBox.Show("zadejte jen leve cislo (predstavujici stupne)");
                    result = OperationModul.Instance.Cos(variab.number1);
                    break;

                case "tan°":
                    MessageBox.Show("zadejte jen leve cislo (predstavujici stupne)");
                    result = OperationModul.Instance.Tan(variab.number1);
                    break;

                case "cotan°":
                    MessageBox.Show("pro zadani goniometricky funkci postaci zadani leveho cisla)");
                    result = OperationModul.Instance.Cotan(variab.number1);
                    break;

                case "x^2":
                    MessageBox.Show("pro mocninu zadejte pouze leve cislo");
                    result = OperationModul.Instance.SquereRoot(variab.number1);
                    break;

                case "x^3":
                    MessageBox.Show("pro mocninu zadejte pouze leve cislo");
                    result = OperationModul.Instance.Cube(variab.number1);
                    break;

                case "x^y":
                    MessageBox.Show("leve cislo predstavuje x\nprave cislo y");
                    result = OperationModul.Instance.Power(variab.number1, variab.number2);
                    break;


            }

            // display of result and calculation
            textBoxResult.Text = result.Result.ToString();
            textBoxCalculation.Text = result.ResultString;

            //resultLabel.Text = result.Result.ToString();
            //labelCalcul.Text = result.ResultString;





        }
    }
}
