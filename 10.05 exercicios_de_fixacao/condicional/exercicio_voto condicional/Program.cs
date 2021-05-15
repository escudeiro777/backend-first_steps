using System;

namespace exercicio_voto_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quer saber se você já pode votar??? Digite o ano que você nasceu aqui!");
            int anoNascimento = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;
            int idade =  anoAtual-anoNascimento;

            if (idade >= 16)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você está apto para votar! Vá até o cartório mais próximo e tire seu título.");
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você ainda não possue idade o suficiente para votar :( espere só mais um pouquinho!");
            }

        }
    }
}
