using InterfaceComHeranca.Models.Entities.Enums;

namespace InterfaceComHeranca.Models.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area(); // Continua sendo abstrato, pois não foi implementado
    }
}
