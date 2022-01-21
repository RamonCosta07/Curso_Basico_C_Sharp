using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1} cujo preço é $ {preco1}");
            Console.WriteLine("{0} cujo preço é $ {1}", produto2, preco2);
            Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e gênero {genero}");
            Console.WriteLine("\nMedia com oito casas decimais: " + media.ToString("F8"));
            Console.WriteLine($"Arredondado com 3 casas decimais: {media:f3}");
            Console.WriteLine("Separador decimal invariant culture: " + media.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
