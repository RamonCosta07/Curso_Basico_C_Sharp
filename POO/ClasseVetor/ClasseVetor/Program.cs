using System;
using System.Globalization;

namespace ClasseVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];
            Console.WriteLine();
            /* Por se tratar de um vetor de uma classe
             * será preciso instanciar cada um dos elementos
             * do vetor
             */
            double media = 0.0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Name = name, Preco = preco };
                media += vect[i].Preco;
                Console.WriteLine();
            }
            media = media / n;
            Console.WriteLine();
            Console.WriteLine("Média de preço dos produtos: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
