using PolimorfismoExercicioFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace PolimorfismoExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c, u, i): ");
                char productType = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(productType == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customFee));
                } else if (productType == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else if (productType == 'C')
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags: ");
            foreach(Product item in list)
            {
                Console.WriteLine(item.priceTag());
            }
        }
    }
}
