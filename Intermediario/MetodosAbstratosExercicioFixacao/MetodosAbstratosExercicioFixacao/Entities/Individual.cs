using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstratosExercicioFixacao.Entities
{
    class Individual : Taxpayers
    {
        public double Health_Expenses { get; set; }

        public Individual(string name, double annualIncome, double health_Expenses) : 
            base (name, annualIncome)
        {
            Health_Expenses = health_Expenses;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000.00 && Health_Expenses == 0)
            {
                return AnnualIncome * 0.15;
            }
            else if (AnnualIncome < 20000 && Health_Expenses > 0)
            {
                return (AnnualIncome * 0.15) - (Health_Expenses / 2);
            }
            else if (AnnualIncome > 20000.00 && Health_Expenses == 0)
            {
                return AnnualIncome * 0.25;
            }
            else
            {
                return (AnnualIncome * 0.25) - (Health_Expenses / 2);
            }
        }
    }
}
