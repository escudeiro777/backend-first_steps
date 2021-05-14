using System;

namespace _12._05__Projeto_Passagens_Aéreas___correção
{
    class Program
    {
        static void Main(string[] args)
        {

            string senha;
            string senhaCorreta = "123456";
            bool condicao = false;
            string resposta = "s";
            int tamanhoArray = 5;
            int c = 0;

            string[] nomes = new string[tamanhoArray];
            string[] origem = new string[tamanhoArray];
            string[] destino = new string[tamanhoArray];
            string[] datas = new string[tamanhoArray];

            Console.WriteLine("Seja bem-vindo ao DeViagens");

            do
            {
                Console.WriteLine("Digite sua senha para efetuar o login:");
                senha = Console.ReadLine();

                if (senha == senhaCorreta)
                {
                    Console.WriteLine("Senha correta \nLogin efetuado com sucesso");

                    do
                    {
                        MostrarMenu();
                        string opcao = Console.ReadLine();

                        string opcaoMenu = MostrarMenuComRetorno();

                        switch (opcaoMenu)
                        {
                            case "1":

                                do
                                {
                                    if (c <= tamanhoArray)
                                    {

                                        Console.WriteLine("Digite o nome do passageiro:");
                                        nomes[c] = Console.ReadLine();

                                        Console.WriteLine("Digite a origem do passageiro:");
                                        origem[c] = Console.ReadLine();

                                        Console.WriteLine("Digite o destino do passageiro:");
                                        destino[c] = Console.ReadLine();

                                        Console.WriteLine("Digite a data do voo:");
                                        datas[c] = Console.ReadLine();

                                        Console.WriteLine("Passagem cadastrada!");
                                        Console.WriteLine("Deseja cadastrar outra passagem?(S/N)");
                                        resposta = Console.ReadLine();
                                        c++;

                                    }
                                    else
                                    {
                                        Console.WriteLine("Quantidade de passagens excedida.");
                                    }

                                } while (resposta == "s");

                                break;

                            case "2":
                                Console.WriteLine("Nome       Origem        Destino      Data");
                                for (var i = 0; i < c; i++)
                                {
                                    Console.WriteLine($"{nomes[i]}         {origem[i]}            {destino[i]}       {datas[i]}");
                                }

                                break;

                            case "0":
                                Console.WriteLine("Obrigado por utilizar nosso sistema! Até breve");
                                condicao = true;
                                break;

                            default:
                                Console.WriteLine("Opção Inválida. Digite novamente.");
                                break;
                        }
                    } while (!condicao);

                }
                else
                {
                    Console.WriteLine("Senha Icorreta.");
                }

            } while (senha != senhaCorreta);
        }

        static void MostrarMenu()
        {
            Console.WriteLine(@"
======================================                    
|   Selecione uma das opções abaixo  |                   
| ---------------------------------- |
|        1- Cadastrar                |
|        2- Listar passagens         |
|        0 -Sair                     |
======================================"
);
        }
        static string MostrarMenuComRetorno()
        {
            Console.WriteLine(@"
======================================                    
|   Selecione uma das opções abaixo  |                   
| ---------------------------------- |
|        1- Cadastrar                |
|        2- Listar passagens         |
|        0 -Sair                     |
======================================"
);
string opcao = Console.ReadLine();
return opcao;
        }
    }
}
