using System;
using System.Globalization;

namespace Sobrecarga
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;
        
        public Produto(string nome, double preco, int quantidade)

        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto()
        {
            /* A Classe agora aceitar o construtor padrão. Ou seja, com ele vazio
            Exemplo: Produto p = new Produto(); sem parametros
            */
        }
        public Produto(string nome, double preco) //construtor que recebe só dois parametros (sobrecarga)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // Quando não passada a quantidade, o padrão será ZERO
            // Apesar disso, por padrão os valores numéricos recebem 0. Então comando é redundante
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        /* To String irá retornar o objeto
            como string
        */
        public override string ToString() // override = vem de outra classe
        {
            return Nome +
                ", R$ " +
                Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " +
                Quantidade +
                " unidades, Total: R$ " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
