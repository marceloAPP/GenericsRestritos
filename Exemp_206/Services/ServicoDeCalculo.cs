using System;
using System.Collections.Generic;

namespace Exemp_206.Services
{
    class ServicoDeCalculo
    {
        public int Max(List<int> list)
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("Lsita não pode estar vazia!");
            }

            int max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
