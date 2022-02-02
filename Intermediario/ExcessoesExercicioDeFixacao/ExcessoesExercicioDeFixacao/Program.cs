using ExcessoesExercicioDeFixacao.Entities;
using ExcessoesExercicioDeFixacao.Exceptions;
using System;
using System.Globalization;

namespace ExcessoesExercicioDeFixacao
{
    /* Programa que le os dados de uma conta bancária
     * e depois realiza um saque dessa conta. Um saque
     * não pode ocorrer se não houver saldo suficiente,
     * ou se o valor do saque for superior ao limite
     * de saque da conta
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account test = new Account(number, name, balance, withdraw);
                Console.Write("\nEnter amount for withdraw: R$ ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                test.Withdraw(amount);
                Console.WriteLine($"New Balance: R$ {test.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw error! {e.Message}");
            } catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message); // Para qualquer outro erro
            }


        }
    }
}
