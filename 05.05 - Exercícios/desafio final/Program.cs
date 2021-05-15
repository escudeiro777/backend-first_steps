using System;

namespace desafio_final
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int fibonacci;

            Console.WriteLine("Sequência de Fibonacci");

            for (int i = 0; i < 15; i++)
            {
                fibonacci = numeroAnterior + numeroAtual;
                Console.WriteLine(fibonacci);
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
            }

        }
    }
}
