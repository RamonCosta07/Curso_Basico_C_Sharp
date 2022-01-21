using System;
using System.Globalization;

namespace Construtores
{
    class Produto
    {
        /* Construtor é uma operação especial
         na instanciação
        */
        public string Nome; // nome de atributo começa com LETRA MAIUSCULA
        public double Preco;
        public int Quantidade;
        // construtor vem depois dos atributos
        // construtor tem o msm nome da Classe. Pode definir se ele tem algum parametro de entrada

        public Produto(string nome, double preco, int quantidade)
            /* na hora de instaciar o produto é obrigado a fornecer esses dados 
             */
        {
            Nome = nome; // O atributo Nome, vai receber o nome do construtor, obrigando a fornecer esse dado
            Preco = preco;
            Quantidade = quantidade;
        }

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
