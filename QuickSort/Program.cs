using QuickSort.AlgoritmosSorteamento;
using System;
using System.Collections.Generic;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // int[] values = { 3, 8, 7, 10, 0, 23, 2, 1, 77, 7 };
            List<String> palavras = new() {
                "abac",
                "aaac",
                "aaa",
                "aab"
            };// new() { "Xuxu", "Xuxu", "Cenoura", "Picles", "Repolho", "Brocolis", "Couve-flor", "Alface"};
            var quickSortResult = QuickSortMethod.QuickSort(palavras);
            var bubbleSortResult = BubbleSort.bubbleSort(palavras);

            String printadoQuick  = String.Join(", ", quickSortResult);
            String printadoBubble = String.Join(", ", bubbleSortResult);
            Console.WriteLine($"QuickSort: {printadoQuick}\nBubbleSort: {printadoBubble}");
        }

        
    }
}

