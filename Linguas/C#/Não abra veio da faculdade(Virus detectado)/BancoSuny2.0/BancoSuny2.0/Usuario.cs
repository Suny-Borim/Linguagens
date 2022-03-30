using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSuny2._0
{
    public  class Usuario
    {
        public string nome { get;private  set; }
        public string cpf { get;private set; } 
        public Usuario(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
    }
}
