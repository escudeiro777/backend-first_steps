using System;

namespace exemploDo
{
    class Program
    {
        static void Main(string[] args)
        {
        string resposta = "";
        do
        {
            Console.WriteLine("Você deseja receber um bom dia? (s/n) ");
            resposta = Console.ReadLine() .ToLower();

        } while (resposta == "s");
        }
    }
}
