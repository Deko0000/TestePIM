using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Telas
{
    public partial class DadosLivro : Form
    {
        public DadosLivro()
        {
            InitializeComponent();
        }

        public Livro LivroParaVisualizar { get; set; }

        private Form formAtivo = null;

        private void FormVerDadosLivro_Load(object sender, EventArgs e)
        {
            if (LivroParaVisualizar != null)
            {
                txbTitulo.Text = LivroParaVisualizar.Titulo;
                txbAutor.Text = LivroParaVisualizar.Autor;
                txbAnoPubli.Text = LivroParaVisualizar.AnoPubli.ToString();
                txbISBN.Text = LivroParaVisualizar.ISBN;
                txbGenero.Text = LivroParaVisualizar.Genero;
                txbSinopse.Text = LivroParaVisualizar.Sinopse;
                nUpDownQuant.Value = LivroParaVisualizar.Quantidade;

                // Torna os campos somente leitura
                txbTitulo.ReadOnly = true;
                txbAutor.ReadOnly = true;
                txbAnoPubli.ReadOnly = true;
                txbISBN.ReadOnly = true;
                txbGenero.ReadOnly = true;
                txbSinopse.ReadOnly = true;
                nUpDownQuant.Enabled = false;

                // Carrega a imagem da capa
                if (!string.IsNullOrEmpty(LivroParaVisualizar.CaminhoCapa))
                {
                    try
                    {
                        if (LivroParaVisualizar.CaminhoCapa.StartsWith("http"))
                        {
                            using (HttpClient client = new HttpClient())
                            using (var response = client.GetAsync(LivroParaVisualizar.CaminhoCapa).Result)
                            using (var stream = response.Content.ReadAsStreamAsync().Result)
                            {
                                pbxCapa.Image = Image.FromStream(stream);
                            }
                        }
                        else if (File.Exists(LivroParaVisualizar.CaminhoCapa))
                        {
                            pbxCapa.Image = Image.FromFile(LivroParaVisualizar.CaminhoCapa);
                        }
                        else
                        {
                            pbxCapa.Image = null;
                            pbxCapa.BackColor = Color.FromArgb(107, 74, 68); // fundo padrão
                        }
                    }
                    catch
                    {
                        pbxCapa.Image = null;
                        pbxCapa.BackColor = Color.FromArgb(107, 74, 68);
                        MessageBox.Show("Erro ao carregar a imagem da capa.");
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abreEditForm(Form editForm)
        {
            if (formAtivo != null)
                formAtivo.Close();

            formAtivo = editForm;
            editForm.TopLevel = false;
            editForm.FormBorderStyle = FormBorderStyle.None;
            editForm.Dock = DockStyle.Fill;
            panelDadosLivro.Controls.Clear();
            panelDadosLivro.Controls.Add(editForm);
            panelDadosLivro.Tag = editForm;
            editForm.BringToFront();
            editForm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var formEdit = new EditarLivro(); // formulário de edição
            formEdit.LivroParaEditar = LivroParaVisualizar;

            // Abra o formulário dentro do painel
            abreEditForm(formEdit);           
            this.FormVerDadosLivro_Load(null, null); // recarrega os dados após edição
            
        }
       
    }
}
