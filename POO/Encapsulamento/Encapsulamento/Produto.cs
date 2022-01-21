using System;
using System.Globalization;

namespace Encapsulamento
{
    class Produto
    {

        private string _nome; // Por padrão no C#, o nome dos atributos privados devem...
        private double _preco; // ... começar com _ seguido por uma letra minúscula.
        private int _quantidade; //Private significa que o atributo ñ pode ser acessado de outra classe

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome() // Para poder retornar o valor do nome, uma vez que _nome é private
        {
            return _nome;
        }

        public void SetNome(string nome) //Para poder alterar o valor do nome, uma vez que _nome é private
        {
            if(nome != null && nome.Length > 1) // Pode se criar uma condicional dentro dele
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade; //Como quantidade e preco não tem Set, eles podem apenas retornar valor
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
