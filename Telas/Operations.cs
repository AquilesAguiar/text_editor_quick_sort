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

    }
}
