using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Suny
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Cliente Suny = new Cliente("Suny", "23", "Dom quixote");
            Cliente Nicolly = new Cliente("Nicolly", "23", "Dom quixote");
            Conta SunyC = new Conta(0123, 3500,  Suny);
            Conta NicollyC = new Conta(0123, 50, Nicolly);

            NicollyC.saque(20f);
            SunyC.transferir(NicollyC, 100f);
            SunyC.exibir(Suny);
            NicollyC.exibir(Nicolly);
            Console.ReadLine();

        }
    }
}

