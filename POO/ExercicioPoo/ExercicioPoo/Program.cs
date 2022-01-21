using System;
using System.Globalization;

namespace ExercicioPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1;
            double saldo;

            Console.Write("Entre com o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? [s/n]: ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta1 = new ContaBancaria(nome, conta, saldo);
            } else
            {
                conta1 = new ContaBancaria(nome, conta);
            }
            Console.WriteLine();
            Console.WriteLine(conta1);
            Console.WriteLine();

            Console.Write("Entre com o valor do depósito: ");
            saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Deposito(saldo);
            Console.WriteLine("\nDados da conta atualizados:\n" + conta1);

            Console.WriteLine();
            Console.Write("Entre com o valor do saque: ");
            saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Saque(saldo);
            Console.WriteLine("\nDados da conta atualizados:\n" + conta1);

        }
    }
}
