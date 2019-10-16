using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeZilda = 62;
            int idadeAdauto = 57;
            int idadeBruno = 30;

            int idadeMedia = (idadeAdauto + idadeZilda + idadeBruno) / 3;

            MessageBox.Show("A média de idade dos familiares é : " + idadeMedia);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;

            MessageBox.Show("Pi quebrado: " + piQuebrado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /**
            delta = b * b - 4 * a * c;
            a1 = (-b + raiz(delta)) / (2 * a);
            a2 = (-b - raiz(delta)) / (2 * a);
            */

            int a = 10;
            int b = 25;
            int c = 5;

            double delta = b * b - 4 * a * c;
            double deltaSqrt = Math.Sqrt(delta);
            double a1 = (-b + deltaSqrt) / (2 * a);
            double a2 = (-b - deltaSqrt) / (2 * a);

            MessageBox.Show("Valor de delta: " + delta + ". Valor de Raiz de Delta: " + deltaSqrt + ". Resultado da equação: A1 = " + a1 + ". A2 = " + a2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            bool realmentePodeSacar = (saldo >= valorSaque)  && (valorSaque > 0);

            if (realmentePodeSacar)
            {
                saldo -= valorSaque;

                MessageBox.Show("Saque realizado com sucesso. Saldo atual: " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int idade = 17;
            bool brasileira = true;

            if (idade >= 16 && brasileira)
            {

                MessageBox.Show("Eleitor pode votar.");
            }
            else
            {
                MessageBox.Show("Eleitor não pode votar.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double valorNotaFicals = 1500.00;
            double taxaImposto;
            double valorImposto;

            if (valorNotaFicals < 1000)
            {
                taxaImposto = 0.02;
            }
            else if (valorNotaFicals < 3000)
            {
                taxaImposto = 0.025;
            }
            else if (valorNotaFicals < 7000)
            {
                taxaImposto = 0.028;
            } else
            {
                taxaImposto = 0.03;
            }

            valorImposto = valorNotaFicals * taxaImposto;
            MessageBox.Show("Valor do imposto: " + valorImposto);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            int valor = 15;
            string messagem = valor > 10 ? "Maior que 10" : "Menor que 10";

            MessageBox.Show(messagem);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*
            Conta mauricio = new Conta();
            Conta mauricio2 = new Conta();

            mauricio.numero = 1;
            //mauricio.titular = "mauricio";
            mauricio.Deposita(100.0);

            mauricio2.numero = 1;
            //mauricio2.titular = "mauricio";
            mauricio2.Deposita(100.0);

            if (mauricio.numero == mauricio2.numero)
            {
                MessageBox.Show("São iguais");
            }
            else
            {
                MessageBox.Show("São diferentes");
            }
            */
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*
            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;

            Conta copia = mauricio;
            copia.saldo = 3000.0;

            MessageBox.Show("mauricio: " + mauricio.saldo);
            MessageBox.Show("copia: " + copia.saldo);
            */
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            Cliente guilherme = new Cliente();
            guilherme.nome = "Guilherme	Silveira";
            //umaConta.titular = guilherme;

            //MessageBox.Show(umaConta.titular.nome);
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Conta c = new Conta();
            double valorADepositar = 200.0;
            c.Deposita(valorADepositar);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente("Joao Gardin")
            {
                Idade = 27,
                Rg = "48.000.000-0",
                Cpf = "419.000.000-00"
            };
        }
    }
}
