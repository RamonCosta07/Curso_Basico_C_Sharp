using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3]; // deve se colocar as linhas e colunas, nessa ordem
            Console.WriteLine(mat.Length); // quantos elementos a matriz tem no total
            Console.WriteLine(mat.Rank); // quantas linhas
            Console.WriteLine(mat.GetLength(0)); // imprimi primeira dimensão (linhas)
            Console.WriteLine(mat.GetLength(1)); // imprimi segunda dimensão (colunas)


        }
    }
}
