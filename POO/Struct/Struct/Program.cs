using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Struct já cria o valor dentro da caixinha
             * Sem necessidade de se criar um ponteiro
             * apontando para o endereço da memória.
             */

            Point p; // instanciar uma struct
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point(); // zerar o valor da struct
            Console.WriteLine(p);
        }
    }
}
