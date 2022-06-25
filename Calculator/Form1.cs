using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        public double Operation(object operationName, double argOne, double argTwo)
        {
            ITwoArgumentsCalculator calculator =
            TwoArgumentsFactory.CreateCalculator(((Button)operationName).Name);
            double resultOp = calculator.Calculate(argOne, argTwo);

            return resultOp;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void FirstArg_TextChanged(object sender, EventArgs e)
        {

        }
        private void SecondArg_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TwoArguments_Click(object sender, EventArgs e)
        {
            error.Text = "";
            result.Text = "";
            firstArg.Text = firstArg.Text.Replace('.', ',');
            secondArg.Text = secondArg.Text.Replace('.', ',');

            if (double.TryParse(firstArg.Text, out double numberOne) &&
                double.TryParse(secondArg.Text, out double numberTwo))
            {
                double resultOperation = Operation(sender, numberOne, numberTwo);
                result.Text = resultOperation.ToString();
            }
            else error.Text = "incorrect data";
        }
        private void OneArgument_Click(object sender, EventArgs e)
        {
            double argument = Convert.ToDouble(firstArg.Text);
           /* double resultOperation = Operation(argument, , sender);*/
           /* result.Text = resultOperation.ToString();*/
        }

    }
}
