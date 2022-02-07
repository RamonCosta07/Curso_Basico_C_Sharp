using System;
using InterfaceComHeranca.Models.Entities;
using InterfaceComHeranca.Models.Entities.Enums;

namespace InterfaceComHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.Black };
            IShape s2 = new Rectangle() { Width = 3.5, Weight = 4.2, Color = Color.White };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
