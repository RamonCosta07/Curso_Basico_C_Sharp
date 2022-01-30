using HerancaExercicioFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourced == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valueHour, additionalCharge));
                } else
                {
                    list.Add(new Employee(name, hours, valueHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach(Employee e in list)
            {
                Console.WriteLine($"{e.Name} - R$ {e.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
