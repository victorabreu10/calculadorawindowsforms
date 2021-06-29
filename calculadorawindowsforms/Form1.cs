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
            this.textResultado.Text = this.textResultado.Text + "-";
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
            this.textResultado.Text = this.textResultado.Text + "=";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + "+";
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
            this.textResultado.Text = this.textResultado.Text + "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = this.textResultado.Text + "/";
        }
    }
}
