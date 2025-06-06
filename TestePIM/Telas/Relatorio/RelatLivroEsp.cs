using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePIM.Controle.Emprestimo;
using TestePIM.Controle.Relatorio;


namespace TestePIM.Telas.Relatorio
{
    public partial class RelatLivroEsp : Form
    {
        public RelatLivroEsp()
        {
            InitializeComponent();
        }

        private void btnBuscaLivro_Click(object sender, EventArgs e)
        {
            string termoBusca = txbTitulo.Text.Trim();

            // Busca livro por nome ou RA
            var livro = Listas.Livros.FirstOrDefault(l =>
                l.Titulo.Equals(termoBusca, StringComparison.OrdinalIgnoreCase) ||
                l.Id.ToString().Equals(termoBusca, StringComparison.OrdinalIgnoreCase));

            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado!");
                return;
            }

            // Exibe dados pessoais
            lblTitulo.Text = livro.Titulo;
            lblAutor.Text = livro.Autor;
            lblISBN.Text = livro.ISBN;
            lblGenero.Text = livro.Genero;
            lblDataPubli.Text = livro.AnoPubli;
            lblQuant.Text = livro.Quantidade.ToString();

            // Filtra empréstimos do livro
            var emprestimoslivro = Listas.Emprestimos
                .Where(emp => emp.Livro == livro)
                .ToList();

            cbxBuscaLivro.Items.Clear();
            foreach (var emp in emprestimoslivro)
            {
                cbxBuscaLivro.Items.Add(emp); // Assumindo que sobrescreveu ToString()
            }

            // Estatísticas de empréstimos
            lblQuantEmp.Text = emprestimoslivro.Count.ToString();
        }

        private void cbxBuscaLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuscaLivro.SelectedItem is TestePIM.Dados.Emprestimo emprestimo)
            {
                dtpEmp.Value = emprestimo.DataEmprestimo;
                dtpDevoluPrevista.Value = emprestimo.DataParaDevolucao;
                dtpDaDevolu.Value = emprestimo.DataDevolvida.Value;

                txbStatus.Text = emprestimo.Status ? "Devolvido" : "Devolvido com Atraso";

                // Verifica multa correspondente
                var multa = Listas.Multas.FirstOrDefault(m => m.Emprestimo == emprestimo);
                txbMulta.Text = multa != null ? multa.ValorMulta.ToString("C") : "R$ 0,00";

                // Gera card do livro
                panelLivro.Controls.Clear();
                if (emprestimo.Livro != null)
                {
                    var card = CardLivroEmp.CriarCard(emprestimo.Livro);
                    card.Left = (panelLivro.Width - card.Width) / 2;
                    panelLivro.Controls.Add(card);
                }
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (cbxBuscaLivro.Items.Count == 0 || !(cbxBuscaLivro.SelectedItem is TestePIM.Dados.Emprestimo))
            {
                MessageBox.Show("Nenhum empréstimo disponível ou selecionado.");
                return;
            }

            TestePIM.Dados.Emprestimo emprestimoSelecionado = (TestePIM.Dados.Emprestimo)cbxBuscaLivro.SelectedItem;

            var livro = emprestimoSelecionado.Livro;
            var multa = Listas.Multas.FirstOrDefault(m => m.Emprestimo == emprestimoSelecionado);

            var relatorio = new TestePIM.Dados.Relatorio
            {
                Livro = livro,
                Cliente = emprestimoSelecionado.Cliente,
                Emprestimo = emprestimoSelecionado,
                Multa = multa
            };

            relatorio.DefinirIdentificacao(); // Gera um ID único
            Listas.Relatorios.Add(relatorio); // Crie essa lista estática para armazenar os relatórios

            MessageBox.Show("Relatório registrado com sucesso!");
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
