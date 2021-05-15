using System;

namespace exemploRepeticao_While
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta = false;
            
            while (respostaCorreta == false)
            {
                Console.WriteLine("Qual a idade de Paulo?: ");
                string resposta = Console.ReadLine();

                if (resposta == "32")
                {
                    Console.WriteLine("Parabéns, você é uma Paulete! By Kauê");
                    respostaCorreta = true;
                }else {
                    Console.WriteLine("você não6 é um verdadeiro fã do PAULO BRANDÃO! By Kauê");
                }
            }
        }
    }
}
