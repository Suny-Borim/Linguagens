using System;
namespace banana
{
    internal class Program{
        static void Main(string[] args)
        {/*
            Console.WriteLine("Qual seu nome puta?");
            var name = Console.ReadLine();

            Console.WriteLine("Qual sua idade " + name + "?");
            var idade = Console.ReadLine();
            Console.WriteLine("Você suporta o Arthur Agular filho duma puta, {0} (A resposta certa é não), sim/não?", name);
            var resposta = Console.ReadLine();*/

            int opcao1, opcao2, opcao3;

            Console.WriteLine("Porcentagem da Naiara: ");
       opcao1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Porcentagem da DG: ");
            opcao2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Porcentagem da Arthur: ");
            opcao3 = Int32.Parse(Console.ReadLine());

            if(opcao1 > opcao2&& opcao1 > opcao3)
            {
                Console.WriteLine("Toma aqui seus 50 reais");
            }
            else if(opcao2 > opcao1 && opcao2 > opcao3)
            {
                Console.WriteLine("Dadinho é o cara, o aqui é o zé pequeno");
            }
            else
            {
                Console.WriteLine("O Arthur te convenceu a perdoar ele e quem sai é você");
            }

        }
    } 
}

