using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Faça um programa que leia e valide as seguintes informações:
            //• Nome: diferente de vazio;
            //• Idade: entre 0 e 150;
            //• Salário: maior que zero;
            //• Estado Civil: &#39;s&#39;(solteiro(a)), &#39;c&#39;(casado(a)), &#39;v&#39;(viuvo(a)),
            //&#39;d&#39;(divorciado(a));


            bool validacao = false;

            string nome = "";

            do
            {
                Console.WriteLine("Qual o seu nome?");
                nome = Console.ReadLine();
                if (nome == "")
                {
                    Console.WriteLine("Insira um nome válido.");
                }
                else
                {
                    Console.WriteLine("Nome validado.");
                    validacao = true;
                }

            } while (validacao == false);

            
            int idade;

            do
            {
                Console.WriteLine("Qual sua idade?");
                idade = int.Parse(Console.ReadLine());
                if (idade >= 0 && idade <= 150)
                {
                    Console.WriteLine("Idade validada.");
                    validacao = true;
                   
                }
                else
                {
                    Console.WriteLine("Idade Inválida.");
                     validacao = false;
                }

            } while (validacao == false);


            double salario;

            do
            {
                Console.WriteLine("Qual seu salário?");
                salario = double.Parse(Console.ReadLine());
                if (salario > 0)
                {
                    Console.WriteLine("Salário Validado: " + salario.ToString("N1"));
                    validacao = true;
                   
                }
                else
                {
                    Console.WriteLine("Salário Inválido.");
                     validacao = false;
                }

            } while (validacao == false);


            string estadoCivil;

            do
            {
                Console.WriteLine("Qual seu estado civil?");
                estadoCivil = Console.ReadLine() .ToLower();
                if (estadoCivil == "s" || estadoCivil == "c" || estadoCivil == "d" || estadoCivil == "v" )
                {
                    Console.WriteLine("Estado Civíl validado.");
                    Console.WriteLine("Todas as informações foram válidas! Parabéns.");
                    validacao = true;
                   
                }
                else
                {
                    Console.WriteLine("Estado Civíl inválido.");
                     validacao = false;
                }

            } while (validacao == false);

        }
    }
}
