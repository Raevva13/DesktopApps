using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinancialProductsWinforms.ProductsHolder;

namespace FinancialProductsWinforms
{

    public partial class FinancialProducts
        : Form
    {


        public FinancialProducts()
        {
            InitializeComponent();

        }
       
        private void buttonOneTime_Click(object sender, EventArgs e)
        {
            OneTimeInvestment investment = 
                new OneTimeInvestment(
                    Convert.ToInt32(numericUpDownAmountOneTime.Value),
                    Convert.ToDouble(numericUpDownInterestRateOneTime.Value),
                    Convert.ToInt32(numericUpDownSavingTimeOneTime.Value));

            investment.Compute();

            textBoxOneTime.Text = investment.Outcome.ToString();
            labelDataOneTime.Text = investment.OutcomeString;

        }

        private void buttonShortTerm_Click(object sender, EventArgs e)
        {
            ShortTerm investment =
                new ShortTerm(
                   Convert.ToInt32(numericUpDownAmountShorTermSavings.Value),
                   Convert.ToDouble(numericUpDownInterestRateShortTermSavings.Value),
                   Convert.ToInt32(numericUpDownNumberOfDepositsShortTermSavings.Value));

            investment.Compute();

            textBoxShortTerm.Text = investment.Outcome.ToString();
            labelDataShortTerm.Text = investment.OutcomeString;
        }

        private void buttonShortPreTerm_Click(object sender, EventArgs e)
        {
            ShortPreTerm investment =
                new ShortPreTerm(
                    Convert.ToInt32(numericUpDownAmountShortPreTerm.Value),
                    Convert.ToDouble(numericUpDownInterestRateShortPreTerm.Value),
                    Convert.ToInt32(numericUpDownNumberOfDepositsShortPreTerm.Value));

            investment.Compute();

            textBoxShortPreTerm.Text = investment.Outcome.ToString();
            labelDataPreTerm.Text = investment.OutcomeString;
        }

        private void buttonLongTerm_Click(object sender, EventArgs e)
        {
            LongTerm investment =
                new LongTerm(
                    Convert.ToInt32(numericUpDownAmountLongTerm.Value),
                    Convert.ToDouble(numericUpDownInterestRateLongTerm.Value),
                    Convert.ToInt32(numericUpDownSavingTimeLongTerm.Value));

            investment.Compute();

            textBoxLongTerm.Text = investment.Outcome.ToString();
            labelDataLongTerm.Text = investment.OutcomeString;
        }

        private void buttonCombinateSavingMonthly_Click(object sender, EventArgs e)
        {
            CombinateMonthly investment =
                new CombinateMonthly(
                    Convert.ToInt32(numericUpDownAmountCombinateMonthly.Value),
                    Convert.ToDouble(numericUpDownInterestRateCombinateMonthly.Value),
                    Convert.ToInt32(numericUpDownSavingTimeCombinateMonthly.Value));

            investment.Compute();

            textBoxCombinateSavingMonthly.Text = investment.Outcome.ToString();
            labelDataCombinateMonthly.Text = investment.OutcomeString;
        }

        private void buttonCombinateSavingMonthlyWithInflation_Click(object sender, EventArgs e)
        {
            CombinateMonthlyWithInflation investment
                = new CombinateMonthlyWithInflation(
                    Convert.ToInt32(numericUpDownAmountCombinateMonthlyInflation.Value),
                    Convert.ToDouble(numericUpDownInterestRateCombinateMonthlyInflation.Value),
                    Convert.ToInt32(numericUpDownSavingTimeCombinateMonthInflation.Value),
                    Convert.ToDouble(numericUpDownInflationCombinateMonthlyInflation.Value));

            investment.Compute();

            textBoxCombinateSavingsmonthlyWithInflation.Text = investment.Outcome.ToString();
            labelDataCombinateMonthlyInflation.Text = investment.OutcomeString;
        }

        private void buttonCombinateSavingsQuarterly_Click(object sender, EventArgs e)
        {
            CombinateQuarterly investment
                = new CombinateQuarterly(
                    Convert.ToInt32(numericUpDownAmountCombinateQuarterly.Value),
                    Convert.ToDouble(numericUpDownInterestRateCombinateQuarterly.Value),
                    Convert.ToInt32(numericUpDownSavingTimeCombinateQuarterly.Value),
                    Convert.ToInt32(numericUpDownNumberOfDepositsCombinateQuarterly.Value));

            investment.Compute();

            textBoxCombinateSavingsQuarterly.Text = investment.Outcome.ToString();
            labelDataCombinateQuarterly.Text = investment.OutcomeString;
        }

        private void buttonCombinateQuarterlyWithInflation_Click(object sender, EventArgs e)
        {
            CombinateQuarterlyWithInflation investment
                = new CombinateQuarterlyWithInflation(
                    Convert.ToInt32(numericUpDownAmountCombinateQuarterlyInflation.Value),
                    Convert.ToDouble(numericUpDownInterestRateCombinateQuarterlyInflation.Value),
                    Convert.ToInt32(numericUpDownSavingTimeCombinateQuarterlyInflation.Value),
                    Convert.ToInt32(numericUpDownNumberOfDepositsCombinateQuarterlyInflation.Value),
                    Convert.ToDouble(numericUpDownAmountCombinateQuarterlyInflation.Value));

            investment.Compute();

            textBoxCombinateQuarterlyWithInflation.Text = investment.Outcome.ToString();
            labelDataQuarterlyInflation.Text = investment.OutcomeString;



 

        }

        //private void buttonLoanRepayment_Click(object sender, EventArgs e)
        //{
        //    OutcomeHolder result = new OutcomeHolder();

        //    result.AmountOfInvestment = Convert.ToDouble(numericUpDownAmountLoanRepayment.Value);
        //    result.SavingTime = Convert.ToDouble(numericUpDownSavingTimeLoanRepayment.Value);
        //    result.InterestRate = Convert.ToDouble(numericUpDownInterestRateLoanRepayment.Value);

        //    //result = ProductionModul.Specimen.LoanRepayment(result.AmountOfInvestment, result.SavingTime, result.InterestRate);
        //    textBoxLoanRepayment.Text = result.Outcome.ToString();
        //    labelData.Text = result.OutcomeString;
        //}





        //_________________________________________________

        //public enum Products
        //{
        //    oneTimeInvestment, shortTermSavings, shortPreTermSavings, longTermSavings, combinateSavingsMonthly, combinateSavingsMonthlyWithInflation, combinateSavingsQuarterly, combinateSavingsQuarterlyWithInflation, loanRepayment
        //};


        //private double varAmountOfInvestment;
        //private double varSavingTime;
        //private double varInterestRate;
        //private double varNumberOfDeposits;
        //private double varInflation;
        //private Products selectedProduct;


        //comboBoxProducts.DataSource = Enum.GetValues(typeof(Products));
        //comboBoxProducts.SelectedIndex = 2;
        //comboBoxProducts.Items.Add();
        //comboBoxProducts.SelectedIndex = 0;

        //private void buttonResult_Click(object sender, EventArgs e)
        //{

        //    labelInformation.Text = string.Empty;

        //variables
        //selectedProduct = (Products)comboBoxProducts.SelectedIndex;
        //varAmountOfInvestment = Convert.ToDouble(numericUpDownAmountOfInvestment.Value);
        //varSavingTime = Convert.ToDouble(numericUpDownSavingTime.Value);
        //varInterestRate = Convert.ToDouble(numericUpDownInterestRate.Value);
        //varNumberOfDeposits = Convert.ToDouble(numericUpDownNumberOfDeposits.Value);
        //varInflation = Convert.ToDouble(numericUpDownInflation.Value);


        //OutcomeHolder result = new OutcomeHolder();

        // choice from products
        //switch (selectedProduct)
        //{
        //    case Products.oneTimeInvestment:
        //        {
        //            //labelInformation.Text = "Zadejte:\nVýši vkladu\nDobu spoření v letech\nÚrokovou sazbu";
        //            //labelAmountOfInvestment.Visible = true;
        //            //numericUpDownAmountOfInvestment.Visible = true;
        //            //labelSavingTime.Visible = true;
        //            //numericUpDownSavingTime.Visible = true;
        //            //labelInterestRate.Visible = true;
        //            //numericUpDownInterestRate.Visible = true;

        //            //labelNumberOfDeposits.Visible = false;
        //            //numericUpDownNumberOfDeposits.Visible = false;
        //            //labelInflation.Visible = false;
        //            //numericUpDownInflation.Visible = true;

        //            //result = ProductionModul.Specimen.OneTimeInvestment(varAmountOfInvestment, varSavingTime, varInterestRate);
        //        }
        //        break;

        //    case Products.shortTermSavings:
        //        {
        //            //labelInformation.Text = "Zadejte:\nVýši vkladu\nÚrokovou sazbu\nPočet vkladů během p.a.";
        //            //labelAmountOfInvestment.Visible = true;
        //            //numericUpDownAmountOfInvestment.Visible = true;
        //            //labelInterestRate.Visible = true;
        //            //numericUpDownInterestRate.Visible = true;
        //            //labelNumberOfDeposits.Visible = true;
        //            //numericUpDownNumberOfDeposits.Visible = true;

        //            //labelSavingTime.Visible = false;
        //            //numericUpDownSavingTime.Visible = false;
        //            //labelInflation.Visible = false;
        //            //numericUpDownInflation.Visible = false;

        //            //result = ProductionModul.Specimen.ShortTermSavings(varAmountOfInvestment, varInterestRate, varNumberOfDeposits);
        //            break;
        //        }

        //    case Products.shortPreTermSavings:
        //        {
        //            //labelInformation.Text = "Zadejte:\nVýši naspořené částky\nÚrokovou sazbu\nPočet vkladů během p.a.";
        //            //labelAmountOfInvestment.Visible = true;
        //            //numericUpDownAmountOfInvestment.Visible = true;
        //            //labelInterestRate.Visible = true;
        //            //numericUpDownInterestRate.Visible = true;
        //            //labelNumberOfDeposits.Visible = true;
        //            //numericUpDownNumberOfDeposits.Visible = true;

        //            //labelSavingTime.Visible = false;
        //            //numericUpDownSavingTime.Visible = false;
        //            //labelInflation.Visible = false;
        //            //numericUpDownInflation.Visible = false;

        //            //result = ProductionModul.Specimen.ShortPreTermSavings(varAmountOfInvestment, varInterestRate, varNumberOfDeposits);
        //        }
        //        break;
        //    case Products.longTermSavings:
        //        {
        //            //labelInformation.Text = "Zadejte:\nVýši vkladu\nDobu spoření v letech\nÚrokovou sazbu";
        //            //labelAmountOfInvestment.Visible = true;
        //            //numericUpDownAmountOfInvestment.Visible = true;
        //            //labelSavingTime.Visible = true;
        //            //numericUpDownSavingTime.Visible = true;
        //            //labelInterestRate.Visible = true;
        //            //numericUpDownInterestRate.Visible = true;

        //            //labelNumberOfDeposits.Visible = false;
        //            //numericUpDownNumberOfDeposits.Visible = false;
        //            //labelInflation.Visible = false;
        //            //numericUpDownInflation.Visible = false;

        //            //result = ProductionModul.Specimen.LongTermSavings(varAmountOfInvestment, varSavingTime, varInterestRate);

        //        }
        //        break;

        //    case Products.combinateSavingsMonthly:
        //        {
        //            //labelInformation.Text = "Zadejte:\nVýši vkladu\nDobu spoření v letech\nÚrokovou sazbu";
        //            //labelAmountOfInvestment.Visible = true;
        //            //numericUpDownAmountOfInvestment.Visible = true;
        //            //labelSavingTime.Visible = true;
        //            //numericUpDownSavingTime.Visible = true;
        //            //labelInterestRate.Visible = true;
        //            //numericUpDownInterestRate.Visible = true;

        //            //labelNumberOfDeposits.Visible = false;
        //            //numericUpDownNumberOfDeposits.Visible = false;
        //            //labelInflation.Visible = false;
        //            //numericUpDownInflation.Visible = false;

        //            //result = ProductionModul.Specimen.CombinateSavingsMonthly(varAmountOfInvestment, varSavingTime, varInterestRate);

        //        }
        //        break;

        //    case Products.combinateSavingsMonthlyWithInflation:
        //        {
        //            //labelInformation.Text = "Zadejte:\nVýši vkladu\nDobu spoření v letech\nÚrokovou sazbu\nVýši inflace";
        //            //labelAmountOfInvestment.Visible = true;
        //            //numericUpDownAmountOfInvestment.Visible = true;
        //            //labelSavingTime.Visible = true;
        //            //numericUpDownSavingTime.Visible = true;
        //            //labelInterestRate.Visible = true;
        //            //numericUpDownInterestRate.Visible = true;
        //            //labelInflation.Visible = true;
        //            //numericUpDownInflation.Visible = true;

        //            //labelNumberOfDeposits.Visible = false;
        //            //numericUpDownNumberOfDeposits.Visible = false;

        //            //result = ProductionModul.Specimen.CombinateSavingsMonthlyWithInflation(varAmountOfInvestment, varSavingTime, varInterestRate, varInflation);
        //        }
        //        break;



        //    case Products.combinateSavingsQuarterly:
        //        {
        //            //labelInformation.Text = "Zadejte\nVýši vkladu\nDobu spoření v letech\nÚrokovou sazbu\nPočet vkladů";
        //            //labelAmountOfInvestment.Visible = true;
        //            //numericUpDownAmountOfInvestment.Visible = true;
        //            //labelSavingTime.Visible = true;
        ////            //numericUpDownSavingTime.Visible = true;
        ////            //labelInterestRate.Visible = true;
        ////            //numericUpDownInterestRate.Visible = true;
        ////            //labelNumberOfDeposits.Visible = true;
        ////            //numericUpDownNumberOfDeposits.Visible = true;

        ////            //labelInflation.Visible = false;
        ////            //numericUpDownInflation.Visible = false;

        ////            //result = ProductionModul.Specimen.CombinateSavingsQuarterly(varAmountOfInvestment, varSavingTime, varInterestRate, varNumberOfDeposits);
        ////        }
        ////        break;


        ////    case Products.combinateSavingsQuarterlyWithInflation:
        ////        {
        ////            //labelInformation.Text = "Zadejte:\nVýši vkladu\nDobu spoření v letech\nÚrokovou sazbu\nPočet vkladů během p.a.\nVýši inflace";
        ////            //labelAmountOfInvestment.Visible = true;
        ////            //numericUpDownAmountOfInvestment.Visible = true;
        ////            //labelSavingTime.Visible = true;
        ////            //numericUpDownSavingTime.Visible = true;
        ////            //labelInterestRate.Visible = true;
        ////            //numericUpDownInterestRate.Visible = true;
        ////            //labelNumberOfDeposits.Visible = true;
        ////            //numericUpDownNumberOfDeposits.Visible = true;
        ////            //labelInflation.Visible = true;
        ////            //numericUpDownInflation.Visible = true;


        ////            //result = ProductionModul.Specimen.CombinateSavingsQuarterlyWithInflation(varAmountOfInvestment, varSavingTime, varInterestRate, varNumberOfDeposits, varInflation);
        ////        }
        ////        break;

        //    case Products.loanRepayment:
        //        {
        //            //labelInformation.Text = "Zadejte:\nVýši úvěru\nDobu spoření v letech\nÚrokovou sazbu";
        //            //labelAmountOfInvestment.Visible = true;
        //            //numericUpDownAmountOfInvestment.Visible = true;
        //            //labelSavingTime.Visible = true;
        //            //numericUpDownSavingTime.Visible = true;
        //            //labelInterestRate.Visible = true;
        //            //numericUpDownSavingTime.Visible = true;

        //            //labelNumberOfDeposits.Visible = false;
        //            //numericUpDownNumberOfDeposits.Visible = false;
        //            //labelInflation.Visible = false;
        //            //numericUpDownInflation.Visible = false;

        //            //result = ProductionModul.Specimen.LoanRepayment(varAmountOfInvestment, varSavingTime, varInterestRate);
        //        }
        //        break;

        //    default:
        //        MessageBox.Show("Tato možnost neexistuje");
        //        break;
        //}

        ////textBoxResult.Text = result.Outcome.ToString();
        ////labelOutcomeString.Text = result.OutcomeString;


        ////OutcomeHolder result = new OutcomeHolder();

        ////result.AmountOfInvestment = Convert.ToDouble(numericUpDownAmountCombinateQuarterlyInflation.Value);
        ////result.SavingTime = Convert.ToDouble(numericUpDownSavingTimeCombinateQuarterlyInflation.Value);
        ////result.InterestRate = Convert.ToDouble(numericUpDownInterestRateCombinateQuarterlyInflation.Value);
        ////result.NumberOfDeposits = Convert.ToDouble(numericUpDownNumberOfDepositsCombinateQuarterlyInflation.Value);
        ////result.Inflation = Convert.ToDouble(numericUpDownInflationCombinateQuarterlyInflation.Value);

        ////result = ProductionModul.Specimen.CombinateSavingsQuarterlyWithInflation(result.AmountOfInvestment, result.SavingTime, result.InterestRate, result.NumberOfDeposits, result.Inflation);
        ////textBoxCombinateQuarterlyWithInflation.Text = result.Outcome.ToString();
        ////labelDataQuarterlyInflation.Text = result.OutcomeString;
        //}



    }
}

