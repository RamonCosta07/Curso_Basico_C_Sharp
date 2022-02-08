using System;
using System.IO;
using System.Collections.Generic;
using InterfaceComparable.Entities;

namespace InterfaceComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); // Esse método ordena a lista
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            } catch (IOException e)
            {
                Console.WriteLine($"An error ocurred {e.Message}");
            }
        }
    }
}
