using System;
using System.Globalization;

namespace This
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this () // está reaproveitando o construtor padrão
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto (string nome, double preco, int Quantidade) : this (nome, preco)
        {
            this.Quantidade = Quantidade;
            /* Também é possível usar o this quando tanto o atributo quanto o parametro
             do metódo possuem o mesmo nome (não é comum em C#, uma vez que parametro é
            por padrão iniciado com letra minuscula, e atributo se inicia com maiuscula.
            Porém, se mesmo assim estiver igual, o primeiro this se refere ao atributo
            que passa a receber o valor do parametro
            */
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