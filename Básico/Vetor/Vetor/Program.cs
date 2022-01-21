using System;
using System.Globalization;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas posições terá o seu vetor: ");
            int n = int.Parse(Console.ReadLine());
            double[] vetorzinho = new double[n]; //sempre se inicia com o tipo de variavel do vetor
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite a altura: ");
                vetorzinho[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double media = 0.0;
            for (int i = 0; i < n; i++)
            {
                media += vetorzinho[i];
            }

            media = media / n;
            Console.WriteLine("A média das alturas é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
