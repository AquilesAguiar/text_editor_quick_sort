using System.Collections.Generic;

namespace ManipulaArquivo
{
    public interface IManipularArquivo
    {
        string lerArquivo(string diretorio);
        void sobrescreverArquivo(string diretorio, string textoEscrever);
        void adicionarEscritaArquivo(string diretorio, string textoAdicionar);
        string getDirAtual();
        string criarArquivo(string dir, string nomeArquivo, string[] conteudo);
    }
}
