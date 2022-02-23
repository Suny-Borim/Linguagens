using System;
namespace RPG
{
    internal class Guerreiro : Heroi
    {
        public void bater(Monstro monst)
        {
            monst.vida -= this.forca * 1.1f;
            if (monst.vivo)
            {
                Console.WriteLine(this.nome + " atacou o " + monst.nome + " deixando com " + monst.vida + " de vida");
                monst.checaVivo();
            }
            else
            {
                Console.WriteLine(monst.nome + " já está morto");
            }
        }
    }
}
