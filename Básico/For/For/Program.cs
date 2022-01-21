using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int digito, cont = 0;
            Console.Write("Quantos numeros você vai querer digitar: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor #" + i + ": ");
                digito = int.Parse(Console.ReadLine());
                cont += digito;
            }
            Console.Write("\nA soma é: " + cont);
        }
    }
}
