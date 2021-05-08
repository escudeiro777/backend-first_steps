using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dois números que serão utilizados: ");
            double primeiroNumero = double.Parse(Console.ReadLine());
            double segundoNumero  = double.Parse(Console.ReadLine());
                 
            Console.WriteLine("Qual operação você deseja fazer?" + "\n" + "Adição [A] Subtração [S] Multiplicação [M]  Divisão [D]");
            string operacao = Console.ReadLine (). ToUpper();

            string resposta;
            do
           {
               switch (operacao)
               {
                    case "A":
                    Console.WriteLine($"O resultado da soma foi: {Somar(primeiroNumero, segundoNumero)}");
                    break;

                    case "S":
                    Console.WriteLine($"O resultado da subtração foi: {Subtrair(primeiroNumero, segundoNumero)}");
                    break;

                    case "M":
                    Console.WriteLine($"O resultado da multiplicação foi: {Multiplicar(primeiroNumero, segundoNumero)}");
                    break;

                    case "D":
                    Console.WriteLine($"O resultado da divisão foi: {Dividir(primeiroNumero, segundoNumero)}");
                    break;


                   default:
                   break;
               }
               Console.WriteLine("Deseja fazer uma nova operação? (S/N)");
               resposta = Console.ReadLine(). ToUpper();
           } while ( resposta == "S");

           if (resposta == "N")
           {
               Console.WriteLine("Obrigada por utilizar nossa calculadora!");
           }
    
        }

//---------------------------------------Funções---------------------------------------------//
        static double Somar (double primeiroNumero, double segundoNumero)
        {
        return primeiroNumero + segundoNumero;
        }

        static double Subtrair (double primeiroNumero, double segundoNumero)
        {
        return primeiroNumero - segundoNumero;
        }

        static double Multiplicar (double primeiroNumero, double segundoNumero)
        {
        return primeiroNumero * segundoNumero;
        }
         static double Dividir (double primeiroNumero, double segundoNumero)
        {
        return primeiroNumero / segundoNumero;
        }
    }
}
