using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    public class Conta
    {

        private int numero;
        private Cliente titular;
        private double saldo;

        public int Numero { get; private set; }
        public double Saldo { get; private set; }
        public bool Saca(double valor) 
        { 
            
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;

                return true;
            }
            return false;
        }

        public void Deposita(double valor)
        {

            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {

            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }

        public double PegaSaldo() 
        {

            return this.Saldo;
        }

        public void ColocaNumero(int numero)
        {

            this.Numero = numero;
        }
    }
}
