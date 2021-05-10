using System;

namespace exercicio_10_valores_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int valoresUsuario = 10;
            int[] valores = new int[valoresUsuario];
            int menor = 0, maior = 0;

            Console.WriteLine("Digite 10 números da sua preferência:");

            for (var i = 0; i < valoresUsuario; i++)
            {
                Console.WriteLine($"Digite o {(i + 1)}° número: ");
                valores[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    menor = valores[0];
                    maior = valores[0];
                }
                if (valores[i] < menor)
                {
                    menor = valores[i];
                }
                else if (valores[i] > maior)
                {
                    maior = valores[i];
                }
            }
                Console.WriteLine("O maior valor digitado foi: " + maior);
                Console.WriteLine("O menor valor digitado foi: " + menor);
        }
    }
}
