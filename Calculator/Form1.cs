using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        public Boolean DataValidation(params string[] arguments)
        {
            error.Text = "";
            result.Text = "";
            firstArg.Text = firstArg.Text.Replace('.', ',');
            secondArg.Text = secondArg.Text.Replace('.', ',');

            foreach(string argument in arguments)
            {
                if (!double.TryParse(argument, out double number))
                {
                    return false;
                }
            }

            return true;
        }

        public double Operation(object operationName, params double[] arguments)
        {
            double resultOp;

            if (arguments.Length == 2)
            {
                ITwoArgumentsCalculator calculatorTwoArg =
                TwoArgumentsFactory.CreateCalculator(((Button)operationName).Name);
                resultOp = calculatorTwoArg.Calculate(arguments[0], arguments[1]);
            }
            else
            {
                IOneArgumentCalculator calculatorOneArg =
                OneArgumentFactory.CreateCalculator(((Button)operationName).Name);
                resultOp = calculatorOneArg.Calculate(arguments[0]);
            }

            return resultOp;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TwoArguments_Click(object sender, EventArgs e)
        {
            if (DataValidation(firstArg.Text, secondArg.Text))
            {
                double numberOne = Convert.ToDouble(firstArg.Text);
                double numberTwo = Convert.ToDouble(secondArg.Text);
                double resultOperation = Operation(sender, numberOne, numberTwo);
                result.Text = resultOperation.ToString();
            }
            else error.Text = "incorrect data";
        }

        private void OneArgument_Click(object sender, EventArgs e)
        {
            if(secondArg.Text != "") secondArg.Text = "";

            if (DataValidation(firstArg.Text))
            {
                double argument = Convert.ToDouble(firstArg.Text);
                double resultOperation = Operation(sender, argument);
                result.Text = resultOperation.ToString();
            }
            else error.Text = "incorrect data";
        }

    }
}
