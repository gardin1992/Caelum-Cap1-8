using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    class Cliente
    {

        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Cpf { get; set; }

        public string Rg { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente(string nome, int idade)            
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public bool EhMaiorDeIdade()
        {

            return this.Idade >= 18;
        }
    }
}
