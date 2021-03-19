using System;
using System.Collections.Generic;
using System.Globalization;
using Exemp_206.Services;
using Exemp_206.Entities;

namespace Exemp_206
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Console.Write("Entre com Quantidade: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string nome = vect[0];
                double preco = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Produto(nome, preco));
            }
            ServicoDeCalculo servicoCalculo = new ServicoDeCalculo();

            Produto max = servicoCalculo.Max(list);

            Console.Write("\nMaior: ");
            Console.WriteLine(max);

        }
    }
}
