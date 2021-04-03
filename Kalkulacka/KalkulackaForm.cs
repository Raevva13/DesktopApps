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

        public KalkulackaForm()
        {
            InitializeComponent();
            //operationComboBox1.DataSource = Enum.GetValues(typeof(Operations));
            operationComboBox1.SelectedIndex = 0; // starting value "+"
        }


        /// <summary>
        /// After click to the calculateButton.
        /// </summary>
        /// <param name="sender">Object sender.</param>
        /// <param name="e">Event args.</param>        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            labelWarning.Text = string.Empty; //information label



            // variables 
            selectedOperation = (Operations)operationComboBox1.SelectedIndex; // select operation 
            varA = Convert.ToDouble(number1NumericUpDown.Value); //convert to the number 
            varB = Convert.ToDouble(number2NumericUpDown.Value); // convert to the number



            ResultHolder result = new ResultHolder();

            // choice from operations
            switch (selectedOperation)
            {
                case Operations.plus: 
                    result = OperationModul.Instance.Plus(varA, varB); //Singleton call
                    break;

                case Operations.minus:
                    result = OperationModul.Instance.Minus(varA, varB); //Singleton call
                    break;

                case Operations.times:
                    result = OperationModul.Instance.Times(varA, varB); //Singleton call
                    break;

                case Operations.divided:
                    if (varB != 0) result = OperationModul.Instance.Divided(varA, varB); //Singleton call
                    else MessageBox.Show("Nulou nelze delit"); // information warning
                    break;

                case Operations.modulo:
                    if (varA != 0) result = OperationModul.Instance.Modulo(varA, varB); //Singleton call
                    else MessageBox.Show("U modula nemuze byt 0"); // information warning
                    break;

                case Operations.sin:
                    labelWarning.Text = "zadejte jen leve cislo (predstavujici stupne)"; // information warning
                    result = OperationModul.Instance.Sin(varA); //Singleton call
                    break;

                case Operations.cos:
                    labelWarning.Text = "zadejte jen leve cislo (predstavujici stupne)"; // information warning
                    result = OperationModul.Instance.Cos(varA); //Singleton call
                    break;

                case Operations.tan:
                    labelWarning.Text = "zadejte jen leve cislo (predstavujici stupne)"; // information warning
                    result = OperationModul.Instance.Tan(varA); //Singleton call
                    break;

                case Operations.cotan:
                    labelWarning.Text = "zadejte jen leve cislo (predstavujici stupne)"; // information warning
                    result = OperationModul.Instance.Cotan(varA); //Singleton call
                    break;

                case Operations.squereRoot:
                    labelWarning.Text = "pro mocninu zadejte pouze leve cislo"; // information warning
                    result = OperationModul.Instance.SquereRoot(varA); //Singleton call
                    break;

                case Operations.cubes:
                    labelWarning.Text = "pro mocninu zadejte pouze leve cislo"; // information warning
                    result = OperationModul.Instance.Cube(varA); //Singleton call
                    break;

                case Operations.power:
                    labelWarning.Text = "leve cislo predstavuje x\nprave cislo y"; // information warning
                    result = OperationModul.Instance.Power(varA, varB); //Singleton call
                    break;

                default: 
                    MessageBox.Show("Nenadefinovana operace!"); // information warning
                    break;

            }

            // display of result and calculation to textBoxes
            textBoxResult.Text = result.Result.ToString();
            textBoxCalculation.Text = result.ResultString;


        }
    }
}
