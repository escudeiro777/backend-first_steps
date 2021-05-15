using System;

namespace exercicio_produtos_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual produto você pegou?");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine($"Qual a quantidade de {nomeProduto} que você pegou?");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o preço unitário de {nomeProduto}?");
            double precoProduto = double.Parse(Console.ReadLine());

            double total = quantidadeProduto * precoProduto;

            if (quantidadeProduto <= 5)
            {
                Console.WriteLine($"Seu desconto foi: {total * 0.02 }");
                Console.WriteLine($"O preço a pagar será: R$ {total - (total * 0.02)}");
            }
            else if (quantidadeProduto > 5 && quantidadeProduto <= 10)
            {
                Console.WriteLine($"Seu desconto foi: {total * 0.03 }");
                Console.WriteLine($"O preço a pagar será: R$ {total - (total * 0.03)}");
            }
            else
            {
                Console.WriteLine($"Seu desconto foi: {total * 0.05 }");
                Console.WriteLine($"O preço a pagar será: R$ {total - (total * 0.05)}");
            }

        }
    }

}
