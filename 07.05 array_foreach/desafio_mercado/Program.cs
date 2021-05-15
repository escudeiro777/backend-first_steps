using System;

namespace desafio_mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba a quantidade de produtos que o usuário deseja cadastrar, os nomes dos produtos, a quantidade de cada produto, o valor de cada um e mostre na tela em formato de tabela
            //---------------------------------------------------------------------------------------------

            Console.WriteLine("Quantos produtos você deseja cadastrar?: ");

            //informação que sera armazenada no array

            int[] produto = null;
            int quantidadeProdutos = int.Parse(Console.ReadLine());
            produto = new int[quantidadeProdutos];

            Console.WriteLine("Insira o nome de cada produto: ");
            string[] nome = new string[quantidadeProdutos]; //estava errando aqui
            //nomeará os produtos a partir da quantidade dele
            for (var i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine("Nome do " + (i + 1) + "° produto");
                nome[i] = (Console.ReadLine());

            }

            int[] quantidadeCada = new int[quantidadeProdutos]; //estava errando aqui
            for (var i = 0; i < quantidadeProdutos; i++)

            {
                Console.WriteLine("Qual a quantidade do " + (i + 1) + "° produto que você pegou?");
                quantidadeCada[i] = int.Parse(Console.ReadLine());
            }

            double[] valor = new double[quantidadeProdutos]; //estava errando aqui
            //dará valor aos produtos

            for (var i = 0; i < quantidadeProdutos; i++)

            {
                Console.WriteLine("Valor do " + (i + 1) + "° produto");
                valor[i] = double.Parse(Console.ReadLine());
            }

            //---------------------------------foreachs--------------------------------------//
            
            int qp = 1;
            foreach (var item in produto)
            {
                //Console.WriteLine(item);
                qp++;
            }

            int n = 1;
            foreach (var item in nome)
            {
                //Console.WriteLine(item);
                n++;
            }

            int v = 1;
            foreach (var item in valor)
            {
                //Console.WriteLine(item);
                v++;
            }

            int qc = 1;
            foreach (var item in quantidadeCada)
            {
                //Console.WriteLine(item);
                qc++;
            }
//------------------------------------Fazer Tabela-----------------------------------------//
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($@"
            ============================================
            !   Nome        Quantidade         Valor   !
            !==========================================!");

            for (var i = 0; i < quantidadeProdutos; i++)
            {
            Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@$"
            !   {nome[i]}           {quantidadeCada[i]}               {valor[i]}  
            ===========================================        
                                                                                                                   
            ");
            }
           


        }
    }
}
