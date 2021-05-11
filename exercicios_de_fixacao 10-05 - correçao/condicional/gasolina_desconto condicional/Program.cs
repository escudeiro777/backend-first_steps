using System;

namespace gasolina_desconto_condicional
{
    class Program
    {
        static void Main(string[] args)
        {

            double valorAlcool = 4.90;
            double valorGasosa = 5.30;
            int litros;
            bool condicao = false;

            do
            {

                Console.WriteLine("Seja bem-vindo ao posto DevGas! Qual combustível você deseja? \n Álcool [A] \n Gasolina[G]");
                string combustivel = Console.ReadLine().ToUpper();



                switch (combustivel)
                {
                    case "A":

                        Console.WriteLine($"Quantos litros de álcool você deseja?");
                         litros = int.Parse(Console.ReadLine());

                        if (litros <= 20)
                        {
                            Console.WriteLine($"O valor total a ser pago com desconto é R${((valorAlcool * 0.97) * litros).ToString("N2")}");
                        }
                        else
                        {
                            Console.WriteLine($"O valor total a ser pago com desconto é R${((valorAlcool * 0.95) * litros).ToString("N2")}");
                        }
                        condicao = true;
                        break;

                    case "G":
                        Console.WriteLine($"Quantos litros de gasolina você deseja?");
                        litros = int.Parse(Console.ReadLine());
                        if (litros <= 20)
                        {
                            Console.WriteLine($"O valor total a ser pago com desconto é R${((valorGasosa * 0.96) * litros).ToString("N2")}");
                        }
                        else
                        {
                            Console.WriteLine($"O valor total a ser pago com desconto é R${((valorAlcool * 0.94) * litros).ToString("N2")}");
                        }
                        condicao = true;
                        break;

                    default:
                        Console.WriteLine($"Opção Inválida! Tente novamente digitando outra opção.");
                        break;
                }
            } while (condicao == false);
        }
    }
}
