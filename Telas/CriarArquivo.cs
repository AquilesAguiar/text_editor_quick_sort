using ManipulaArquivo;
using QuickSort.AlgoritmosSorteamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telas
{
    public partial class CriarArquivo : Form
    {
        List<Palavra> naoContidas = new List<Palavra>();
        IManipularArquivo manipularArquivo = new ManipularArquivo();
        private string dicionario;
        private string dirAtual;
        private string caminhoArquivo;

        public CriarArquivo()
        {
            caminhoArquivo = Operations.criaArquivo();
            InitializeComponent();
            SalvarTabela.Visible= false;
            dirAtual = manipularArquivo.getDirAtual();
            dicionario = manipularArquivo.lerArquivo(dirAtual + "\\..\\..\\..\\Arquivos\\dicionario.txt");
        }

        private void Verificar(object sender, EventArgs e)
        {
            manipularArquivo.adicionarEscritaArquivo(caminhoArquivo, CampoTexto.Text);

            string dirDicionario = dirAtual + "\\..\\..\\..\\Arquivos\\dicionario.txt";
            // Lendo o dicionário e arquivo criado
            string textoCompleto = manipularArquivo.lerArquivo(caminhoArquivo).ToLower();
            string dicionarioCompleto = manipularArquivo.lerArquivo(dirDicionario);
            // Splitando as palavras do dicionário e do TextBox
            string textoFormatado = Regex.Replace(textoCompleto, @"[^0-9a-zA-Z ]", "");
            string[] palavras = textoFormatado.Split(' ').ToArray();
            string[] palavrasDicionario = dicionarioCompleto.Split(' ').ToArray();
            // Pegando as palavras do TextBox que tem no dicionário
            string[] notPalavrasEmComum = palavras.Where(palavra => !palavrasDicionario.Contains(palavra)).ToArray();

            for (int i = 0; i < notPalavrasEmComum.Length; i++)
            {
                naoContidas.Add(new Palavra(i, notPalavrasEmComum[i]));
            }

            TabelaPalavras.DataSource = naoContidas;
            labelPalavra.Visible = true;
            TabelaPalavras.Visible = true;
            SalvarTabela.Visible = true;

            var stopwatch = new Stopwatch();
                        
            ISorteamento QuickSortMethod = new QuickSortMethod();
            
            ISorteamento BubbleSort = new BubbleSort();

            //Contagem QuickSort
            stopwatch.Start();

            string[] quickSortResult = QuickSortMethod.Sortear(palavras);

            stopwatch.Stop();
            TimeSpan QuickSortTs = stopwatch.Elapsed;

            //Restart Contagem
            stopwatch.Restart();

            //Contagem BubbleSort
            stopwatch.Start();

            string[] bubbleSortResult = BubbleSort.Sortear(palavras);

            stopwatch.Stop();

            TimeSpan BubbleSortTs = stopwatch.Elapsed;
            
            //Salvando dados da execução
            Operations.testesExecucao(QuickSortTs, BubbleSortTs, palavras.Length);

            String printadoQuick = String.Join(" ", quickSortResult);
            String printadoBubble = String.Join(" ", bubbleSortResult);
            Console.WriteLine($"QuickSort: {printadoQuick}\nBubbleSort: {printadoBubble}");
        }

        private void PalavrasComum_Click(object sender, EventArgs e)
        {

        }

        private void SalvarTabelaDicionario(object sender, EventArgs e)
        {
            string[] palavras = naoContidas.Where(p => p.Dicionario).Select(p => p.Nome).ToArray();
            List<string> dicionarioSplitted = dicionario.Split(' ').ToList();
            for (int i = 0; i < palavras.Length; i++)
            {
                dicionarioSplitted.Add(palavras[i]);
            }
            var dic = dicionarioSplitted.ToArray();
            ISorteamento quickSort = new QuickSortMethod();
            Console.WriteLine(String.Join(" ", dicionarioSplitted));
            palavras = quickSort.Sortear(dic);
            Console.WriteLine(String.Join(" ", palavras));

            IManipularArquivo manipular = new ManipularArquivo();
            string dirDicionario = dirAtual + "\\..\\..\\..\\Arquivos\\dicionario.txt";

            manipular.sobrescreverArquivo(dirDicionario, String.Join(" ", palavras));

            this.Hide();
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.ShowDialog();
            this.Show();
        }

        private void CampoTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
