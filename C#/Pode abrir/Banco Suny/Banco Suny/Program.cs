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
            Conta carinha = new Conta(0123, 0,  Suny);
            Conta carinha2 = new Conta(0123, 0, Nicolly);

            carinha2.saque(100f);
            carinha.transferir(carinha2, 100f);
            carinha.exibir(Suny);
            carinha2.exibir(Nicolly);
            Console.ReadLine();

        }
    }
}

