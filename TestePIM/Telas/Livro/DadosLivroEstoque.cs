// Importações necessárias para funcionalidades como manipulação de JSON, formulários, imagens, arquivos e requisições HTTP.
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
    // Classe do formulário que exibe os dados de um livro no contexto de estoque (visualização apenas).
    public partial class DadosLivroEstoque : Form
    {
        // Construtor que inicializa os componentes da interface gráfica.
        public DadosLivroEstoque()
        {
            InitializeComponent();
        }

        // Propriedade pública para armazenar o livro a ser visualizado.
        public Livro LivroParaVisualizar { get; set; }

        // Evento que será disparado quando o usuário clicar em "Voltar".
        // Permite que o formulário que chamou este seja notificado quando for cancelado.
        public event EventHandler Cancelado;

        // Evento chamado quando o formulário é carregado.
        private void FormVerDadosLivro_Load(object sender, EventArgs e)
        {
            // Verifica se o livro foi definido.
            if (LivroParaVisualizar != null)
            {
                // Preenche os campos do formulário com os dados do livro.
                txbTitulo.Text = LivroParaVisualizar.Titulo;
                txbAutor.Text = LivroParaVisualizar.Autor;
                txbAnoPubli.Text = LivroParaVisualizar.AnoPubli.ToString();
                txbISBN.Text = LivroParaVisualizar.ISBN;
                txbGenero.Text = LivroParaVisualizar.Genero;
                txbSinopse.Text = LivroParaVisualizar.Sinopse;
                nUpDownQuant.Value = LivroParaVisualizar.Quantidade;

                // Define os campos como somente leitura e desativa a edição da quantidade.
                txbTitulo.ReadOnly = true;
                txbAutor.ReadOnly = true;
                txbAnoPubli.ReadOnly = true;
                txbISBN.ReadOnly = true;
                txbGenero.ReadOnly = true;
                txbSinopse.ReadOnly = true;
                nUpDownQuant.Enabled = false;

                // Carrega a imagem da capa do livro, se houver caminho definido.
                if (!string.IsNullOrEmpty(LivroParaVisualizar.CaminhoCapa))
                {
                    try
                    {
                        // Se o caminho for uma URL
                        if (LivroParaVisualizar.CaminhoCapa.StartsWith("http"))
                        {
                            using (HttpClient client = new HttpClient())
                            using (var response = client.GetAsync(LivroParaVisualizar.CaminhoCapa).Result)
                            using (var stream = response.Content.ReadAsStreamAsync().Result)
                            {
                                pbxCapa.Image = Image.FromStream(stream);
                            }
                        }
                        // Se o caminho for um arquivo local
                        else if (File.Exists(LivroParaVisualizar.CaminhoCapa))
                        {
                            pbxCapa.Image = Image.FromFile(LivroParaVisualizar.CaminhoCapa);
                        }
                        // Se o caminho estiver incorreto ou a imagem não for encontrada
                        else
                        {
                            pbxCapa.Image = null;
                            pbxCapa.BackColor = Color.FromArgb(107, 74, 68); // Cor de fundo padrão
                        }
                    }
                    catch
                    {
                        // Em caso de erro, remove a imagem e mostra uma mensagem ao usuário
                        pbxCapa.Image = null;
                        pbxCapa.BackColor = Color.FromArgb(107, 74, 68);
                        MessageBox.Show("Erro ao carregar a imagem da capa.");
                    }
                }
            }
        }

        // Evento do botão "Voltar". Em vez de simplesmente fechar o formulário,
        // dispara um evento chamado `Cancelado`, que pode ser tratado externamente.
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Cancelado?.Invoke(this, EventArgs.Empty);
        }
    }
}
