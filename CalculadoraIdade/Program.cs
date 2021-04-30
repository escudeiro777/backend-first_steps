using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em qual ano você nasceu? ");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Em qual ano você está? ");
            int anoAtual = int.Parse(Console.ReadLine());

            int idadeDaPessoa = anoAtual - anoNascimento;
            int idadeEmSemanas = idadeDaPessoa * 52;

            Console.WriteLine("Sua idade é " + idadeDaPessoa + "\n");
            Console.WriteLine("Sua idade em semanas é: " + idadeEmSemanas + "\n");
      
           
         
        }
    }
}
