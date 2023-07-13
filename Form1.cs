using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04Banco01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 telaExtrato = new Form2();
            telaExtrato.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtResultadoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            btnSacar.BackColor = Color.Gainsboro;
            btnSacar.ForeColor = Color.Black;
            btnDepositar.BackColor = Color.LightBlue;
            btnDepositar.ForeColor = Color.DodgerBlue;

            lblOperacao.Text = "DEPOSITO";
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            btnDepositar.BackColor = Color.Gainsboro;
            btnDepositar.ForeColor = Color.Black;
            btnSacar.BackColor = Color.LightBlue;
            btnSacar.ForeColor = Color.DodgerBlue;

            lblOperacao.Text = "SAQUE";

        }

        private void lblDeposito_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            double valor = double.Parse( txtResultadoValor.Text);
            double saldo = double.Parse(lblSaldo.Text.Replace("R$", "") );

            double soma;

            if (lblOperacao.Text == "SAQUE")
            {
                soma = saldo - valor;
            }
            else
            {
                soma = valor + saldo;
            }
                   
                    

            

            
            lblSaldo.Text = "R$" +soma;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
