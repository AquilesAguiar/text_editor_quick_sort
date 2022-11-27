using QuickSort.AlgoritmosSorteamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipal());
            /*
            string[] testes = new string[] { "Z", "Y", "X", "W", "V", "U", "T", "S", "R", "Q", "P", "O", "N", "M", "L", "K", "J", "I", "H", "G", "F", "E", "D", "C", "B", "A" };
            ISorteamento sorteamento = new QuickSortMethod();
            string[] sorteado = sorteamento.Sortear(testes);
            string fraseAlinhada = String.Join(" ", sorteado);
            Console.WriteLine(fraseAlinhada);
            */
        }
    }
}
