using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] idades = null;

            Console.WriteLine("Quantas idades você deseja cadastrar?");
            int quantidadeIdades = int.Parse(Console.ReadLine());

            idades = new int [quantidadeIdades];

           for (var i = 0; i < quantidadeIdades; i++)
           {
                Console.WriteLine("Digite a " + (i + 1) + "° idade: ");
                idades[i] = int.Parse(Console.ReadLine());
           }

            //for (var i = 0; i < quantidadeIdades; i++)
            //{
            //   Console.WriteLine("A "+ (i + 1) + "° idade é: " + idades[i]);
            //}

            int c = 1;
            foreach (var item in idades)
            {
                    Console.WriteLine($"A {c}° idade é:{item}");
                    c++;
            }
        }
    }
}
