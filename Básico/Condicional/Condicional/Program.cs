using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;

            Console.WriteLine("Bom dia");

            if (x > 10)
            {
                Console.WriteLine("Boa tarde, na verdade");
            }
            
            Console.WriteLine("Boa noite");
            Console.WriteLine("*******************");
            Console.WriteLine("Entre com um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"\n{numero} é par");
            } else
            {
                Console.WriteLine($"\n{numero} é impar");
            }
            Console.WriteLine("******************");

            Console.WriteLine("Agora digite uma letra: ");
            string letra = Console.ReadLine();

            if(letra == "s")
            {
                Console.WriteLine(letra);
            } else if (letra == "t") {
                Console.WriteLine(letra);
            } else if (letra == "a")
            {
                Console.WriteLine(letra);
            } else
            {
                Console.WriteLine($"A letra que você digitou foi '{letra}'");
            }
        }
    }
}
