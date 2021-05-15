using System;

namespace _13._05___Exercício___Sistema_de_Produtos
{
    class Program
    {

        static int tamanhoArray = 10;
        static string[] nomeProduto = new string[tamanhoArray];
        static float[] preco = new float[tamanhoArray];
        static int c = 0;
        static bool[] promocao = new bool[tamanhoArray];
        static bool voltarMenu = false;
        static bool novoCadastro = false;

        static void Main(string[] args)

        {
            Console.WriteLine("\nBem vindo ao mercado DEVorar! Selecione como prosseguir:");



            do
            {
                MostrarMenu();
                string opcaoMenu = Console.ReadLine();

                switch (opcaoMenu)
                {
                    case "1":
                        Console.WriteLine($"O máximo de produtos que se pode cadastrar é: {tamanhoArray}.");
                        novoCadastro = true;
                        CadastrarProduto();
                        break;

                    case "2":
                        ListarProdutos();
                        break;

                    case "3":
                        Console.WriteLine("Quantos produtos a mais você deseja adicionar?");
                        AumentarQuantidadeProduto();
                        break;

                    case "4":
                        Console.WriteLine("Obrigado por utilizar nosso sistema! Até a próxima");
                        voltarMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        voltarMenu = true;
                        break;
                }

            } while (voltarMenu);
        }

        //------------------------------------funções-------------------------------------------//

        static void MostrarMenu()
        {
            Console.WriteLine($@"
======================================                    
|                MENU                |                   
| ---------------------------------- |
|    1| Cadastrar produtos           |
|    2| Listar produtos cadastrados  |
|    3| Aumentar a lista de produtos |
|    4| Sair do sistema              |
======================================");
        }

        static void CadastrarProduto()
        {
            do
            {
                if (c < tamanhoArray)
                {
                    Console.WriteLine($"Digite o nome do {c + 1}º produto:");
                    nomeProduto[c] = Console.ReadLine();

                    Console.WriteLine("Digite o preço do produto: R$");
                    preco[c] = float.Parse(Console.ReadLine());

                    Console.WriteLine($"O produto está em promoção? (S/N)");
                    string respostaPromocao = Console.ReadLine().ToUpper();
                    if (respostaPromocao == "S")
                    {
                        Console.WriteLine("Cadastramos a promoção. Obrigado!");
                        promocao[c] = true;
                    }
                    else
                    {
                        promocao[c] = false;
                    }

                    Console.WriteLine("Produto cadastrado!");
                    Console.WriteLine("Deseja cadastrar outro produto?(S/N)");
                    string respostaNovoCadastro = Console.ReadLine().ToUpper();
                    if (respostaNovoCadastro == "S")
                    {
                        novoCadastro = true;
                    }
                    else if (respostaNovoCadastro == "N")
                    {
                        novoCadastro = false;
                        voltarMenu = true;
                    }
                    c++;
                }
                else
                {
                    Console.WriteLine("Você já atingiu o número máximo de cadastros produtos\nPor gentileza, selecione a opção 3.");
                    novoCadastro = false;
                    voltarMenu = true;

                }

            } while (novoCadastro);

        }

        static void ListarProdutos()
        {
            for (var i = 0; i < c; i++)
            {
                {
                    Console.WriteLine($@"
===========================================================                
|                   PRODUTOS CADASTRADOS                  |
|=========================================================|
                    Dados do {i + 1}° produto                               
   -> Nome do produto: {(nomeProduto[i])}                                      
   -> Preço: R${(preco[i])}                                         
   -> {(promocao[i] ? "Este produto está em promoção." : "Este produto não está em promoção.")}                   
===========================================================
                ");
                }
            }
        }
        static void AumentarQuantidadeProduto()
        {
            int quantidadeProdutoAumentada = int.Parse(Console.ReadLine());
            tamanhoArray = quantidadeProdutoAumentada;
            Array.Resize(ref nomeProduto, tamanhoArray);
            Array.Resize(ref preco, tamanhoArray);
            Array.Resize(ref promocao, tamanhoArray);
        }
    }
}