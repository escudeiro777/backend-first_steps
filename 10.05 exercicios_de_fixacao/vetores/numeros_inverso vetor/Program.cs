using System;

namespace numeros_inverso_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] valores = null;
            valores = new int[15];
           
            Console.WriteLine("Digite os 15 números de sua preferência:");
            
             for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"Digite o {(i + 1)}° número: ");
                valores[i] = int.Parse(Console.ReadLine());

            }
             for (var i = 14; i >= 0; i--)
             {
                 Console.WriteLine($"\n{valores[i]}");
             }

        }
    }
}
