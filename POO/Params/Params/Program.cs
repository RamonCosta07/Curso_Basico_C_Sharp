using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Sum(new int[] {2, 3, 8}); // Antes de usar o Params
            int s2 = Calculadora.Sum(5, 6, 8); // após usar o Params no Método da Classe
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
