using System;

namespace Nullable
{
    class Program
    {
             /* Nullable permite que possa ser
             * atribuido valores nulos em C#
             * (por padrão não é possível em C#)
             */
        static void Main(string[] args)
        {
            Nullable<double> x = null;
            double? y = 10.0; // outra forma de se escrever, uma vez que a variavel é opcional

            /* Get Value or default vai pegar o valor de X
             * Caso o valor não exista, ele vai pegar o
             * valor padrão da variável X (que seria 0
             * para double)
             */
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine("*****************");

            Console.WriteLine(x.HasValue); // VERIFICAR se existe um valor dentro da variavel X
            Console.WriteLine(y.HasValue);
            Console.WriteLine("*****************");

            if (x.HasValue)
            {
                Console.WriteLine(x.Value); // só vai imprimir se não for nulo
            }
            else
            {
                Console.WriteLine("X is null");
            }
            Console.WriteLine(y.Value);
            Console.WriteLine("*****************");

            double a = x ?? 5; // operador de coalescência nula
            /* Se o valor de x não for nulo, a recebe o valor de x
             * Mas, se valor de x for nulo, a passa a receber o
             * valor da direita do ponto de interrogação (5)
             */
            double b = y ?? 20;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
