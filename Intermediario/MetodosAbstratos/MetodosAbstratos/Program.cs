using MetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c): ");
                char shape = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Color (Black/Blue/Red): ");

                Color color = Enum.Parse<Color>(Console.ReadLine());
                //Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

                if (shape == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Entities.Rectangle(color, width, height));
                } else if (shape == 'C')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Entities.Circle(color, radius));
                }
            }

            Console.WriteLine("\nShape Areas: ");
            foreach(Shape i in list)
            {
                Console.WriteLine(i.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}
