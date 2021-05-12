using System;

namespace _12._05__Projeto_Passagens_Aéreas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem-vindo novamente à agência DeViagens!");

            bool validacaoCorreta = false;
            while (validacaoCorreta == false)
            {
                Console.WriteLine("Insira sua senha para efetuar o login:");
                string senha = Console.ReadLine();

                if (senha == "123456")
                {
                    Console.WriteLine("\nLogin efetuado com sucesso!");
                    validacaoCorreta = true;

                    //-----------------------------------------senha feito--------------------------------------------//


                    string[] passagens = new string[4];
                    string[] nome = new string[4];
                    string[] origem = new string[4];
                    string[] destino = new string[4];
                    string[] data = new string[4];
                    bool cadastroMenu = false;
                    int c = 0;
                    do
                    {
                        Console.WriteLine($@"
======================================================================
|                      O que você deseja fazer?                      |
|                                                                    |
| [1]Cadastrar passagens [2]Listar suas passagens [3]Sair do sistema |
======================================================================");

                        string opcaoUsuario = Console.ReadLine();

                        switch (opcaoUsuario)
                        {
                            case "1":
                                Console.WriteLine("Quantas passagens você deseja cadastrar? O número máximo de passagens que se pode cadastrar é 5.");
                                int quantidadePassagens = int.Parse(Console.ReadLine());

                                passagens = new string[quantidadePassagens];

                                for (var i = 0; i < quantidadePassagens; i++)
                                {
                                    if (quantidadePassagens <= 5)
                                    {
                                        Console.WriteLine("Dados da " + (i + 1) + "° passagem: ");

                                        Console.WriteLine("Insira seu nome completo: ");
                                        nome[i] = Console.ReadLine();

                                        Console.WriteLine("Insira seu local de origem: ");
                                        origem[i] = Console.ReadLine();

                                        Console.WriteLine("Insira seu destino: ");
                                        destino[i] = Console.ReadLine();

                                        Console.WriteLine("Insira a data do seu voo: ");
                                        data[i] = Console.ReadLine();
                                        c++;

                                    }
                                    else if (quantidadePassagens > 5)
                                    {
                                        Console.WriteLine("Número limite excedido. É permitido cadastrar somente 5 passagens por vez.");
                                        break;
                                    }

                                }

                                break;

                            case "2":
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine($@"
============================================
|            Dados das passagens           |
============================================
");

                                for (var i = 0; i < c; i++)
                                {
                                    Console.WriteLine($@"
Nome do passageiro: {nome[c]}
Local de origem: {origem[c]}
Destino: {destino[c]}
Data da viagem: {data[c]}"
                                   + "\n");
                                }
                                break;
                        }

                    } while ( cadastroMenu == true);
               
                } else if (senha != "123456")
                    {
                        Console.WriteLine("Senha inválida! Tente novamente");
                    }
            }
        }
    }
}