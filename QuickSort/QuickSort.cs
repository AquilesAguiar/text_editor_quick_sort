using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    
    public static class QuickSortMethod
    {
        private static int partition(ref List<String> lista, int inicio, int fim)
        {
            String pivot = lista[fim];
            int i = inicio;
            for (int j = inicio; j < fim;  j++)
            {
                int menorOrIgual = Operations.Comparar(lista[j], pivot);
                if (menorOrIgual == ((int)Comparacao.Menor) || menorOrIgual == ((int)Comparacao.Igual))
                {
                    String vlrAntigo = lista[j];
                    lista[j] = lista[i];
                    lista[i] = vlrAntigo;
                    i++;
                }
            }
            String vlrAntigo2 = lista[i];
            lista[i] = lista[fim];
            lista[fim] = vlrAntigo2;

            return i;
        }
        public static void QuickSort(ref List<String> lista, int inicio = 0, int fim = -1)
        {
            if (fim == -1) fim = lista.Count - 1;

            if (inicio < fim)
            {
                int p = partition(ref lista, inicio, fim);
                QuickSort(ref lista, inicio, p - 1);
                QuickSort(ref lista, p + 1, fim);
            }

        }
    }
}
