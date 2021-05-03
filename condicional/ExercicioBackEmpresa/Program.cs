using System;

namespace BackEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu salário mensal? ");
            int salarioMensal = int.Parse(Console.ReadLine());

            if (salarioMensal < 500)
            {
                float porcentagemSalario = (salarioMensal /100) * 30;
                float salarioReajustado = salarioMensal + porcentagemSalario;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Salário Reajustado: " + salarioReajustado);
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você não tem direito ao reajuste.");
            }
        }
    }
}
