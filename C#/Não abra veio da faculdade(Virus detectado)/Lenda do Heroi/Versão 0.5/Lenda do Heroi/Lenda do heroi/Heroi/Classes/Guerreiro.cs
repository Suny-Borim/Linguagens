using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenda_do_heroi
{
    internal class Guerreiro : Heroi
    {
        public Guerreiro(string nome,int idade)
        {
            this.setNome(nome);
            this.setIdade(idade);
            this.setLv(1);
            Corpo corpo1 = new Corpo("cabeca", "torso", "mao", "pernas", "pes");
            Status statusG = new Status(175, 0, 55, 40, 10, 20);
            this.setStatus(statusG);
            this.base.set
            
        }
       
    }
}
