using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialProductsWinforms.DataHolders;

using FinancialProductsWinforms.ProductsHolder;

namespace FinancialProductsWinforms
{

    public partial class FinancialProducts
        : Form
    {
        private double varAmountOfInvestment;
        private double varSavingTime;
        private double varInterestRate;
        private double varNumberOfDeposits;
        private double varInflation;
        private Products selectedProduct;



        public enum Products
        {
            oneTimeInvestment, shortTermSavings, shortPreTermSavings, longTermSavings, combinateSavingsMonthly, combinateSavingsMonthlyWithInflation, combinateSavingsQuarterly, combinateSavingsQuarterlyWithInflation, loanRepayment
        };

        public FinancialProducts()
        {
            InitializeComponent();
            comboBoxProducts.DataSource = Enum.GetValues(typeof(Products));
            comboBoxProducts.SelectedIndex = 2;
            //comboBoxProducts.Items.Add();
            //comboBoxProducts.SelectedIndex = 0;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {

            labelInformation.Text = string.Empty;

            //variables
            selectedProduct = (Products)comboBoxProducts.SelectedIndex;
            varAmountOfInvestment = Convert.ToDouble(numericUpDownAmountOfInvestment.Value);
            varSavingTime = Convert.ToDouble(numericUpDownSavingTime.Value);
            varInterestRate = Convert.ToDouble(numericUpDownInterestRate.Value);
            varNumberOfDeposits = Convert.ToDouble(numericUpDownNumberOfDeposits.Value);
            varInflation = Convert.ToDouble(numericUpDownInflation.Value);


            OutcomeHolder result = new OutcomeHolder();

            // choice from products
            switch (selectedProduct)
            {
                case Products.oneTimeInvestment:
                    {
                        labelInformation.Text = "Zadejte:\nVýši vkladu\nDobu spoření v letech\nÚrokovou sazbu";
                        labelAmountOfInvestment.Visible = true;
                        numericUpDownAmountOfInvestment.Visible = true;
                        labelSavingTime.Visible = true;
                        numericUpDownSavingTime.Visible = true;
                        labelInterestRate.Visible = true;
                        numericUpDownInterestRate.Visible = true;

                        labelNumberOfDeposits.Visible = false;
                        numericUpDownNumberOfDeposits.Visible = false;
                        labelInflation.Visible = false;
                        numericUpDownInflation.Visible = true;

                        result = ProductionModul.Specimen.OneTimeInvestment(varAmountOfInvestment, varSavingTime, varInterestRate);
                    }
                    break;

                case Products.shortTermSavings:
                    {
                        labelInformation.Text = "Zadejte:\nVýši vkladu\nÚrokovou sazbu\nPočet vkladů během p.a.";
                        labelAmountOfInvestment.Visible = true;
                        numericUpDownAmountOfInvestment.Visible = true;
                        labelInterestRate.Visible = true;
                        numericUpDownInterestRate.Visible = true;
                        labelNumberOfDeposits.Visible = true;
                        numericUpDownNumberOfDeposits.Visible = true;

                        labelSavingTime.Visible = false;
                        numericUpDownSavingTime.Visible = false;
                        labelInflation.Visible = false;
                        numericUpDownInflation.Visible = false;

                        result = ProductionModul.Specimen.ShortTermSavings(varAmountOfInvestment, varInterestRate, varNumberOfDeposits);
                        break;
                    }

                case Products.shortPreTermSavings:
                    {
                        labelInformation.Text = "Zadejte:\nVýši naspořené částky\nÚrokovou sazbu\nPočet vkladů během p.a.";
                        labelAmountOfInvestment.Visible = true;
                        numericUpDownAmountOfInvestment.Visible = true;
                        labelInterestRate.Visible = true;
                        numericUpDownInterestRate.Visible = true;
                        labelNumberOfDeposits.Visible = true;
                        numericUpDownNumberOfDeposits.Visible = true;

                        labelSavingTime.Visible = false;
                        numericUpDownSavingTime.Visible = false;
                        labelInflation.Visible = false;
                        numericUpDownInflation.Visible = false;

                        result = ProductionModul.Specimen.ShortPreTermSavings(varAmountOfInvestment, varInterestRate, varNumberOfDeposits);
                    }
                    break;
                case Products.longTermSavings:
                    {
                        labelInformation.Text = "Zadejte:\nVýši vkladu\nDobu spoření v letech\nÚrokovou sazbu";
                        labelAmountOfInvestment.Visible = true;
                        numericUpDownAmountOfInvestment.Visible = true;
                        labelSavingTime.Visible = true;
                        numericUpDownSavingTime.Visible = true;
                        labelInterestRate.Visible = true;
                        numericUpDownInterestRate.Visible = true;

                        labelNumberOfDeposits.Visible = false;
                        numericUpDownNumberOfDeposits.Visible = false;
                        labelInflation.Visible = false;
                        numericUpDownInflation.Visible = false;

                        result = ProductionModul.Specimen.LongTermSavings(varAmountOfInvestment, varSavingTime, varInterestRate);

                    }
                    break;

                case Products.combinateSavingsMonthly:
                    {
                        labelInformation.Text = "Zadejte:\nVýši vkladu\nDobu spoření v letech\nÚrokovou sazbu";
                        labelAmountOfInvestment.Visible = true;
                        numericUpDownAmountOfInvestment.Visible = true;
                        labelSavingTime.Visible = true;
                        numericUpDownSavingTime.Visible = true;
                        labelInterestRate.Visible = true;
                        numericUpDownInterestRate.Visible = true;

                        labelNumberOfDeposits.Visible = false;
                        numericUpDownNumberOfDeposits.Visible = false;
                        labelInflation.Visible = false;
                        numericUpDownInflation.Visible = false;

                        result = ProductionModul.Specimen.CombinateSavingsMonthly(varAmountOfInvestment, varSavingTime, varInterestRate);

                    }
                    break;

                case Products.combinateSavingsMonthlyWithInflation:
                    {
                        labelInformation.Text = "Zadejte:\nVýši vkladu\nDobu spoření v letech\nÚrokovou sazbu\nVýši inflace";
                        labelAmountOfInvestment.Visible = true;
                        numericUpDownAmountOfInvestment.Visible = true;
                        labelSavingTime.Visible = true;
                        numericUpDownSavingTime.Visible = true;
                        labelInterestRate.Visible = true;
                        numericUpDownInterestRate.Visible = true;
                        labelInflation.Visible = true;
                        numericUpDownInflation.Visible = true;

                        labelNumberOfDeposits.Visible = false;
                        numericUpDownNumberOfDeposits.Visible = false;

                        result = ProductionModul.Specimen.CombinateSavingsMonthlyWithInflation(varAmountOfInvestment, varSavingTime, varInterestRate, varInflation);
                    }
                    break;



                case Products.combinateSavingsQuarterly:
                    {
                        labelInformation.Text = "Zadejte\nVýši vkladu\nDobu spoření v letech\nÚrokovou sazbu\nPočet vkladů";
                        labelAmountOfInvestment.Visible = true;
                        numericUpDownAmountOfInvestment.Visible = true;
                        labelSavingTime.Visible = true;
                        numericUpDownSavingTime.Visible = true;
                        labelInterestRate.Visible = true;
                        numericUpDownInterestRate.Visible = true;
                        labelNumberOfDeposits.Visible = true;
                        numericUpDownNumberOfDeposits.Visible = true;

                        labelInflation.Visible = false;
                        numericUpDownInflation.Visible = false;

                        result = ProductionModul.Specimen.CombinateSavingsQuarterly(varAmountOfInvestment, varSavingTime, varInterestRate, varNumberOfDeposits);
                    }
                    break;


                case Products.combinateSavingsQuarterlyWithInflation:
                    {
                        labelInformation.Text = "Zadejte:\nVýši vkladu\nDobu spoření v letech\nÚrokovou sazbu\nPočet vkladů během p.a.\nVýši inflace";
                        labelAmountOfInvestment.Visible = true;
                        numericUpDownAmountOfInvestment.Visible = true;
                        labelSavingTime.Visible = true;
                        numericUpDownSavingTime.Visible = true;
                        labelInterestRate.Visible = true;
                        numericUpDownInterestRate.Visible = true;
                        labelNumberOfDeposits.Visible = true;
                        numericUpDownNumberOfDeposits.Visible = true;
                        labelInflation.Visible = true;
                        numericUpDownInflation.Visible = true;


                        result = ProductionModul.Specimen.CombinateSavingsQuarterlyWithInflation(varAmountOfInvestment, varSavingTime, varInterestRate, varNumberOfDeposits, varInflation);
                    }
                    break;

                case Products.loanRepayment:
                    {
                        labelInformation.Text = "Zadejte:\nVýši úvěru\nDobu spoření v letech\nÚrokovou sazbu";
                        labelAmountOfInvestment.Visible = true;
                        numericUpDownAmountOfInvestment.Visible = true;
                        labelSavingTime.Visible = true;
                        numericUpDownSavingTime.Visible = true;
                        labelInterestRate.Visible = true;
                        numericUpDownSavingTime.Visible = true;

                        labelNumberOfDeposits.Visible = false;
                        numericUpDownNumberOfDeposits.Visible = false;
                        labelInflation.Visible = false;
                        numericUpDownInflation.Visible = false;

                        result = ProductionModul.Specimen.LoanRepayment(varAmountOfInvestment, varSavingTime, varInterestRate);
                    }
                    break;

                default:
                    MessageBox.Show("Tato možnost neexistuje");
                    break;
            }

            textBoxResult.Text = result.Outcome.ToString();
            labelOutcomeString.Text = result.OutcomeString;
        }

        private void buttonResult_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void buttonOneTime_Click(object sender, EventArgs e)
        {
            OutcomeHolder result = new OutcomeHolder();

            result.AmountOfInvestment = Convert.ToDouble(numericUpDownAmountOneTime.Value);
            result.SavingTime = Convert.ToDouble(numericUpDownSavingTimeOneTime.Value);
            result.InterestRate = Convert.ToDouble(numericUpDownInterestRateOneTime.Value);

            result = ProductionModul.Specimen.OneTimeInvestment(result.AmountOfInvestment, result.SavingTime, result.InterestRate);
            textBoxOneTime.Text = result.Outcome.ToString();
            labelDataOneTime.Text = result.OutcomeString;

        }

        private void buttonShortTerm_Click(object sender, EventArgs e)
        {
            Variables variables = new Variables();
            OutcomeHolder result = new OutcomeHolder();

            result.AmountOfInvestment = Convert.ToDouble(numericUpDownAmountShorTermSavings.Value);
            result.InterestRate = Convert.ToDouble(numericUpDownInterestRateShortTermSavings.Value);
            result.NumberOfDeposits = Convert.ToDouble(numericUpDownNumberOfDepositsShortTermSavings.Value);

            result = ProductionModul.Specimen.ShortTermSavings(result.AmountOfInvestment, result.InterestRate, result.NumberOfDeposits);
            textBoxShortTerm.Text = result.Outcome.ToString();
            labelDataShortTerm.Text = result.OutcomeString;

        }

        private void buttonShortPreTerm_Click(object sender, EventArgs e)
        {
            Variables variables = new Variables();
            OutcomeHolder result = new OutcomeHolder();

            result.AmountOfInvestment = Convert.ToDouble(numericUpDownAmountShortPreTerm.Value);
            result.InterestRate = Convert.ToDouble(numericUpDownInterestRateShortPreTerm.Value);
            result.NumberOfDeposits = Convert.ToDouble(numericUpDownNumberOfDepositsShortPreTerm.Value);

            result = ProductionModul.Specimen.ShortPreTermSavings(result.AmountOfInvestment, result.InterestRate, result.NumberOfDeposits);
            textBoxShortPreTerm.Text = result.Outcome.ToString();
            labelDataPreTerm.Text = result.OutcomeString;


        }

        private void buttonLongTerm_Click(object sender, EventArgs e)
        {
            Variables variables = new Variables();
            OutcomeHolder result = new OutcomeHolder();

            result.AmountOfInvestment = Convert.ToDouble(numericUpDownAmountLongTerm.Value);
            result.SavingTime = Convert.ToDouble(numericUpDownSavingTimeLongTerm.Value);
            result.InterestRate = Convert.ToDouble(numericUpDownInterestRateLongTerm.Value);

            result = ProductionModul.Specimen.LongTermSavings(result.AmountOfInvestment, result.SavingTime, result.InterestRate);
            textBoxLongTerm.Text = result.Outcome.ToString();
            labelDataLongTerm.Text = result.OutcomeString;

        }

        private void buttonCombinateSavingMonthly_Click(object sender, EventArgs e)
        {
            Variables variables = new Variables();
            OutcomeHolder result = new OutcomeHolder();

            result.AmountOfInvestment = Convert.ToDouble(numericUpDownAmountCombinateMonthly.Value);
            result.SavingTime = Convert.ToDouble(numericUpDownSavingTimeCombinateMonthly.Value);
            result.InterestRate = Convert.ToDouble(numericUpDownInterestRateCombinateMonthly.Value);

            result = ProductionModul.Specimen.CombinateSavingsMonthly(result.InterestRate, result.SavingTime, result.InterestRate);
            textBoxCombinateSavingMonthly.Text = result.Outcome.ToString();
            labelDataCombinateMonthly.Text = result.OutcomeString;

        }

        private void buttonCombinateSavingMonthlyWithInflation_Click(object sender, EventArgs e)
        {
            Variables variables = new Variables();
            OutcomeHolder result = new OutcomeHolder();

            result.AmountOfInvestment = Convert.ToDouble(numericUpDownAmountCombinateMonthlyInflation.Value);
            result.SavingTime = Convert.ToDouble(numericUpDownSavingTimeCombinateMonthInflation.Value);
            result.InterestRate = Convert.ToDouble(numericUpDownInterestRateCombinateMonthlyInflation.Value);
            result.Inflation = Convert.ToDouble(numericUpDownInflationCombinateMonthlyInflation.Value);

            result = ProductionModul.Specimen.CombinateSavingsMonthlyWithInflation(result.AmountOfInvestment, result.SavingTime, result.InterestRate, result.Inflation);
            textBoxCombinateSavingsmonthlyWithInflation.Text = result.Outcome.ToString();
            labelDataCombinateMonthlyInflation.Text = result.OutcomeString;

        }

        private void buttonCombinateSavingsQuarterly_Click(object sender, EventArgs e)
        {
            Variables variables = new Variables();
            OutcomeHolder result = new OutcomeHolder();

            result.AmountOfInvestment = Convert.ToDouble(numericUpDownAmountCombinateQuarterly.Value);
            result.SavingTime = Convert.ToDouble(numericUpDownSavingTimeCombinateQuarterly.Value);
            result.InterestRate = Convert.ToDouble(numericUpDownInterestRateCombinateQuarterly.Value);
            result.NumberOfDeposits = Convert.ToDouble(numericUpDownNumberOfDepositsCombinateQuarterly.Value);

            result = ProductionModul.Specimen.CombinateSavingsQuarterly(result.AmountOfInvestment, result.SavingTime, result.InterestRate, result.NumberOfDeposits);
            textBoxCombinateSavingsQuarterly.Text = result.Outcome.ToString();
            labelDataCombinateQuarterly.Text = result.OutcomeString;

        }

        private void buttonCombinateQuarterlyWithInflation_Click(object sender, EventArgs e)
        {
            OutcomeHolder result = new OutcomeHolder();

            result.AmountOfInvestment = Convert.ToDouble(numericUpDownAmountCombinateQuarterlyInflation.Value);
            result.SavingTime = Convert.ToDouble(numericUpDownSavingTimeCombinateQuarterlyInflation.Value);
            result.InterestRate = Convert.ToDouble(numericUpDownInterestRateCombinateQuarterlyInflation.Value);
            result.NumberOfDeposits = Convert.ToDouble(numericUpDownNumberOfDepositsCombinateQuarterlyInflation.Value);
            result.Inflation = Convert.ToDouble(numericUpDownInflationCombinateQuarterlyInflation.Value);

            result = ProductionModul.Specimen.CombinateSavingsQuarterlyWithInflation(result.AmountOfInvestment, result.SavingTime, result.InterestRate, result.NumberOfDeposits, result.Inflation);
            textBoxCombinateQuarterlyWithInflation.Text = result.Outcome.ToString();
            labelDataQuarterlyInflation.Text = result.OutcomeString;

        }

        private void buttonLoanRepayment_Click(object sender, EventArgs e)
        {
            Variables variables = new Variables();
            OutcomeHolder result = new OutcomeHolder();

            result.AmountOfInvestment = Convert.ToDouble(numericUpDownAmountLoanRepayment.Value);
            result.SavingTime = Convert.ToDouble(numericUpDownSavingTimeLoanRepayment.Value);
            result.InterestRate = Convert.ToDouble(numericUpDownInterestRateLoanRepayment.Value);

            result = ProductionModul.Specimen.LoanRepayment(result.AmountOfInvestment, result.SavingTime, result.InterestRate);
            textBoxLoanRepayment.Text = result.Outcome.ToString();
            labelData.Text = result.OutcomeString;
        }


        //LoanRepayment funkcio = new LoanRepayment();



    }
}

