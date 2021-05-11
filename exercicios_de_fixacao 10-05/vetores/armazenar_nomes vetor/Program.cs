using System;

namespace armazenar_nomes_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            Console.WriteLine("Escreva os nomes abaixo: ");

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° nome: ");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("Qual nome você deseja procurar?: ");
            string nomeProcurado = Console.ReadLine();

            foreach (var item in nomes)
            {
                if (item == nomeProcurado)
                {
                    Console.WriteLine($"O nome {nomeProcurado} consta no sistema");
                }
                //else
                //{
                //    Console.WriteLine($"O nome {nomeProcurado} não consta no sistema");
                //}

            }
        }
    }
}