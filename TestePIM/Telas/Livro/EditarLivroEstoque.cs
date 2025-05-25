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
        public partial class EditarLivroEstoque : Form
        {
            public EditarLivroEstoque()
            {
                InitializeComponent();
            }

            public Livro LivroParaEditar { get; set; }

            public event EventHandler Cancelado; // Evento personalizado para notificar cancelamento ou conclusão

            // Evento de carregamento do formulário
            private void EditarLivro_Load(object sender, EventArgs e)
            {
                if (LivroParaEditar != null)
                {
                    // Preenche os campos do formulário com os dados do livro selecionado
                    txbTitulo.Text = LivroParaEditar.Titulo;
                    txbAutor.Text = LivroParaEditar.Autor;
                    txbAnoPubli.Text = LivroParaEditar.AnoPubli.ToString();
                    txbISBN.Text = LivroParaEditar.ISBN;
                    txbGenero.Text = LivroParaEditar.Genero;
                    txbSinopse.Text = LivroParaEditar.Sinopse;
                    nUpDownQuant.Value = LivroParaEditar.Quantidade;

                    txbISBN.ReadOnly = true; // Impede edição do ISBN

                    // Carrega a imagem da capa, se houver
                    if (!string.IsNullOrEmpty(LivroParaEditar.CaminhoCapa))
                    {
                        try
                        {
                            if (LivroParaEditar.CaminhoCapa.StartsWith("http"))
                            {
                                // Carrega imagem da internet
                                using (HttpClient client = new HttpClient())
                                using (var response = client.GetAsync(LivroParaEditar.CaminhoCapa).Result)
                                using (var stream = response.Content.ReadAsStreamAsync().Result)
                                {
                                    pbxCapa.Image = Image.FromStream(stream);
                                }
                            }
                            else if (System.IO.File.Exists(LivroParaEditar.CaminhoCapa))
                            {
                                // Carrega imagem do arquivo local
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

            // Botão para trocar a imagem da capa
            private void btnTrocarImagem_Click(object sender, EventArgs e)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Imagens (*.jpg;*.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pbxCapa.Image = Image.FromFile(dialog.FileName);
                    pbxCapa.Tag = dialog.FileName;
                }
            }

            // Botão para confirmar a edição do livro
            private void btnConfirmar_Click(object sender, EventArgs e)
            {
                if (LivroParaEditar != null)
                {
                    // Confirmação do usuário antes de editar
                    var confirmacao = MessageBox.Show("Tem certeza que deseja editar este Livro?",
                                                      "Confirmar Edição",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                    if (confirmacao != DialogResult.Yes)
                        return;

                    // Atualiza os dados do livro com os valores dos campos
                    LivroParaEditar.Titulo = txbTitulo.Text;
                    LivroParaEditar.Autor = txbAutor.Text;

                    // Validação do ano de publicação
                    if (int.TryParse(txbAnoPubli.Text, out int ano))
                    {
                        LivroParaEditar.AnoPubli = ano.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ano de publicação inválido.");
                        return;
                    }

                    LivroParaEditar.Quantidade = (int)nUpDownQuant.Value;
                    LivroParaEditar.Sinopse = txbSinopse.Text;
                    LivroParaEditar.Genero = txbGenero.Text;
                    LivroParaEditar.CaminhoCapa = pbxCapa.Tag?.ToString() ?? "";

                    // Validação dos dados editados
                    var verificador = new TestePIM.Controle.VerificaLivroEditadoEstoque();

                    if (!verificador.Validar(LivroParaEditar))
                    {
                        return;
                    }

                    MessageBox.Show("Livro atualizado com sucesso!");
                    this.DialogResult = DialogResult.OK;
                    Cancelado?.Invoke(this, EventArgs.Empty); // Chama o evento para notificar conclusão
                }
            }

            // Botão para cancelar a edição
            private void btnCancelar_Click(object sender, EventArgs e)
            {
                Cancelado?.Invoke(this, EventArgs.Empty);
            }

            // Botão para voltar (também cancela)
            private void btnVoltar_Click(object sender, EventArgs e)
            {
                Cancelado?.Invoke(this, EventArgs.Empty);
            }

            // Botão para limpar todos os campos do formulário
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
    

