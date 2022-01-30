using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExercicioFixacao.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour,
            double additionalCharge) : base (name, hours, valuePerHour)
        {
            this.AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }
    }
}
