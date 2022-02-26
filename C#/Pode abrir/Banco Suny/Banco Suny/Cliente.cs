using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Suny
{
    internal class Cliente 
    {
        public string cpf, nome, Banco;
    

        public Cliente(string nome,string cpf, string Banco)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.Banco = Banco;
        }
    }
}
