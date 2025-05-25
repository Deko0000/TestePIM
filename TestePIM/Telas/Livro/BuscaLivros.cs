using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePIM.Controle;

namespace TestePIM.Telas
{
    public partial class BuscaLivros : Form
    {
        public BuscaLivros()
        {
            InitializeComponent();

            // Configura eventos de filtro para busca dinâmica
            txbBuscar.TextChanged += Filtro_TextChanged;
            cbxGenero.SelectedIndexChanged += Filtro_TextChanged;

            // Preenche o ComboBox de gêneros com opções distintas e a opção "Todos"
            cbxGenero.Items.Add("Todos");
            cbxGenero.Items.AddRange(Listas.Livros.Select(l => l.Genero).Distinct().ToArray());
            cbxGenero.SelectedIndex = 0;

            // Carrega todos os livros inicialmente nos cards
            CarregarCardsLivros(Listas.Livros);
        }

        // Evento chamado ao alterar texto de busca ou seleção de gênero
        private void Filtro_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        // Aplica os filtros de busca e gênero sobre a lista de livros
        private void AplicarFiltros()
        {
            string textoBusca = txbBuscar.Text.ToLower();
            string generoSelecionado = cbxGenero.SelectedItem?.ToString();

            // Filtra os livros conforme texto e gênero
            var livrosFiltrados = Listas.Livros.Where(l =>
                (string.IsNullOrWhiteSpace(textoBusca) || l.Titulo.ToLower().Contains(textoBusca) || l.Autor.ToLower().Contains(textoBusca)) &&
                (generoSelecionado == "Todos" || l.Genero == generoSelecionado)
            ).ToList();

            CarregarCardsLivros(livrosFiltrados);
        }

        // Cria e posiciona os cards dos livros no painel
        private void CarregarCardsLivros(List<Livro> livros)
        {
            panelCardsLivros.Controls.Clear();

            int cardLargura = 185;
            int cardAltura = 325;
            int margem = 10;

            int posX = margem;
            int posY = margem;

            foreach (var livro in livros)
            {
                // Cria o card visual para o livro
                Panel card = CardBuscaLivro.CriarCard(livro, BtnVerMais_Click, cardLargura, cardAltura);

                // Posiciona o card no painel
                card.Left = posX;
                card.Top = posY;

                panelCardsLivros.Controls.Add(card);

                posX += cardLargura + margem;

                // Quebra linha se passar da largura do painel
                if (posX + cardLargura > panelCardsLivros.Width)
                {
                    posX = margem;
                    posY += cardAltura + margem;
                }
            }
        }

        // Guarda referência do formulário de detalhes ativo
        private Form formAtivo = null;

        // Abre o formulário de detalhes do livro selecionado
        private void abreDadosForm(Form dadosForm)
        {
            if (formAtivo != null)
                formAtivo.Close();

            formAtivo = dadosForm;
            dadosForm.TopLevel = false;
            dadosForm.FormBorderStyle = FormBorderStyle.None;
            dadosForm.Dock = DockStyle.Fill;
            panelHeader.Visible = false; // Esconde o header
            panelBuscaLivro.Controls.Clear(); // Limpa painel de busca
            panelBuscaLivro.Controls.Add(dadosForm);
            panelBuscaLivro.Tag = dadosForm;
            dadosForm.BringToFront();
            dadosForm.Show();
        }

        // Evento do botão "Ver Mais" de cada card
        private void BtnVerMais_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Livro livro)
            {
                var formDados = new DadosLivro(); // Formulário de detalhes
                formDados.LivroParaVisualizar = livro; // Passa o livro selecionado

                // Ao fechar o formulário de detalhes, exibe o header novamente
                formDados.FormClosed += (s, args) =>
                {
                    panelHeader.Visible = true;
                   
                };

                abreDadosForm(formDados);
            }
        }

        // Evento do botão "Voltar" para fechar a tela de busca
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
