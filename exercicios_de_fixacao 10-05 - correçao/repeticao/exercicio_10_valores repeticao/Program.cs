using System;

namespace exercicio_10_valores_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] numeros = new int [10];
            Console.WriteLine($"Digite {numeros.Length} valores");

            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o {(i+1)}° valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);

            Console.WriteLine($"O maior número é {numeros[(numeros.Length - 1)]}");
            Console.WriteLine($"O menor número é {numeros[0]}");

        }
    }
}
