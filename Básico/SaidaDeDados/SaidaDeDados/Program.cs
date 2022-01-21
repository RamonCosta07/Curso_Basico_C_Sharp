using System;
using System.Globalization; // para poder utilizar . invés de , no numero decimal 

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo = 10.34821;
            string nome = "Maria";
            int idade = 19;

            Console.WriteLine("Olá"); // write line tem quebra de linha
            Console.Write("Sem a quebra de linha..."); // não tem quebra de linha
            Console.WriteLine(" Viu só?"); // pode usar \n pra pular linha tb
            Console.WriteLine("-----------------------");
            Console.WriteLine(saldo.ToString("F2")); // para controlar o numero de casas decimais
            Console.WriteLine(saldo.ToString("F3"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // exibir como ponto
            Console.WriteLine("-----------------------");

            Console.WriteLine("{0} tem {1} anos e tem {2:f2} reais na conta", nome, idade, saldo); // placeholders
            Console.WriteLine($"{nome} tem {idade} anos e tem {saldo:f2} reais na conta"); // interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais na conta"); // concatenação
        }
    }
}
