using System;

namespace exemploRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
          for (var contador = 200; contador >= 100; contador--)
          {
              //contador --
              //contador = contador - 1  
              Console.WriteLine("Contador: " + contador);
          }
        }
    }
}
