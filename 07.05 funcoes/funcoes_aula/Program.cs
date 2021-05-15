using System;

namespace funcoes_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o seu sobrenome?");
            string sobrenome = Console.ReadLine();

           Saudacao(nome, sobrenome);

           int hora = MostrarHora();
           Console.WriteLine($"{hora} h");

        }

        static void Saudacao(string nome, string sobrenome) 
        {
        Console.WriteLine($"Buon Pomeriggio! {nome} {sobrenome}!!!");
        }
        
        static int MostrarHora(){

            return DateTime.Now.Hour;
        }
    }
}
