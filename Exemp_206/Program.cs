using System;
using System.Collections.Generic;
using Exemp_206.Services;

namespace Exemp_206
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.Write("Entre com Quantidade: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                list.Add(x);
            }
            ServicoDeCalculo servicoCalculo = new ServicoDeCalculo();

            int max = servicoCalculo.Max(list);

            Console.Write("\nMaximo: ");
            Console.WriteLine(max);

        }
    }
}
