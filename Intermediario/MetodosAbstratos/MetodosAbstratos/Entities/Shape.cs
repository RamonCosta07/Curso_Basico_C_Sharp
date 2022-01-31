using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area(); //Classes com métodos abstratos precisam serem abstratas também
    }
}
