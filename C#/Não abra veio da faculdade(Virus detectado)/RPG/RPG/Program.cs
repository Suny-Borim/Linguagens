using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerreiro gue = new Guerreiro();
            gue.nome = "Jose";
            Mago mag = new Mago();
            mag.nome = "Magui";
            Arqueiro arq = new Arqueiro();
            arq.nome = "Frederic";

            Oni oni = new Oni();
            oni.nome = "Oni";
            Monstro bat = new Monstro();
            bat.nome = "Bat";
            Monstro lob = new Monstro();
            lob.nome = "Lobo";

            gue.bater(oni);
            gue.bater(oni);
            gue.bater(oni);
            mag.bater(bat);
            mag.bater(bat);
            mag.bater(bat);
            arq.bater(lob);
            arq.bater(lob);
            arq.bater(lob);
        }
    }
}
