using System;

namespace numeros_inverso_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];
            Console.WriteLine($"Insira {numeros.Length} números");

            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° número");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nOs números escritos de forma inversa são: ");

            for (var i = (numeros.Length - 1); i >= 0; i--)
            {
               
                Console.WriteLine($"{numeros[i]}");
            }
        }
    }
}
