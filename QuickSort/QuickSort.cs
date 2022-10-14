using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public static class QuickSortMethod
    {
        public static String[] SortArray(String[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            String pivot = array[leftIndex];

            while (i <= j)
            {
                // while (array[i] < pivot)
                while (Operations.comparar(pivot, array[i]))
                {
                    i++;
                }

                while (Operations.comparar(array[j], pivot))
                {
                    j--;
                }

                if (i <= j)
                {
                    String temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j) SortArray(array, leftIndex, j);

            if (i < rightIndex) SortArray(array, i, rightIndex);

            return array;
        }
    }
}
