using System;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctrl + f5 compila e executa
            bool r = true;
            char genero = 'F';
            float n5 = 4.5f; // pra que um float funcione, e n ser interpretado como double, colocar f
            double n6 = 5.4;
            string nome = "Ramon Costa"; // string é aspas duplas. Não pode ser mudado
            int n1 = int.MinValue; // menor valor aceito por int
            int n2 = int.MaxValue; // maior valor aceitor por int. Pode ser usado com tipos de variavel

            Console.WriteLine(r); // Digita CW + tab 2 vezes que ele preenche o console write sozinho
            Console.WriteLine(genero);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
    }
}


