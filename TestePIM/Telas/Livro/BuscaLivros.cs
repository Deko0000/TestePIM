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

            // Configura eventos
            txbBuscar.TextChanged += Filtro_TextChanged;
            cbxGenero.SelectedIndexChanged += Filtro_TextChanged;

            // Exemplo: preencher combobox com os gêneros existentes
            cbxGenero.Items.Add("Todos");
            cbxGenero.Items.AddRange(Listas.Livros.Select(l => l.Genero).Distinct().ToArray());
            cbxGenero.SelectedIndex = 0;

            // Carrega todos os livros inicialmente
            CarregarCardsLivros(Listas.Livros);
        }

        private void Filtro_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            string textoBusca = txbBuscar.Text.ToLower();
            string generoSelecionado = cbxGenero.SelectedItem?.ToString();

            var livrosFiltrados = Listas.Livros.Where(l =>
                (string.IsNullOrWhiteSpace(textoBusca) || l.Titulo.ToLower().Contains(textoBusca) || l.Autor.ToLower().Contains(textoBusca)) &&
                (generoSelecionado == "Todos" || l.Genero == generoSelecionado)
            ).ToList();

            CarregarCardsLivros(livrosFiltrados);
        }

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
                Panel card = CardBuscaLivro.CriarCard(livro, BtnVerMais_Click, cardLargura, cardAltura);

                // Posiciona o card
                card.Left = posX;
                card.Top = posY;

                panelCardsLivros.Controls.Add(card);

                posX += cardLargura + margem;

                if (posX + cardLargura > panelCardsLivros.Width)
                {
                    posX = margem;
                    posY += cardAltura + margem;
                }
            }
        }

        private Form formAtivo = null;

        private void abreDadosForm(Form dadosForm)
        {
            if (formAtivo != null)
                formAtivo.Close();

            formAtivo = dadosForm;
            dadosForm.TopLevel = false;
            dadosForm.FormBorderStyle = FormBorderStyle.None;
            dadosForm.Dock = DockStyle.Fill;
            panelHeader.Visible = false; // Esconde o header se quiser
            panelBuscaLivro.Controls.Clear(); // limpa cards e etc
            panelBuscaLivro.Controls.Add(dadosForm);
            panelBuscaLivro.Tag = dadosForm;
            dadosForm.BringToFront();
            dadosForm.Show();
        }
        private void BtnVerMais_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Livro livro)
            {
                var formDados = new DadosLivro(); // seu form de detalhes
                formDados.LivroParaVisualizar = livro; // passa o livro

                formDados.FormClosed += (s, args) =>
                {
                    panelHeader.Visible = true;
                    // se quiser, recarregue os cards aqui
                };

                abreDadosForm(formDados);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
