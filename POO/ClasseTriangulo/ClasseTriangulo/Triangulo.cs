using System;

namespace ClasseTriangulo
{
    class Triangulo // nome de Classe começa com Letra Maiúscula
    {
        public double A; // nome de Atributo começa com Letra Maiúscula
        public double B; // public pode ser acessado em outro arquivo
        public double C;

        public double Area()
        { // método é uma função dentro da classe. O tipo é o que ele retorna 
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
