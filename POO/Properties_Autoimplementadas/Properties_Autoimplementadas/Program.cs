using System;

namespace Properties_Autoimplementadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 600.00, 2);
            p.Nome = "Televisor";
            Console.WriteLine($"Produto {p.Nome}, têm {p.Quantidade} unidades, custando R$ {p.Preco}");
        }
    }
}
