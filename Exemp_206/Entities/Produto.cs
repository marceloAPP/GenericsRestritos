using System;
using System.Globalization;

namespace Exemp_206.Entities
{
    class Produto : IComparable
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome 
                + ", "
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Produto))
            {
                throw new ArgumentException("Erro de Comparação: O argumento não é um produto");
            }
            Produto outro = obj as Produto;
            return Preco.CompareTo(outro.Preco);
        }
    }
}
