using System;

namespace ExercicioMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício da Média\n");

            Console.WriteLine("Qual é a primeira nota: ");
            double primeiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a segunda nota: ");
            double segundaNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é a terceira nota: ");
            double terceiraNota = double.Parse(Console.ReadLine());

            double media = (primeiraNota + segundaNota + terceiraNota) /3;
            // Console.WriteLine("A média das notas foi: " + Math.Round (media, 1));
            Console.WriteLine("A média foi: " + media.ToString("N1"));

            if (media > 5 )
            {
                // Se a média for maior que 5, aparecer aprovado na tela
                 Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine("Aprovado :) !!!");
                 
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Reprovado :( !!!");
            }

            
        }
    }
}
