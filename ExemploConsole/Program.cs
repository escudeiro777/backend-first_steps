using System;

namespace ExemploConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //var estadoDoSemaforo = Qual a cor do semáforo? 
            // int exemplo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual é seu nome?");
            string nomeDaPessoa = Console.ReadLine();

            Console.WriteLine("Olá " + nomeDaPessoa + "!!!");
            
            Console.WriteLine("Qual é o primeiro número?: ");
            int primeiroNumero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o terceiro número?: ");
            int terceiroNumero = int.Parse(Console.ReadLine());

            int soma = primeiroNumero + segundoNumero + terceiroNumero;
            int divisao = soma / 3;
            Console.WriteLine("Sua média foi: " + divisao );



        }
    }
}
