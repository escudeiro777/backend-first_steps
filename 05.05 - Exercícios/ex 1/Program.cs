using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nota = false;
            while (nota == false)
            {
                Console.WriteLine("Digite qual foi sua nota: ");
                double respostaUsuario = double.Parse(Console.ReadLine());

                if (respostaUsuario >= 0 && respostaUsuario <= 10)
                {
                    Console.WriteLine("Parábéns! Sua nota foi " + respostaUsuario.ToString("N1"));

                    nota = true;

                } else 
                {
                    Console.WriteLine("Insira um valor válido!");
                }
             
            }
            
        }
    }
}
