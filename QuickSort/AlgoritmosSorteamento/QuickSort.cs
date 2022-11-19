using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort.AlgoritmosSorteamento
{
    
    public class QuickSortMethod : ISorteamento
    {
        private static int partition( List<String> lista, int inicio, int fim)
        {
            String pivot = lista[fim];
            int i = inicio;
            for (int j = inicio; j < fim;  j++)
            {
                int menorOrIgual = Operations.Comparar(lista[j], pivot);
                if (menorOrIgual is (int)Comparacao.Menor || menorOrIgual is  (int)Comparacao.Igual)
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
        public List<String> Sortear(List<String> lista, int inicio = 0, int fim = -1)
        {
            if (fim == -1) fim = lista.Count - 1;

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
