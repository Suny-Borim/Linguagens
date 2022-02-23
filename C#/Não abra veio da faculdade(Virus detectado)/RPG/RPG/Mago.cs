using System;

namespace RPG
{
    internal class Mago : Heroi
    {
        public int mana = 1000;
        public void bater(Monstro monst)
        {
            monst.vida -= this.forca;
            this.mana -= 10;
            if(monst.vivo){
                Console.WriteLine(this.nome + " atacou o " + monst.nome + " deixando com " + monst.vida + " de vida e ficando com " + this.mana + " de mana");
                monst.checaVivo();
            }
            else
            {
                Console.WriteLine(monst.nome + " já está morto");
            }
        }
    }
}
