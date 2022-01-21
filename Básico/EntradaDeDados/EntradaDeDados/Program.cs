using System;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            
            string[] vet = Console.ReadLine().Split(' '); // vetor de palavra, espaço em branco vai reconhecer
            // cada espaço como uma posição diferente do vetor
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            int n1 = int.Parse(Console.ReadLine()); // tudo é lido como string, então tem que converter
          

            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine("Você digitou: " + x);
            Console.WriteLine("Você digitou: " + y);
            Console.WriteLine("Você digitou: " + z);
            Console.WriteLine($"Você digitou: {a}");
            Console.WriteLine($"Você digitou: {b}");
            Console.WriteLine($"Você digitou: {c}");
            Console.WriteLine("****************");
            Console.WriteLine($"Você digitou: {n1}");
            
        }
    }
}
