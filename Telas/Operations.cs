using ManipulaArquivo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telas
{
    public static class Operations
    {
        public static void adicionarPalavra(string dir, string texto, string palavra)
        {
            IManipularArquivo manipular = new ManipularArquivo();
            string textoUsar = texto + "\n" + palavra;
            manipular.sobrescreverArquivo(dir, textoUsar);
        }

        public static string criaArquivo()
        {
            String caminho = "\\..\\..\\..\\Arquivos\\";
            String timeStamp = GetTimestamp(DateTime.Now);
            IManipularArquivo manipularArquivo = new ManipularArquivo();

            return manipularArquivo.criarArquivo(caminho, $"Arquivo{timeStamp}.txt", Array.Empty<String>());
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }
        public static void testesExecucao(TimeSpan quick, TimeSpan bubble, int massaDados)
        {
            StreamWriter x;
            int Qn = (int)quick.Milliseconds;
            int Bn = (int)bubble.Milliseconds;
            double Pn = Qn < Bn ? Bn - Qn : Qn - Bn;
            string simbolo = Qn < Bn ? "QuickSort" : "BubbleSort";
            //usando o metodo e abrindo o arquivo texto
            x = File.AppendText(@"..\..\..\Arquivos\execucaoTestes.txt");
            x.WriteLine($"Massa de dados - {massaDados}");
            x.WriteLine($"Tempo de execução QuickSort - {quick}");
            x.WriteLine($"Tempo de execução BubbleSort - {bubble}");
            x.WriteLine($"{simbolo} foi mais rapido por {Pn} Mili Secundos");
            x.WriteLine($"--------------------------------------------------------------------------------------");
            x.Close();
        }
    }
}
