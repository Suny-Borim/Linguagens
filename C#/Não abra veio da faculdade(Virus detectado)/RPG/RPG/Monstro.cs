using System;

namespace RPG
{
    internal class Monstro
    {
        public float vida = 20;
        public string nome = "";
        public bool vivo = true;

        public void checaVivo()
        {
            if(this.vida <= 0)
            {
                //morreu
                Console.WriteLine(this.nome + " está morto");
                this.vivo = false;
            }
        }
    }
}
