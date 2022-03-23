using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class funcionario
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public string cpf { get; private set; }
        public Endereco endereco { get; private set; }

        public funcionario(int id, string nome, string cpf, Endereco endereco)
        {
            if(id == null)
            {
                throw new ArgumentNullException("O valor de id não pode ser nulo!");
            }
            if(nome == "")
            {
                throw new ArgumentNullException("Nome não pode ser nulo!");
            }
            
            this.id = id;
            this.name = nome;
            this.cpf = cpf;
            this.endereco = endereco;
        }
    }
}
