using System;

namespace desafio2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string checagem ="";
            do
            {
                Console.WriteLine("Qual a sua idade?: " + "\n" + "(obs: utilize apenas números ex:24)");
            int idadeDaPessoa = int.Parse(Console.ReadLine());

            if (idadeDaPessoa > 4 && idadeDaPessoa < 8)
            {
                Console.WriteLine("Sua categoria é: Infantil A");

            }if (idadeDaPessoa > 7 && idadeDaPessoa < 11)
            {
                Console.WriteLine("Sua categoria é: Infantil B");

            }if (idadeDaPessoa >10 && idadeDaPessoa < 14)
            {
                Console.WriteLine("Sua categoria é: Juvenil A");

            }if (idadeDaPessoa >13 && idadeDaPessoa <18)
            {
                Console.WriteLine("Sua categoria é: Juvenil B");

            }if (idadeDaPessoa >17)
            {
                Console.WriteLine("Sua categoria é: Sênior // Categoria pausada devido a pandemia");

            } if (idadeDaPessoa >0 && idadeDaPessoa <5)
            {
                Console.WriteLine("Categoria Inexistente");
            }

            Console.WriteLine ("Deseja selecionar outra idade?: (s/n)");
            checagem = Console.ReadLine();

            if (checagem == "n")
            {
                Console.WriteLine("Saindo do sistema...");
            }
           
            } while (checagem == "s");
            
        }
    }
}
