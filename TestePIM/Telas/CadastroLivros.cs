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
using TestePIM.Controle;

namespace TestePIM
{
    public partial class CadastroLivros : Form
    {
        public CadastroLivros()
        {
            InitializeComponent();
        }

        private async Task BuscarLivroPorISBN(string isbn)
        {
            string url = $"https://www.googleapis.com/books/v1/volumes?q=isbn:{isbn}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);
                    var item = json["items"]?[0]?["volumeInfo"];

                    if (item != null)
                    {
                        txbTitulo.Text = item["title"]?.ToString() ?? "";
                        txbAutor.Text = string.Join(", ", item["authors"]?.ToObject<string[]>() ?? new string[0]);
                        txbGenero.Text = item["categories"]?.First?.ToString() ?? "";
                        txbSinopse.Text = item["description"]?.ToString() ?? "";
                        txbAnoPubli.Text = item["publishedDate"]?.ToString() ?? "";                     
                        string imagemUrl = item["imageLinks"]?["thumbnail"]?.ToString();
                        if (!string.IsNullOrEmpty(imagemUrl))
                        {
                            using (var imagemResponse = await client.GetAsync(imagemUrl))
                            {
                                if (imagemResponse.IsSuccessStatusCode)
                                {
                                    var imagemStream = await imagemResponse.Content.ReadAsStreamAsync();
                                    pbxCapa.Image = Image.FromStream(imagemStream);

                                    // Opcional: guardar a URL da imagem no Tag para cadastro
                                    pbxCapa.Tag = imagemUrl;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Livro não encontrado com este ISBN.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o livro: " + ex.Message);
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string caminhoCapa = pbxCapa.Tag?.ToString() ?? "";

                Livro livro = new Livro(

                    txbTitulo.Text,
                    txbAutor.Text,
                    txbISBN.Text,
                    txbAnoPubli.Text,
                    (int)nUpDownQuant.Value,
                    txbGenero.Text,
                    txbSinopse.Text,
                    caminhoCapa
                );

                VerificaLivro verifica = new VerificaLivro();
                if (verifica.Validar(livro))
                {
                    livro.DefinirIdentificacao();
                    Listas.Livros.Add(livro);
                    MessageBox.Show("Livro cadastrado com sucesso!");

                    // Limpa os campos
                    LimparCampos();
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
                pbxCapa.Tag = dialog.FileName;  // Armazena o caminho da imagem
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txbTitulo.Clear();
            txbAutor.Clear();
            txbGenero.Clear();
            txbISBN.Clear();
            txbAnoPubli.Clear();
            txbSinopse.Clear();
            nUpDownQuant.Value = 0;
            pbxCapa.Image = null;
            pbxCapa.Tag = null;
        }

        private async void btnBuscarISBN_Click(object sender, EventArgs e)
        {
            string isbn = txbISBN.Text.Trim();
            if (!string.IsNullOrEmpty(isbn))
            {
                await BuscarLivroPorISBN(isbn);
            }
            else
            {
                MessageBox.Show("Por favor, insira um ISBN.");
            }
        }
    }
}
