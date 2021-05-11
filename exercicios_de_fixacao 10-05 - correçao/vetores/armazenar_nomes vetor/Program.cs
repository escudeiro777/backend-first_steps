using System;

namespace armazenar_nomes_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            Console.WriteLine($"Digite o nome de {nomes.Length} pessoas");

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o nome da {(i + 1)}° pessoa");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine($"Digite o nome que você deseja buscar: ");
            string nomeBusca = Console.ReadLine();
            bool encontrado = false;

            foreach (var cadaNome in nomes)
            {
                if (nomeBusca == cadaNome)
                {
                    encontrado = true;

                }
            }
            if (encontrado == true)
            {
                Console.WriteLine("Achei!");
            }
            else
            {
                Console.WriteLine("Não achei!");
            }
        }
    }
}
