using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Para manter a integridade dos dados
             *  Evitando que o programador possa adicionar
             *  valores nos atributos sem acesso aos métodos
             *  é usado o Encapsulamento, para evitar que isso ocorra
             *  O encapsulamento assegura que mantem o estado consistente
             *  do seu objeto, conforma a necessidade da sua regra de negócios
             */
            Produto p = new Produto("TV", 900.00, 4);
            //p.Quantidade = -10;
            //Console.WriteLine(p._nome); (FORMA ERRADA DE CHAMAR ATRIBUTO PRIVADO)
            Console.WriteLine(p.GetNome()); // Forma certa
            p.SetNome("Televisão");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}
