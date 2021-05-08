using System;

namespace exercicio_pao_de_queijo
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] paozin = null;

            Console.WriteLine("Quantos pacotes de pão de queijo você tem?");
            int quantidadePao = int.Parse(Console.ReadLine());

            paozin = new int [quantidadePao];

           for (var i = 0; i < quantidadePao; i++)
           {
                Console.WriteLine("Quantos pães de queijo tem o " + (i + 1) + "° pacote: ");
                paozin[i] = int.Parse(Console.ReadLine());
           }
             int c = 1;
            foreach (var item in paozin)
            { 
                    Console.WriteLine($"O {c}° pacote tem {item} pãezinhos.");
                    c++;
                   
            }
        }
    }
}
