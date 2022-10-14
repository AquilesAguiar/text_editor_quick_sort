using System;
namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // int[] values = { 3, 8, 7, 10, 0, 23, 2, 1, 77, 7 };
            String[] palavras = { "Xuxu", "Xuxu", "Cenoura", "Picles", "Repolho", "Brocolis", "Couve-flor", "Alface"};
            String[] result = QuickSortMethod.SortArray(palavras, 0, palavras.Length - 1);
            String printado = String.Join(", ", result);
            Console.WriteLine(printado);
            bool testeStringCompare = Operations.comparar("Baaaaa", "Aaaaaa");

            Console.WriteLine(testeStringCompare);

        }

        
    }
}

