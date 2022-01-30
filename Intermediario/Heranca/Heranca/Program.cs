using System;
using Heranca.Entities;
using System.Globalization;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1000, "Alex", 25);
            BusinessAccount bacc = new BusinessAccount(1001, "Ltda", 2000.5, 5000.0);

            //Upcasting (Conversão da SubClasse para SuperClasse)
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Empresa", 100, 200);
            Account acc3 = new SavingsAccount(1004, "Ana", 200, 0.1);

            //Downcasting (Conversão da SuperClasse para SubClasse
            BusinessAccount acc4 = (BusinessAccount)acc2;

            if (acc3 is BusinessAccount) // Se a variavel acc3 for instancia de BusinessAccount
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            } else
            {
                Console.WriteLine("Não são compatíveis para conversão");
            }
            Console.WriteLine();
            Console.WriteLine($"Saldo da conta corrente R$ {acc.Balance}");
            acc.Withdraw(5.0);
            Console.WriteLine($"Saldo da Conta Corrente após sacar 5 reais: R$ {acc.Balance}");
            Console.WriteLine($"\nSaldo da conta Poupança R$ {acc3.Balance}");
            acc3.Withdraw(5.0);
            Console.WriteLine($"Saldo da conta Poupança após sacar 5 reais: R$ {acc3.Balance}");
        }
    }
}
