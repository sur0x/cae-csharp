﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta conta;
        private Conta conta2;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new Conta();
            this.conta.Numero = 1;
            Cliente Joao = new Cliente("Joao");
            this.conta.Titular = Joao;
            TextoTitular.Text = conta.Titular.Nome;
            TextoNumero.Text = Convert.ToString(conta.Numero);
            TextoSaldo.Text = Convert.ToString(conta.Saldo);

            //Conta 2

            this.conta2 = new Conta();
            this.conta2.Numero = 2;
            Cliente Maria = new Cliente("Maria");
            this.conta2.Titular = Maria;
            TextoTitular2.Text = conta2.Titular.Nome;
            TextoNumero2.Text = Convert.ToString(conta2.Numero);
            TextoSaldo2.Text = Convert.ToString(conta2.Saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorDeposito = Convert.ToDouble(TextoValor.Text);

            if (conta.Deposita(valorDeposito))
            {
                MessageBox.Show("Depositado com Sucesso");
                TextoSaldo.Text = Convert.ToString(conta.Saldo);
            }
            else
            {
                MessageBox.Show("Erro no Deposito");
                Environment.Exit(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valorSaque = Convert.ToDouble(TextoSaque.Text);
            if (conta.Saca(valorSaque))
            {
                MessageBox.Show("Saque feito com Sucesso");
                TextoSaldo.Text = Convert.ToString(conta.Saldo);
            }
            else
            {
                MessageBox.Show("Saque nao realizado");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (conta.Transfere(conta2,Convert.ToDouble(TextoTransfer.Text)))
            {
                MessageBox.Show("Sucesso");
                TextoSaldo2.Text = Convert.ToString(conta2.Saldo);
                TextoSaldo.Text = Convert.ToString(conta.Saldo);
            }
            else
            {
                MessageBox.Show("Nope");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
