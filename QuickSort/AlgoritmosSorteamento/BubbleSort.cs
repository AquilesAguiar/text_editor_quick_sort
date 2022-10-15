using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort.AlgoritmosSorteamento
{
    public class BubbleSort
    {
		public static List<String> bubbleSort(List<String> vetor)
		{
			int tamanho = vetor.Count;
			int comparacoes = 0;
			int trocas = 0;

			for (int i = tamanho - 1; i >= 1; i--)
			{
				for (int j = 0; j < i; j++)
				{
					comparacoes++;
					if ( Operations.Comparar(vetor[j], vetor[j + 1]) == (int)Comparacao.Maior )
					{
						String aux = vetor[j];
						vetor[j] = vetor[j + 1];
						vetor[j + 1] = aux;
						trocas++;
					}
				}
			}

			return vetor;
		}
	}
}
