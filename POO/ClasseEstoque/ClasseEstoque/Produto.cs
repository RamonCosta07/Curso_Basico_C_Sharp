using System;
using System.Globalization;

namespace ClasseEstoque
{
    class Produto
    {
        public string Nome; // nome de atributo começa com LETRA MAIUSCULA
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) // void não retorna nada de saída
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) // por padrão parametros começa com letra minuscula
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
