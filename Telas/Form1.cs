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
        List<Palavra> naoContidas = new List<Palavra>();
        IManipularArquivo manipularArquivo = new ManipularArquivo();
        private string dicionario;
        private string dirAtual;
        public Form1()
        {
            InitializeComponent();
            dirAtual = manipularArquivo.getDirAtual();
            dicionario = manipularArquivo.lerArquivo(dirAtual + "\\..\\..\\..\\Arquivos\\dicionario.txt");
        }

        private void Verificar(object sender, EventArgs e)
        {
            string dirTeste = dirAtual +"\\..\\..\\..\\Arquivos\\teste.txt";
            string dirDicionario = dirAtual + "\\..\\..\\..\\Arquivos\\dicionario.txt";
            // Lendo o dicionário e 
            string textoCompleto = manipularArquivo.lerArquivo(dirTeste);
            string dicionarioCompleto = manipularArquivo.lerArquivo(dirDicionario);
            // Splitando as palavras do dicionário e do TextBox
            string[] palavras = textoCompleto.Split(' ').ToArray();
            string[] palavrasDicionario = dicionarioCompleto.Split(' ').ToArray();
            // Pegando as palavras do TextBox que tem no dicionário
            string[] notPalavrasEmComum = palavras.Where(palavra => !palavrasDicionario.Contains(palavra)).ToArray();
            PalavrasComum.Text = String.Join(" ", notPalavrasEmComum) ;
            for (int i = 0; i < notPalavrasEmComum.Length; i++)
            {
                naoContidas.Add(new Palavra(i, notPalavrasEmComum[i]));
            }

            TabelaPalavras.DataSource = naoContidas;
            TabelaPalavras.Visible = true;



            ISorteamento QuickSortMethod = new QuickSortMethod();
            ISorteamento BubbleSort = new BubbleSort();
            string[] quickSortResult = QuickSortMethod.Sortear(palavras);
            string[] bubbleSortResult = BubbleSort.Sortear(palavras);

            String printadoQuick = String.Join(" ", quickSortResult);
            String printadoBubble = String.Join(" ", bubbleSortResult);
            Console.WriteLine($"QuickSort: {printadoQuick}\nBubbleSort: {printadoBubble}");
            CampoTexto.Text = printadoQuick;


        }

        private void PalavrasComum_Click(object sender, EventArgs e)
        {

        }

        private void SalvarTabelaDicionario(object sender, EventArgs e)
        {
            string[] palavras = naoContidas.Where(p => p.Dicionario).Select(p => p.Nome).ToArray();
            string[] dicionarioSplitted = dicionario.Split(' ').ToArray();
            for (int i = 0; i < palavras.Length; i++)
            {
                dicionarioSplitted[dicionarioSplitted.Length + i + 1] = palavras[i];
            }
            ISorteamento quickSort = new QuickSortMethod();
            Console.WriteLine(String.Join(" ", dicionarioSplitted));
            palavras = quickSort.Sortear(dicionarioSplitted);
            Console.WriteLine(String.Join(" ", dicionarioSplitted));

            IManipularArquivo manipular = new ManipularArquivo();
            string dirDicionario = dirAtual + "\\..\\..\\..\\Arquivos\\dicionario.txt";

            manipular.sobrescreverArquivo(dirDicionario, String.Join(" ", dicionarioSplitted));
        }
    }
}
