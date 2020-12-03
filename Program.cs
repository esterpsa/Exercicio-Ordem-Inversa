using System;

namespace Exercicio_Inverso
{
    class Program
    {
        static void Main(string[] args)
        {
            int []numeros = new int [15];

            Console.WriteLine("Números");
            Console.WriteLine("-------------------");

            for(var contador = 0; contador <15; contador++){
                Console.WriteLine($"Informe o {contador+1}º número");
                numeros[contador] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Ordem Original");
        
            for(var contador = 0; contador < numeros.Length; contador++){
                Console.WriteLine(numeros[contador]);
            }

            Array.Reverse(numeros);

            Console.WriteLine("Ordem Inversa");
            Console.WriteLine("-------------------");

            for(var contador = 0; contador < numeros.Length; contador++){
                Console.WriteLine(numeros[contador]);
            }
        }
    }
}
