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
    public partial class KalkulackaForm : Form
    {
        public enum Operations
        {
            plus, minus, times, divided
        };

        Data data;

        public KalkulackaForm()
        {
            data = new Data();

            InitializeComponent();
            operationComboBox1.SelectedIndex = 0;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            // definování proměnných
            data.operation = operationComboBox1.SelectedItem.ToString();
            data.number1 = Convert.ToDouble(number1NumericUpDown.Value);
            data.number2 = Convert.ToDouble(number2NumericUpDown.Value);


            /*Singleton call*/

            ResultHolder result = new ResultHolder();


            switch (data.operation)
            {
                case "+":
                    result = OperationModul.Instance.Plus(data.number1, data.number2);
                    break;

                case "-":
                    result = OperationModul.Instance.Minus(data.number1, data.number2);
                    break;

                case "*":
                    result = OperationModul.Instance.Times(data.number1, data.number2);
                    break;

                case "/":
                    if (data.number2 != 0)
                     result = OperationModul.Instance.Divided(data.number1, data.number2); 
                    else { MessageBox.Show("Nulou nelze delit"); }
                    break;

                case "%":
                    if (data.number1 != 0)
                        result = OperationModul.Instance.Divided(data.number1, data.number2);
                    else MessageBox.Show("U modula nemuze byt 0");
                    break;

                case "sin°":
                    MessageBox.Show("zadejte jen leve cislo (predstavujici stupne)");
                    result = OperationModul.Instance.Sin(data.number1);
                    break;

                case "cos°":
                    MessageBox.Show("zadejte jen leve cislo (predstavujici stupne)");
                    result = OperationModul.Instance.Cos(data.number1);
                    break;

                case "tan°":
                    MessageBox.Show("zadejte jen leve cislo (predstavujici stupne)");
                    result = OperationModul.Instance.Tan(data.number1);
                    break;

                case "cotan°":
                    MessageBox.Show("pro zadani goniometricky funkci postaci zadani leveho cisla)");
                    result = OperationModul.Instance.Cotan(data.number1);
                    break;

                case "x^2":
                    MessageBox.Show("pro mocninu zadejte pouze leve cislo");
                    result = OperationModul.Instance.SquereRoot(data.number1);
                    break;

                case "x^3":
                    MessageBox.Show("pro mocninu zadejte pouze leve cislo");
                    result = OperationModul.Instance.Cube(data.number1);
                    break;

                case "x^y":
                    MessageBox.Show("leve cislo predstavuje x\nprave cislo y");
                    result = OperationModul.Instance.Power(data.number1, data.number2);
                    break;


            }
            //resultLabel.Text = result.ResultString;

            textBoxResult.Text = result.Result.ToString();
            textBoxCalculation.Text = result.ResultString;
            resultLabel.Text = result.Result.ToString();
            labelCalcul.Text = result.ResultString;




        }
    }
}
