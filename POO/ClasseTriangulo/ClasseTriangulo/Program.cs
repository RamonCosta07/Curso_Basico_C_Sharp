using System;
using System.Globalization;

namespace ClasseTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo(); // quando se trata de classe, precisa-se instancia-la
            y = new Triangulo(); // objetos são instâncias da classe

            Console.WriteLine("Entre com as medidas do Triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\nEntre com as medidas do Triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Area de X é = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine($"Area de Y é = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("A maior area é a do Triângulo X");
            }
            else
            {
                Console.WriteLine("A maior area é a do Triângulo Y");
            }
        }
    }
}
