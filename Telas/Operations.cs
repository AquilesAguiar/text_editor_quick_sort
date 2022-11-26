using ManipulaArquivo;
using System;
using System.Collections.Generic;
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

    }
}
