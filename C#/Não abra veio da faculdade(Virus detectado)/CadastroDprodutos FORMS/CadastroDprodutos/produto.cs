using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDprodutos
{
    public class produto
    {
        public string nome { get; private set; }
        public string preco { get; private set; }
        public string descricao { get; private set; } 

        public produto(string nome, string preco, string descricao)
        {
            this.nome = nome;
            this.preco = preco;
            this.descricao = descricao;
        }
    }
}
