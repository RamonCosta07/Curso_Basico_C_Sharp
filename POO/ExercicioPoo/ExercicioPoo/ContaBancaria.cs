using System;
using System.Globalization;

namespace ExercicioPoo
{
    class ContaBancaria
    {
        public string Nome { get; set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; } // Pois só irá ser alterado, através dos métodos

        public ContaBancaria(string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
        }
        public ContaBancaria(string nome, int conta, double depositoInicial) : this(nome, conta)
        {
            Deposito(depositoInicial); //Mais contigente deixar tudo relacionado a depósito no método
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            quantia += 5;
            Saldo -= quantia;
        }

        public override string ToString()
        {
            return "Dados da conta:\nConta: " + Conta
                + ", Titular: " + Nome
                + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
