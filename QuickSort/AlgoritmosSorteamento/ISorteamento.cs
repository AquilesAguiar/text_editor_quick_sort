using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort.AlgoritmosSorteamento
{
    public interface ISorteamento
    {
        List<String> Sortear(List<String> lista, int inicio = 0, int final = -1);
    }
}
