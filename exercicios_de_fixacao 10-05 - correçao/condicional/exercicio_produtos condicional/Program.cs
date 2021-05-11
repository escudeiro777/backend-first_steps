using System;

namespace exercicio_produtos_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome do produto: ");
            string produto = Console.ReadLine();

            Console.WriteLine("Insira a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor unitário do produto: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine($"O valor total do produto adquirido é: R${(quantidade * valor).ToString("N2")}");

            if (quantidade <= 5)
            {
                 Console.WriteLine($"O valor total do produto adquirido com desconto é: R${((quantidade*valor)*0.98).ToString("N2")}");
            } else if (quantidade > 5 && quantidade <= 10)
            {
                 Console.WriteLine($"O valor total do produto adquirido com desconto é: R${((quantidade*valor)*0.97).ToString("N2")}");
            } else
            {
                 Console.WriteLine($"O valor total do produto adquirido com desconto é: R${((quantidade*valor)*0.95).ToString("N2")}");
            }
           
        }
    }
}
