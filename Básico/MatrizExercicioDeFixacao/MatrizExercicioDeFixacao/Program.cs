using System;

namespace MatrizExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            Console.WriteLine();
            for (int i = 0; i < n; i++) // irá percorrer as linhas
            {
                Console.Write("Digite os valores da linha #" + i + ": ");
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) // percorre as colunas, para cada linha = n
                {
                    mat[i, j] = int.Parse(valores[j]); // converte os valores do vetor valores em int
                }
            }
            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{mat[i,i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Número negativos na matriz: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(mat[i, j] < 0)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }
        }
    }
}
