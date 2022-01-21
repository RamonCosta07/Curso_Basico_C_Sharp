using System;

namespace ParametrosRefEOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Com o Ref, você é obrigado a variável seja
             * inciada com algum valor. Porém, com o OUT
             * isso não é preciso.
             */
            int a = 10;
            int b;
            Calculadora.Triple(ref a); // precisa chamar com o Ref também
            Console.WriteLine(a);
            Calculadora.Duplic(a, out b); // irá guardar o valor de "a" dobrado em "b"
            Console.WriteLine(b);

        }
    }
}
