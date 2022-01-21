using System;

namespace MatrizExercicioDeFixacaoDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite as linhas e colunas da sua matriz: ");
            string[] vet = Console.ReadLine().Split(" ");
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);
            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite os valores da linha #" + i + ": ");
                string[] temporario = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(temporario[j]);
                }
            }
            Console.Write("\nDigite um número que você quer verificar na matriz: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    if(x == mat[i, j])
                    {
                        Console.WriteLine($"Posição: {i}, {j}");
                        if(j > 0)
                        {
                            Console.WriteLine($"Esquerda: {mat[i, j - 1]}");
                        }
                        if(j < n - 1)
                        {
                            Console.WriteLine($"Direita: {mat[i,j+1]}");
                        }
                        if(i > 0)
                        {
                            Console.WriteLine($"Emcima: {mat[i-1, j]}");
                        }
                        if(i < m - 1)
                        {
                            Console.WriteLine($"Embaixo: {mat[i+1, j]}");
                        }
                    }
                }
            }
        }
    }
}
