using System;

namespace DesafioBackIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é sua idade?:");
            int idadeDaPessoa = int.Parse(Console.ReadLine());

            int idadeEmMeses = idadeDaPessoa * 12;
            int idadeEmSemanas = idadeDaPessoa * 52;
            int idadeEmDias = idadeDaPessoa * 365;
            int idadeEmHoras = idadeDaPessoa * 8766;
            int idadeEmMinutos = idadeDaPessoa * 525960;

            Console.WriteLine("Sua idade em meses é: " + idadeEmMeses + "\n");
            Console.WriteLine("Sua idade em dias é: " + idadeEmDias + "\n");
            Console.WriteLine("Sua idade em semanas é: " + idadeEmSemanas + "\n");
            Console.WriteLine("Sua idade em horas é: " + idadeEmHoras + "\n");
            Console.WriteLine("Sua idade em minutos é: " + idadeEmMinutos + "\n");


        }
    }
}
