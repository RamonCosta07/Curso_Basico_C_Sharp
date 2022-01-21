using System;

namespace ExerciciosClasses1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Console.Write("Digite o nome da Primeira Pessoa: ");
            p1.nome = Console.ReadLine();
            Console.Write("Digite a idade da Primeira Pessoa: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o nome da Segunda Pessoa: ");
            p2.nome = Console.ReadLine();
            Console.Write("Digite a idade da Segunda Pessoa: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine($"A pessoa mais velha é: {p1.nome}");
            } else
            {
                Console.WriteLine($"A pessoa mais velha é: {p2.nome}");
            }


        }
    }
}
