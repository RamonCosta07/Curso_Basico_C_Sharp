using System;
using System.Globalization;
/* 
 * Propriedade autoimplementadas são uma forma simplificada de 
 * se declarar propriedades que não necessitam de lógicas 
 * particulares para as operações get e set
 */

namespace Properties_Autoimplementadas
{
    class Produto
    {

        private string _nome;
        public double Preco { get; private set; } // Preço não pode ser alterado por outros arquivos
        public int Quantidade { get; private set; } // Atalho do teclado, prop + tab tab
        
        /* Não serve para o atributo Nome, pois ele possui uma lógica
         * particular (o if)
         */

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1) // value é o padrão para entradas do tipo Set
                {
                    _nome = value;
                }
            }
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
            return _nome +
                ", R$ " +
                Quantidade.ToString("F2", CultureInfo.InvariantCulture) +
                ", " +
                Quantidade +
                " unidades, Total: R$ " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
