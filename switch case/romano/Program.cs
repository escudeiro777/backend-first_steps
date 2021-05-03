using System;

namespace romano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu algarismo romano aqui: ");
            string romano = Console.ReadLine() .ToLower();

            switch (romano)
            {
                case "i":
                Console.WriteLine("I equivale a 1 em indo arábico");
                    break;

                case "ii":
                Console.WriteLine("II equivale a 2 em indo arábico");
                    break;

                case "iii":
                Console.WriteLine("III equivale a 3 em indo arábico");
                    break;

                case "iv":
                Console.WriteLine("IV equivale a 4 em indo arábico");
                    break;

                case "v":
                Console.WriteLine("V equivale a 5 em indo arábico");
                    break;

                case "vi":
                Console.WriteLine("VI equivale a 6 em indo arábico");
                    break;

                case "vii":
                Console.WriteLine("VII equivale a 7 em indo arábico");
                    break;

                case "viii":
                Console.WriteLine("VIII equivale a 8 em indo arábico");
                    break;

                case "ix":
                Console.WriteLine("IX equivale a 9 em indo arábico");
                    break;

                case "x":
                Console.WriteLine("X equivale a 10 em indo arábico");
                    break;

                default:
                Console.WriteLine("Escreva um número válido");
                    break;
            }
            
            
        }
    }
}
