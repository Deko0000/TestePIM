// Importações necessárias para funcionalidades da aplicação
using Newtonsoft.Json.Linq; // Para manipulação de JSON (usado na API do Google Books)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; // Manipulação de imagens
using System.Linq;
using System.Net.Http; // Para requisições HTTP
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePIM.Controle; // Namespace onde está a classe de verificação

namespace TestePIM
{
    public partial class CadastroLivros : Form
    {
        public CadastroLivros()
        {
            InitializeComponent(); // Inicializa os componentes do formulário
        }

        // Busca informações de um livro a partir do ISBN usando a API do Google Books
        private async Task BuscarLivroPorISBN(string isbn)
        {
            string url = $"https://www.googleapis.com/books/v1/volumes?q=isbn:{isbn}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Faz a requisição para a API
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode(); // Lança exceção se o status for erro

                    // Lê o corpo da resposta
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Converte o JSON para objeto manipulável
                    JObject json = JObject.Parse(responseBody);
                    var item = json["items"]?[0]?["volumeInfo"];

                    if (item != null)
                    {
                        // Preenche os campos do formulário com os dados retornados
                        txbTitulo.Text = item["title"]?.ToString() ?? "";
                        txbAutor.Text = string.Join(", ", item["authors"]?.ToObject<string[]>() ?? new string[0]);
                        txbGenero.Text = item["categories"]?.First?.ToString() ?? "";
                        txbSinopse.Text = item["description"]?.ToString() ?? "";
                        txbAnoPubli.Text = item["publishedDate"]?.ToString() ?? "";

                        // Se houver uma capa disponível
                        string imagemUrl = item["imageLinks"]?["thumbnail"]?.ToString();
                        if (!string.IsNullOrEmpty(imagemUrl))
                        {
                            using (var imagemResponse = await client.GetAsync(imagemUrl))
                            {
                                if (imagemResponse.IsSuccessStatusCode)
                                {
                                    var imagemStream = await imagemResponse.Content.ReadAsStreamAsync();
                                    pbxCapa.Image = Image.FromStream(imagemStream); // Exibe a imagem

                                    // Salva a URL da imagem no Tag para uso posterior (como cadastro)
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

        // Evento do botão "Cadastrar"
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string caminhoCapa = pbxCapa.Tag?.ToString() ?? ""; // Pode ser caminho local ou URL

                // Cria o objeto livro com os dados do formulário
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

                VerificaLivro verifica = new VerificaLivro(); // Classe de validação

                if (verifica.Validar(livro)) // Valida o livro
                {
                    livro.DefinirIdentificacao(); // Gera um ID único
                    Listas.Livros.Add(livro); // Adiciona à lista global de livros
                    MessageBox.Show("Livro cadastrado com sucesso!");

                    LimparCampos(); // Limpa o formulário
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar livro: " + ex.Message);
            }
        }

        // Evento do botão "Selecionar imagem local"
        private void btnPegaImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens (*.jpg;*.png)|*.jpg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbxCapa.Image = Image.FromFile(dialog.FileName); // Carrega a imagem no PictureBox
                pbxCapa.Tag = dialog.FileName; // Salva o caminho local
            }
        }

        // Evento do botão "Voltar"
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha a tela de cadastro
        }

        // Evento do botão "Limpar campos"
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Método para limpar todos os campos do formulário
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

        // Evento do botão "Buscar ISBN"
        private async void btnBuscarISBN_Click(object sender, EventArgs e)
        {
            string isbn = txbISBN.Text.Trim();
            if (!string.IsNullOrEmpty(isbn))
            {
                await BuscarLivroPorISBN(isbn); // Chama o método de busca
            }
            else
            {
                MessageBox.Show("Por favor, insira um ISBN.");
            }
        }
    }
}