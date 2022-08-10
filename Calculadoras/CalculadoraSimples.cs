using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class CalculadoraSimples : Form
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void CalculadoraSimples_Load(object sender, EventArgs e)
        {

        }

        private void Concatenation(string caracter)
        {
            if (caracter == "=")
            {
                Calculate(lblTela.Text);
            }
            else
            {
                lblTela.Text += caracter;
            }
        }

        private void Calculate(string operation)
        {
            DataTable Calc = new DataTable();
            var result = Calc.Compute(operation, "");
            lblTela.Text = Convert.ToString(result);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Concatenation("0");
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Concatenation("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Concatenation("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Concatenation("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Concatenation("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Concatenation("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Concatenation("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Concatenation("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Concatenation("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Concatenation("9");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Concatenation("/");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Concatenation("*");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            Concatenation("-");
        }
        private void btnMais_Click(object sender, EventArgs e)
        {
            Concatenation("+");
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            Concatenation("=");
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblTela.Text = String.Empty;
        }
    }
}
