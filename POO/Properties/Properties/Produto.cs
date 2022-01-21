using System;
using System.Globalization;

namespace Properties
{
    class Produto
    {

        private string _nome; 
        private double _preco; 
        private int _quantidade;

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
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

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade;}
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        /* To String irá retornar o objeto
            como string
        */
        public override string ToString() // override = vem de outra classe
        {
            return _nome +
                ", R$ " +
                _preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " +
                _quantidade +
                " unidades, Total: R$ " +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
