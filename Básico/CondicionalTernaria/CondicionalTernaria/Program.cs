using System;
using System.Globalization;

namespace CondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número double: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            //se a condição for verdadeira, ele executa o da esquerda
            //se for falsa, ele executa o comando da direita
            Console.WriteLine(desconto.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
