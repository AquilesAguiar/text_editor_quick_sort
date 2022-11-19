using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telas
{
    public class Palavra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Dicionario { get; set; } = false;

        public Palavra(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
