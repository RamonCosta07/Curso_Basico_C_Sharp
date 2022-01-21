using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
  

            Console.WriteLine("Entre com o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos você tem: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Por fim, escreva seu ultimo nome, idade e altura (mesma linha):");
            
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture); 


            //sobrenome = Console.ReadLine();
            //idade = int.Parse(Console.ReadLine());
            //altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Saída de dados: {nome} {sobrenome}");
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
