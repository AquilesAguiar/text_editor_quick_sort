using ManipulaArquivo;
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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarArquivo editarArquivo = new EditarArquivo();
            editarArquivo.ShowDialog();
            this.Show();
        }

        private void BtnTexto_Click(object sender, EventArgs e)
        {
            this.Hide();
            CriarArquivo criarArquivo = new CriarArquivo();
            criarArquivo.ShowDialog();
            this.Show();
        }
    }
}
