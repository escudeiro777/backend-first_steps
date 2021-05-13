using System;

namespace DesafioPassagens
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] passagens = new string[5];
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];
            bool sair = false;
            bool voltar = false;
            int c = 0;

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

                    do
                    {
                        Console.WriteLine($@"
======================================================================
|                      O que você deseja fazer?                      |
|                                                                    |
| [1]Cadastrar passagens [2]Listar suas passagens [3]Sair do sistema |
======================================================================");

                        string opcaoUsuario = Console.ReadLine();
                        do
                        {
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

                                            Console.WriteLine("\nDados cadastrados! Você será redirecionado para a página inicial");
                                            voltar = true;
                                            c++;

                                        }
                                        else if (quantidadePassagens > 5)
                                        {
                                            Console.WriteLine("Número limite excedido. É permitido cadastrar somente 5 passagens por vez.");
                                            break;

                                        }
                                    }
                                    break;

                                //---------------------------------------------------------------------------------------------------------------------//

                                case "2":

                                    Console.WriteLine("Você já cadastrou alguma passagem? (S/N)");
                                    string respostaJunior = Console.ReadLine().ToUpper();

                                    if (respostaJunior == "S")
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine($@"
============================================
|            Dados das passagens           |
============================================
");

                                        for (var i = 0; i < c; i++)
                                        {
                                        Console.WriteLine($@"
Nome do passageiro: {nome[i]}
Local de origem: {origem[i]}
Destino: {destino[i]}
Data da viagem: {data[i]}"
                                           + "\n");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Primeiro você deve cadastrar seus dados na passagem!");
                                        Console.WriteLine("Redirecionando usuário para o Menu principal");
                                        voltar = true;
                                    }
                                    break;
                                //---------------------------------------------------------------------------------------------------------------------//
                                case "3":

                                Console.WriteLine("Você tem certeza que deseja sair do sistema? (S/N)");
                                respostaJunior = Console.ReadLine() .ToUpper();
                                if (respostaJunior == "S")
                                {
                                    Console.WriteLine("Tenha uma boa viagem! Até breve...");
                                    sair = true;
                                } else
                                {
                                    Console.WriteLine("Ebaaa! Voltaremos para o início do sistema para que você consiga escolher novas opções!");
                                    voltar = true;
                                }
                                    

                                break;
                            }

                        } while (voltar == false);
                    } while (sair == false);

                }
                else if (senha != "123456")
                {
                    Console.WriteLine("Senha inválida! Tente novamente");
                }
            }
        }
    }
}