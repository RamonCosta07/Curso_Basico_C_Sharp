using System;

namespace ExercicioVetorClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] registro = new Aluguel[10];
            Console.WriteLine("*- Bem vindo a Pensão da Dona Maria! *-");
            Console.Write("Quantos estudantes irão se registrar na pensão? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("************");
                Console.WriteLine("Aluguel #" + i);
                Console.Write("Me fale o seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("Agora me diga seu e-mail: ");
                string email = Console.ReadLine();
                Console.Write("Qual quarto deseja alugar: ");
                int quarto = int.Parse(Console.ReadLine());
                registro[quarto] = new Aluguel { Nome = nome, Email = email, Quarto = quarto };

            }

            Console.WriteLine();
            Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < 9; i++)
            {
                if (registro[i] != null)
                {
                    Console.WriteLine(registro[i].Quarto + ": " + registro[i]);
                }
            }
        }
    }
}
