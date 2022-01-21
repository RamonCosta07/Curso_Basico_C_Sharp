using System;
using System.Globalization;

namespace This
{
    class Program
    {
        /* Sobrecarga é quando mais de uma versão de operação pode receber diferentes
         entradas de valores. Exemplo: Posso entrar só quando com a quantidade
        em estoque. Outra hora, a quantidade e data, etc.
        */
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine(); // cria uma variável auxiliar
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco); // chamando o construtor de 2 argumentos, não de 3

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("\nDigite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
