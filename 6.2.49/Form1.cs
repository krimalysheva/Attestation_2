using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramLogic;

namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs ev)
        {
            try
            {
                double x = double.Parse(this.InputX.Text);
                double e = double.Parse(this.InputE.Text);

                int n = int.Parse(this.InputN.Text);

                if (Math.Abs(x) >= 1)
                {
                    throw new Exception("X должен лежать в интевале (-1; 1)");
                }

                if (n < 1)
                {
                    throw new Exception("n должен быть натуральным числом");
                }

                Calculator calc = new Calculator(x);

                /**string output = string.Format("1) Сумма N слагаемых заданного вида: {0}" +
                    "2) Сумма N слагаемых заданного вида, больших E: {1}", calc.CalculateFunctionApproximately(n, 0));*/

                string output = "";
                output += "1) Сумма N слагаемых заданного вида: " + calc.CalculateFunctionApproximately(n, 0) + Environment.NewLine;
                output += "2) Сумма N слагаемых заданного вида, больших E: " + calc.CalculateFunctionApproximately(n, e) + Environment.NewLine;
                output += "3) Сумма N слагаемых заданного вида, больших E/10: " + calc.CalculateFunctionApproximately(n, e / 10) + Environment.NewLine;
                output += "4) Точная сумма: " + calc.CalculateFunctionDirectly();

                this.OutputBlock.Text = output;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void InputE_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

