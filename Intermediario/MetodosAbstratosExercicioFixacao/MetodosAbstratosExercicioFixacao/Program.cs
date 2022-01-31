using System;
using System.Globalization;
using System.Collections.Generic;
using MetodosAbstratosExercicioFixacao.Entities;

namespace MetodosAbstratosExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayers> list = new List<Taxpayers>();
            double sum = 0.0;

            Console.Write("Enter the number os tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data: ");
                Console.Write("Individual or company (i/c): ");
                char ch = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double annual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, annual, health));
                } else if (ch == 'C')
                {
                    Console.Write("Number of Employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, annual, employees));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Taxes Paid: ");
            foreach(Taxpayers item in list)
            {
                Console.WriteLine(item.ToString());
                sum += item.Tax();
            }
            Console.WriteLine($"\nTotal Taxes: R$ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
