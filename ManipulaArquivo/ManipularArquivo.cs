using System;
using System.Collections.Generic;
using System.IO;

namespace ManipulaArquivo
{
    public class ManipularArquivo : IManipularArquivo
    {
        public string lerArquivo(string diretorio)
        {
            var data = File.ReadAllText(diretorio);
            return data;
        }
        
        public void adicionarEscritaArquivo(string diretorio, string texto)
        {
            StreamWriter x;

            //usando o metodo e abrindo o arquivo texto
            x = File.AppendText(diretorio);
            x.WriteLine(texto);

            x.Close();
        }

        public void sobrescreverArquivo(string diretorio, string texto)
        {
            StreamWriter arquivo;
            arquivo = File.CreateText(diretorio);
            arquivo.WriteLine(texto);
            arquivo.Close();
        }

        public string getDirAtual()
        {
            return Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.ToString());
        }

        public string criarArquivo(string dir, string nomeArquivo, string[] conteudo)
        {
            string arquivo = @"..\..\..\Arquivos\" + nomeArquivo;

            File.Create(arquivo).Dispose();

            File.WriteAllLines(arquivo, conteudo);

            return arquivo;
        }
    }
}
