using System;

namespace RPG
{
    internal class Arqueiro : Heroi
    {
        public int aljava = 100;

        public void bater(Monstro monst)
        {
            monst.vida -= this.forca;
            this.aljava -= 1;
            if (monst.vivo) {
                Console.WriteLine(this.nome + " atacou o " + monst.nome + " deixando com " + monst.vida + " de vida e ficando com " + this.aljava + " flecha(s) na aljava");
                monst.checaVivo();
            }
            else
            {
                Console.WriteLine(monst.nome + " já está morto");
            }
        }
    }
}
