using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "João", "Mauro", "Rau"};
            foreach (string obj in vect) // obj é um apelido para cada elemento do vetor
            {
                Console.WriteLine(obj);
            }
        }
    }
}
