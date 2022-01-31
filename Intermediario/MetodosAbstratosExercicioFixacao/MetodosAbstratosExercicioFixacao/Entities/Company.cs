using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstratosExercicioFixacao.Entities
{
    class Company : Taxpayers
    {
        public int Employees { get; set; }

        public Company(string name, double annualIncome, int employees) :
           base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            if (Employees > 10)
            {
                return (AnnualIncome/100) * 14;
            } else
            {
                return (AnnualIncome/100) * 16;
            } 
        }
    }
}
