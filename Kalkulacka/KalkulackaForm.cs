using System;
using System.Windows.Forms;
using Kalkulacka.DataHolders;


namespace Kalkulacka
{
    public partial class KalkulackaForm 
        : Form
    {
        /// <summary>
        /// Hold "left" variable.
        /// </summary>
        private double varA;

        /// <summary>
        /// Hold "right" variable.
        /// </summary>
        
        private double varB;

        /// <summary>
        /// Holds selected operation.
        /// </summary>
        private Operations selectedOperation;

        /// <summary>
        /// Enum containing all possilbe opetations.
        /// </summary>
        public enum Operations
        {
            plus, minus, times, divided, modulo, sin, cos, tan, cotan, squereRoot, cubes, power
        };

        //Variables variab;

        public KalkulackaForm()
        {
            InitializeComponent();
            operationComboBox1.SelectedIndex = 0;
        }


        /// <summary>
        /// After click to the calculateButton.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event args.</param>        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            labelWarning.Text = string.Empty;



            // properties 
            selectedOperation = (Operations)operationComboBox1.SelectedIndex;
            varA = Convert.ToDouble(number1NumericUpDown.Value);
            varB = Convert.ToDouble(number2NumericUpDown.Value);



            ResultHolder result = new ResultHolder();

            // choice from operations
            switch (selectedOperation)
            {
                case Operations.plus:
                    result = OperationModul.Instance.Plus(varA, varB);
                    break;

                case Operations.minus:
                    result = OperationModul.Instance.Minus(varA, varB);
                    break;

                case Operations.times:
                    result = OperationModul.Instance.Times(varA, varB);
                    break;

                case Operations.divided:
                    if (varB != 0) result = OperationModul.Instance.Divided(varA, varB); 
                    else MessageBox.Show("Nulou nelze delit"); 
                    break;

                case Operations.modulo:
                    if (varA != 0) result = OperationModul.Instance.Modulo(varA, varB);
                    else MessageBox.Show("U modula nemuze byt 0");
                    break;

                case Operations.sin:
                    labelWarning.Text = "zadejte jen leve cislo (predstavujici stupne)";
                    result = OperationModul.Instance.Sin(varA);
                    break;

                case Operations.cos:
                    labelWarning.Text = "zadejte jen leve cislo (predstavujici stupne)";
                    result = OperationModul.Instance.Cos(varA);
                    break;

                case Operations.tan:
                    labelWarning.Text = "zadejte jen leve cislo (predstavujici stupne)";
                    result = OperationModul.Instance.Tan(varA);
                    break;

                case Operations.cotan:
                    labelWarning.Text = "zadejte jen leve cislo (predstavujici stupne)";
                    result = OperationModul.Instance.Cotan(varA);
                    break;

                case Operations.squereRoot:
                    labelWarning.Text = "pro mocninu zadejte pouze leve cislo";
                    result = OperationModul.Instance.SquereRoot(varA);
                    break;

                case Operations.cubes:
                    labelWarning.Text = "pro mocninu zadejte pouze leve cislo";
                    result = OperationModul.Instance.Cube(varA);
                    break;

                case Operations.power:
                    labelWarning.Text = "leve cislo predstavuje x\nprave cislo y";
                    result = OperationModul.Instance.Power(varA, varB);
                    break;

                default:
                    MessageBox.Show("Nenadefinovana operace!");
                    break;

            }

            // display of result and calculation
            textBoxResult.Text = result.Result.ToString();
            textBoxCalculation.Text = result.ResultString;


        }
    }
}
