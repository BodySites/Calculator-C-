using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
 
        private double operation(double argOne, double argTwo, object op)
        {
            double resultOp = 0;
            switch (((Button)op).Name)
            {
                case "button1":
                    resultOp = argOne + argTwo;
                    break;
                case "button4":
                    resultOp = argOne - argTwo;
                    break;
                case "button3":
                    resultOp = argOne * argTwo;
                    break;
                case "button2":
                    resultOp = argOne / argTwo;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
            return resultOp;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(firstArg.Text);
            double secondArgument = Convert.ToDouble(secondArg.Text);
            double resultOperation = operation(firstArgument,secondArgument, sender);
            result.Text = resultOperation.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
