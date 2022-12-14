using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort.AlgoritmosSorteamento
{// Operations.Comparar(array[i], pivot)  is (int) Comparacao.Menor
    
    public class QuickSortMethod : ISorteamento
    { // Operations.Comparar(array[i], pivot)  is (int) Comparacao.Menor
        private static int partition(string[] lista, int inicio, int fim)
        {
            String pivot = lista[fim];
            int i = inicio;
            for (int j = inicio; j < fim; j++)
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
        public string[] Sortear(string[] lista, int inicio = 0, int fim = -1)
        {
            if (fim == -1) fim = lista.Length - 1;

            if (inicio < fim)
            {
                int p = partition(lista, inicio, fim);
                Sortear(lista, inicio, p - 1);
                Sortear(lista, p + 1, fim);
            }
            return lista;

        }

    }
}
