using System;

namespace RPG
{
    internal class Heroi
    {
        public float vida = 100;
        public string nome = "";
        public int forca = 10;

        public void bater(Monstro monst)
        {
            monst.vida -= this.forca;
        }
    }
}
