using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorawindowsforms
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        char operacao;
        Operacoes op = new Operacoes();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + "0";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + ",";
        }


        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(this.textResultado.Text);
            this.textResultado.Text = this.textResultado.Text + "-";
            operacao = '-';
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + "5";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string[] splitNumbers = this.textResultado.Text.Split(operacao);
            if (splitNumbers.Length == 2)
            {
                if (this.textResultado.Text.Contains("+") || this.textResultado.Text.Contains("-") ||
                    this.textResultado.Text.Contains("*") || this.textResultado.Text.Contains("/"))
                {
                    num2 = Double.Parse(splitNumbers[1].ToString());
                    switch (operacao)
                    {
                        case '+':
                            this.textResultado.Text = this.textResultado.Text + " = " + op.Soma(num1, num2).ToString();
                            break;
                        case '-':
                            this.textResultado.Text = this.textResultado.Text + " = " + op.Subtracao(num1, num2).ToString();
                            break;
                        case '*':
                            this.textResultado.Text = this.textResultado.Text + " = " + op.Multiplicacao(num1, num2).ToString();
                            break;
                        case '/':
                            this.textResultado.Text = this.textResultado.Text + " = " + op.Divisao(num1, num2).ToString();
                            break;
                        default:
                            break;
                    }


                }
                else
                {
                    MessageBox.Show("Digite uma operação");
                }
            }
            else
            {
                MessageBox.Show("Insira 2 numeros para realizar a operação");
            }

        }


        private void btnSoma_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(this.textResultado.Text);
            this.textResultado.Text = this.textResultado.Text + "+";
            operacao = '+';
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + "8";
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + "9";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(this.textResultado.Text);
            this.textResultado.Text = this.textResultado.Text + "*";
            operacao = '*';
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(this.textResultado.Text);
            this.textResultado.Text = this.textResultado.Text + "/";
            operacao = '/';
        }
    }
}
