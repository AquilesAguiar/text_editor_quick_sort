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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Telas
{
    public partial class EditarArquivo : Form
    {
        IManipularArquivo manipularArquivo = new ManipularArquivo();
        List<Palavra> naoContidas = new List<Palavra>();
        private string dicionario;
        private string dirAtual;
        private string caminhoArquivo;
        private string caminhoArquivoTexto;
        string textoArq;
        public EditarArquivo()
        {
            InitializeComponent();
            dirAtual = manipularArquivo.getDirAtual();
            dicionario = manipularArquivo.lerArquivo(dirAtual + "\\..\\..\\..\\Arquivos\\dicionario.txt");
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivoTexto = openFileDialog1.FileName;
                textoArq = manipularArquivo.lerArquivo(caminhoArquivoTexto);
                CampoTexto.Enabled = true;
                CampoTexto.Text = textoArq;
            }
            
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            labelSalvaPalavra.Visible = true;
            TabelaPalavras.Visible = true;
            SalvarTabela.Visible = true;
            manipularArquivo.sobrescreverArquivo(caminhoArquivoTexto, CampoTexto.Text);

            string dirDicionario = dirAtual + "\\..\\..\\..\\Arquivos\\dicionario.txt";
            // Lendo o dicionário e arquivo criado
            string textoCompleto = manipularArquivo.lerArquivo(caminhoArquivoTexto).ToLower();
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

            var stopwatch = new Stopwatch();

            ISorteamento QuickSortMethod = new QuickSortMethod();
            ISorteamento BubbleSort = new BubbleSort();

            //Contagem QuickSort
            stopwatch.Start();

            string[] quickSortResult = QuickSortMethod.Sortear(palavras);

            stopwatch.Stop();
            Console.WriteLine($"Tempo passado QuickSort: {stopwatch.Elapsed}");

            //Restart Contagem
            stopwatch.Restart();

            //Contagem BubbleSort
            stopwatch.Start();

            string[] bubbleSortResult = BubbleSort.Sortear(palavras);

            stopwatch.Stop();
            Console.WriteLine($"Tempo passado BubbleSort: {stopwatch.Elapsed}");

            String printadoQuick = String.Join(" ", quickSortResult);
            String printadoBubble = String.Join(" ", bubbleSortResult);
            Console.WriteLine($"QuickSort: {printadoQuick}\nBubbleSort: {printadoBubble}");

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
            Console.WriteLine(String.Join(" ", dicionarioSplitted));

            IManipularArquivo manipular = new ManipularArquivo();
            string dirDicionario = dirAtual + "\\..\\..\\..\\Arquivos\\dicionario.txt";

            manipular.sobrescreverArquivo(dirDicionario, String.Join(" ", dicionarioSplitted));

            this.Hide();
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            telaPrincipal.ShowDialog();
            this.Show();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }

}
    

