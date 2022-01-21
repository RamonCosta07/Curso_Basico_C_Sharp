using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 500.0, 10);
            p.Nome = "TV 4k"; // agora ele aceitar alterar o nome, como se fosse um atributo público
            Console.WriteLine($"O produto {p.Nome}, custa R$ {p.Preco} e possui {p.Quantidade} unidades");
        }
    }
}
