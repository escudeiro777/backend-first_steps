using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Faça um programa que leia um nome de usuário e a sua senha e não
            //aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro
            //e voltando a pedir as informações.

            bool senha = false;
            while (senha == false)
            {
                Console.WriteLine("Digite seu login: ");
                string user = Console.ReadLine();
                Console.WriteLine("Digite sua senha: ");
                string password = Console.ReadLine();


                if (user != password)
                {
                    Console.WriteLine("Parábéns! Sua conta foi criada");
                    senha = true;

                } else
                {
                    Console.WriteLine("Insira uma senha válida!");
                }
            }

        }
    }
}
