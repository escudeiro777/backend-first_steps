using System;

namespace exercicio_voto_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o ano que você nasceu: ");
            int anoNasc = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            int idade = anoAtual - anoNasc;

            if (idade >= 16 && idade < 18)
            {
                Console.WriteLine("Você pode votar! Não desgrace o país novamente.");
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Você DEVE votar! Não faça bosque na urna.");
            }
            else
            {
                Console.WriteLine("Você não pode votar!");
            }
        }
    }
}
