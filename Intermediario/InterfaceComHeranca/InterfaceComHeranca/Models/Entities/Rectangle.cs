using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComHeranca.Models.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Weight { get; set; }

        public override double Area()
        {
            return Width * Weight;
        }

        public override string ToString()
        {
            return $"Rectangle color: {Color}, " +
                $"Width = {Width.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Wigth = {Weight.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
