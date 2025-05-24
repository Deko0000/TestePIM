using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Telas
{
    public partial class EditarLivro : Form
    {
        public EditarLivro()
        {
            InitializeComponent();
        }

        public Livro LivroParaEditar { get; set; }

        private void EditarLivro_Load(object sender, EventArgs e)
        {
            if (LivroParaEditar != null)
            {
                txbTitulo.Text = LivroParaEditar.Titulo;
                txbAutor.Text = LivroParaEditar.Autor;
                txbAnoPubli.Text = LivroParaEditar.AnoPubli.ToString();
                txbISBN.Text = LivroParaEditar.ISBN;
                txbGenero.Text = LivroParaEditar.Genero;
                txbSinopse.Text = LivroParaEditar.Sinopse;
                nUpDownQuant.Value = LivroParaEditar.Quantidade;

                txbISBN.ReadOnly = true; 
                nUpDownQuant.Enabled = false;

                if (!string.IsNullOrEmpty(LivroParaEditar.CaminhoCapa))
                {
                    try
                    {
                        if (LivroParaEditar.CaminhoCapa.StartsWith("http"))
                        {
                            using (HttpClient client = new HttpClient())
                            using (var response = client.GetAsync(LivroParaEditar.CaminhoCapa).Result)
                            using (var stream = response.Content.ReadAsStreamAsync().Result)
                            {
                                pbxCapa.Image = Image.FromStream(stream);
                            }
                        }
                        else if (System.IO.File.Exists(LivroParaEditar.CaminhoCapa))
                        {
                            pbxCapa.Image = Image.FromFile(LivroParaEditar.CaminhoCapa);
                        }

                        pbxCapa.Tag = LivroParaEditar.CaminhoCapa;
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao carregar a capa.");
                    }
                }
            }
        }

        private void btnTrocarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens (*.jpg;*.png)|*.jpg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbxCapa.Image = Image.FromFile(dialog.FileName);
                pbxCapa.Tag = dialog.FileName;  // Armazena novo caminho
            }
        }
        

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (LivroParaEditar != null)
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja editar este Livro?",
                                                  "Confirmar Edição",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                    return;

                LivroParaEditar.Titulo = txbTitulo.Text;
                LivroParaEditar.Autor = txbAutor.Text;

                if (int.TryParse(txbAnoPubli.Text, out int ano))
                {
                    LivroParaEditar.AnoPubli = ano.ToString();
                }
                else
                {
                    MessageBox.Show("Ano de publicação inválido.");
                    return;
                }

               
                LivroParaEditar.Sinopse = txbSinopse.Text;
                LivroParaEditar.Genero = txbGenero.Text;
                LivroParaEditar.CaminhoCapa = pbxCapa.Tag?.ToString() ?? "";

                var verificador = new TestePIM.Controle.VerificaLivroEditado();

                if (!verificador.Validar(LivroParaEditar))
                {
                    return;
                }

                MessageBox.Show("Livro atualizado com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbTitulo.Clear();
            txbAutor.Clear();
            txbAnoPubli.Clear();
            txbISBN.Clear();
            txbGenero.Clear();
            txbSinopse.Clear();
            pbxCapa.Image = null;
            pbxCapa.Tag = null;
        }
    }
}
