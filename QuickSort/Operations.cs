using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public enum Comparacao
    {
        Maior = 1,
        Igual = 0,
        Menor = -1
    }
    public static class Operations
    {
        public static int Comparar(String palavra1, String palavra2)
        {
            return String.Compare(palavra1, palavra2);
        }
    }
}
