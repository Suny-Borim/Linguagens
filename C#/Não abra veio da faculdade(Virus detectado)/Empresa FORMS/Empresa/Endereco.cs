using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Endereco
    {
        public string logradouro { get; private set;}
        public string numero { get; private set;}
        public string complemento { get; private set;}
        public string cpp { get; private set;}

        public Endereco(string logradouro, string numero, string complemento, string cpp)
        {
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.cpp = cpp;
        }
    }
}
