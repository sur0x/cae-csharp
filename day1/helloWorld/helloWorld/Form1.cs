﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadePessoa1 = 29;
            int idadePessoa2 = 30;
            int idadePessoa3 = 4;
            double soma = idadePessoa1 + idadePessoa2 + idadePessoa3;
            double media = soma / 3;
            MessageBox.Show("Media de idade: " + media);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("Pi Quebrado" + piQuebrado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = 2;
            double b = 6;
            double c = 2;
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                MessageBox.Show("Delta negativo");
                Environment.Exit(0);
            }
            else 
                { 
                double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double a2 = (-b - Math.Sqrt(delta)) / (2 * a);
                MessageBox.Show("Primeira Raiz: " + a1 + " Segunda Raiz: " + a2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com Sucesso");
            }
            else
            { 
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double saldo = 500.0;

            if (saldo < 0.0)
            {
                MessageBox.Show("Voce esta no negativo");
            }

        else if (saldo < 1000000.0)
            {
                MessageBox.Show("Voce e um bom cliente");
            }   
        else
            {
                MessageBox.Show("Voce e milionaro");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int idade = 18;
            bool brasileira = true;
            bool maior = idade >= 16;

            if (maior && brasileira)
            {
                MessageBox.Show("Apta a Votar");
            }
            else
            {
                MessageBox.Show("Nao Esta apta a votar");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 7867.0;
            double imposto;
            if (valorDaNotaFiscal < 999)
            {
                 imposto = valorDaNotaFiscal * 0.02;
            }
            else if ( valorDaNotaFiscal >= 1000 && valorDaNotaFiscal <= 2999)
            {
                 imposto = valorDaNotaFiscal * 0.025;
            }
            else if ( valorDaNotaFiscal >= 3000 && valorDaNotaFiscal <= 6999)
            {
                 imposto = valorDaNotaFiscal * 0.028;
            }
            else
            {
                 imposto = valorDaNotaFiscal * 0.03;
            }
            MessageBox.Show("Imposto: " + imposto);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for( int i = 1; i <= 1000; i++)
            {
                soma += i;
            }
            MessageBox.Show("Soma de 1 ate 1000: " + soma);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                int divisivel = i % 3;
                if (divisivel == 0)
                {
                    MessageBox.Show("Numero multiplo: " + i);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                int divisivel = i % 3;
                if (divisivel == 0)
                {
                    continue;
                }else
                {
                    soma += i;
                }
            }
            MessageBox.Show("Soma dos Numeros: " + soma);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                bool divisivel = i % 3 == 0 || i % 4 == 0;
                //int div3 = i % 3;
                //int div4 = i % 4;
                if (divisivel)
                {
                    MessageBox.Show("Numero multiplo: " + i);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int i = 1; i <=10; i++)
            {
                fatorial = fatorial * i;
                MessageBox.Show("teste: " + fatorial);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int numero = 0;
            int n1 = 0;
            int n2 = 0;
            while(numero <= 100)
            {
                n2 = n1;
                n1 = numero;
                MessageBox.Show("Numero:" + numero);
                if (numero == 0 && n1 == 0 && n2 == 0)
                {
                    numero = 1;
                }
                else
                {
                    numero = n1 + n2;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {   
            for(int i = 1; i < 5; i++)
            {
                string valorfinal = null;
                for (int i2 = 1; i2 <= i; i2++)
                {
                    int valor = i * i2;
                    valorfinal += valor;
                    valorfinal += " ";
                }
                MessageBox.Show(valorfinal);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Conta conta1 = new Conta();
            conta1.titular = "Rodrigo Campos";
            conta1.saldo = 100.0;
            conta1.numero = 1;
            MessageBox.Show("Titular: " + conta1.titular + "\n" + "Saldo: " + conta1.saldo + "\n" + "Numero: " + conta1.numero);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Conta conta1 = new Conta();
            conta1.saldo = 100.0;
            if (conta1.Saca(1))
            {
                MessageBox.Show("Saque realizado com sucesso \n Saldo Atual: " + conta1.saldo);
            }
            else
            {
                MessageBox.Show("Sem saldo");
            }
            
        }
    }
}
