using ManipulaArquivo;
using QuickSort.AlgoritmosSorteamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificar(object sender, EventArgs e)
        {
            IManipularArquivo manipularArquivo = new ManipularArquivo();
            string dirAtual = manipularArquivo.getDirAtual();
            string dirTeste = dirAtual +"\\..\\..\\..\\Arquivos\\teste.txt";
            string dirDicionario = dirAtual + "\\..\\..\\..\\Arquivos\\dicionario.txt";
            // Lendo o dicionário e 
            string textoCompleto = manipularArquivo.lerArquivo(dirTeste);
            string dicionarioCompleto = manipularArquivo.lerArquivo(dirDicionario);
            // Splitando as palavras do dicionário e do TextBox
            List<string> palavras = textoCompleto.Split(' ').ToList();
            List<string> palavrasDicionario = dicionarioCompleto.Split(' ').ToList();
            // Pegando as palavras do TextBox que tem no dicionário
            List<string> notPalavrasEmComum = palavras.Where(palavra => !palavrasDicionario.Contains(palavra)).ToList();
            PalavrasComum.Text = String.Join(" ", notPalavrasEmComum) ;
            List<Palavra> naoContidas = new List<Palavra>();
            for (int i = 0; i < notPalavrasEmComum.Count; i++)
            {
                naoContidas.Add(new Palavra(i, notPalavrasEmComum[i]));
            }

            TabelaPalavras.DataSource = naoContidas;
            TabelaPalavras.Visible = true;

            ISorteamento QuickSortMethod = new QuickSortMethod();
            ISorteamento BubbleSort = new BubbleSort();
            List<String> quickSortResult = QuickSortMethod.Sortear(palavras);
            List<String> bubbleSortResult = BubbleSort.Sortear(palavras);

            String printadoQuick = String.Join(" ", quickSortResult);
            String printadoBubble = String.Join(" ", bubbleSortResult);
            Console.WriteLine($"QuickSort: {printadoQuick}\nBubbleSort: {printadoBubble}");
            CampoTexto.Text = printadoQuick;


        }

        private void PalavrasComum_Click(object sender, EventArgs e)
        {

        }
    }
}
