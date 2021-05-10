using System;

namespace gasolina_desconto_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual combustível você deseja por?" + "\n" + "Gasolina [G] Álcool [A]");
            string combustivel = Console.ReadLine().ToUpper();

            string resposta;
            do
            {
                switch (combustivel)
                {
                    case "G":
                        Console.WriteLine("Quantos litros de gasolina você deseja colocar?");
                        int litrosGasolina = int.Parse(Console.ReadLine());
                        //double precoGasolina = 5.30 * litrosGasolina;

                        if (litrosGasolina <= 20)
                        {
                            Console.WriteLine($"Preço total a pagar: R${5.30 * litrosGasolina - 0.04}");
                        } else
                        {
                             Console.WriteLine($"Preço total a pagar: R${5.30 * litrosGasolina - 0.06}");
                        }
                        break;

                    case "A":
                        Console.WriteLine("Quantos litros de álcool você deseja colocar?");
                        int litrosAlcool = int.Parse(Console.ReadLine());
                        //double descontoAlcool = 4.90 * 0.03;
                        //double total = (litrosAlcool * 4.90);
                        if (litrosAlcool <= 20)
                        {
                            //Console.WriteLine($"O total foi: {total}");
                            //Console.WriteLine($"O desconto foi de {total}")
                            Console.WriteLine($"Preço total a pagar: R${4.90 * litrosAlcool - 0.03}");

                        } else
                        {
                            Console.WriteLine($"Preço total a pagar: R${4.90 * litrosAlcool - 0.05}");
                        }
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Deseja abastecer outro veículo? (S/N)");
                resposta = Console.ReadLine().ToUpper();

            } while (resposta == "S");

            if (resposta == "N")
            {
                Console.WriteLine("Obrigada pela preferência!");
            }
        }
    }
}
