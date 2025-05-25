// Importações necessárias para funcionamento da aplicação, incluindo manipulação de JSON, formulários, arquivos e redes.
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
using TestePIM.Telas.Emprestimo; // Referência à parte de empréstimos do sistema.

namespace TestePIM.Telas
{
    public partial class DadosLivro : Form
    {
        // Construtor padrão que inicializa os componentes da interface.
        public DadosLivro()
        {
            InitializeComponent();
        }

        // Propriedade pública usada para passar o livro que será visualizado neste formulário.
        public Livro LivroParaVisualizar { get; set; }

        // Variável privada para manter controle do formulário ativo embutido no painel.
        private Form formAtivo = null;

        // Evento disparado ao carregar o formulário.
        private void FormVerDadosLivro_Load(object sender, EventArgs e)
        {
            // Verifica se há um livro para ser visualizado.
            if (LivroParaVisualizar != null)
            {
                // Preenche os campos da tela com os dados do livro.
                txbTitulo.Text = LivroParaVisualizar.Titulo;
                txbAutor.Text = LivroParaVisualizar.Autor;
                txbAnoPubli.Text = LivroParaVisualizar.AnoPubli.ToString();
                txbISBN.Text = LivroParaVisualizar.ISBN;
                txbGenero.Text = LivroParaVisualizar.Genero;
                txbSinopse.Text = LivroParaVisualizar.Sinopse;
                nUpDownQuant.Value = LivroParaVisualizar.Quantidade;

                // Deixa todos os campos como somente leitura para evitar edição direta.
                txbTitulo.ReadOnly = true;
                txbAutor.ReadOnly = true;
                txbAnoPubli.ReadOnly = true;
                txbISBN.ReadOnly = true;
                txbGenero.ReadOnly = true;
                txbSinopse.ReadOnly = true;
                nUpDownQuant.Enabled = false;

                // Carrega a imagem da capa do livro, se houver caminho válido.
                if (!string.IsNullOrEmpty(LivroParaVisualizar.CaminhoCapa))
                {
                    try
                    {
                        // Se a imagem estiver hospedada (link http)
                        if (LivroParaVisualizar.CaminhoCapa.StartsWith("http"))
                        {
                            using (HttpClient client = new HttpClient())
                            using (var response = client.GetAsync(LivroParaVisualizar.CaminhoCapa).Result)
                            using (var stream = response.Content.ReadAsStreamAsync().Result)
                            {
                                pbxCapa.Image = Image.FromStream(stream);
                            }
                        }
                        // Se a imagem estiver em um caminho local
                        else if (File.Exists(LivroParaVisualizar.CaminhoCapa))
                        {
                            pbxCapa.Image = Image.FromFile(LivroParaVisualizar.CaminhoCapa);
                        }
                        // Se o caminho for inválido ou não encontrado
                        else
                        {
                            pbxCapa.Image = null;
                            pbxCapa.BackColor = Color.FromArgb(107, 74, 68); // Cor de fundo padrão
                        }
                    }
                    catch
                    {
                        // Em caso de erro no carregamento da imagem
                        pbxCapa.Image = null;
                        pbxCapa.BackColor = Color.FromArgb(107, 74, 68);
                        MessageBox.Show("Erro ao carregar a imagem da capa.");
                    }
                }
            }
        }

        // Fecha o formulário atual ao clicar no botão voltar.
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para abrir um formulário filho dentro do painel do formulário atual.
        private void abreEditForm(Form editForm)
        {
            // Fecha o formulário anterior se ainda estiver aberto.
            if (formAtivo != null)
                formAtivo.Close();

            // Configura o novo formulário para ser embutido no painel.
            formAtivo = editForm;
            editForm.TopLevel = false;
            editForm.FormBorderStyle = FormBorderStyle.None;
            editForm.Dock = DockStyle.Fill;
            panelDadosLivro.Controls.Clear(); // Limpa qualquer controle anterior do painel.
            panelDadosLivro.Controls.Add(editForm);
            panelDadosLivro.Tag = editForm;
            editForm.BringToFront();
            editForm.Show();
        }

        // Evento do botão Editar: abre o formulário de edição e passa o livro atual.
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var formEdit = new EditarLivro(); // Cria o formulário de edição
            formEdit.LivroParaEditar = LivroParaVisualizar; // Passa o livro a ser editado

            abreEditForm(formEdit); // Abre o formulário no painel

            this.FormVerDadosLivro_Load(null, null); // Recarrega os dados após a edição
        }

        // Evento do botão Realizar Empréstimo: abre a tela de realizar empréstimo.
        private void btnRealizaEmp_Click(object sender, EventArgs e)
        {
            // Cria o formulário de empréstimo e define o livro selecionado.
            RealizaEmp formEmp = new RealizaEmp();
            formEmp.LivroRecebido = this.LivroParaVisualizar;

            // Cria o menu de empréstimo e abre a tela de realizar empréstimo dentro dele.
            MenuEmprestimo menuEmp = new MenuEmprestimo();
            menuEmp.abreMenuEmpForm(formEmp);
            menuEmp.Show(); // Exibe a janela
        }
    }
}
