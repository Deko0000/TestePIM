using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM
{
    public partial class CadastroLivros : Form
    {
        public CadastroLivros()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Livro livro = new Livro(
                    txbTitulo.Text,
                    txbAutor.Text,
                    txbISBN.Text,
                    txbAnoPubli.Text,
                    (int)nUpDownQuant.Value,
                    cbxGenero.Text,
                    txbSinopse.Text
                );

                VerificaLivro verifica = new VerificaLivro();
                if (verifica.Validar(livro))
                {
                    livro.DefinirIdentificacao();
                    Listas.Livros.Add(livro);  // ou SistemaLivro.Livros.Add(livro);
                    MessageBox.Show("Livro cadastrado com sucesso!");
                    txbTitulo.Clear();
                    txbAutor.Clear();
                    cbxGenero.SelectedIndex = -1;
                    txbISBN.Clear();
                    txbAnoPubli.Clear();
                    nUpDownQuant.Value = 0;
                    pbxCapa.Image = null;

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar livro: " + ex.Message);
            }
        }
        private void btnPegaImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens (*.jpg;*.png)|*.jpg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbxCapa.Image = Image.FromFile(dialog.FileName);
                pbxCapa.Tag = dialog.FileName; // Salva o caminho da imagem no Tag (se precisar depois)
            }

        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbTitulo.Clear();
            txbAutor.Clear();
            cbxGenero.SelectedIndex = -1;
            txbISBN.Clear();
            txbAnoPubli.Clear();
            nUpDownQuant.Value = 0;
            pbxCapa.Image = null;

        }
    }
}
