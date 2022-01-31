using System;
using System.Globalization;

namespace MetodosAbstratosExercicioFixacao.Entities
{
    abstract class Taxpayers
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        protected Taxpayers(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return $"{Name}: R$ {Tax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
