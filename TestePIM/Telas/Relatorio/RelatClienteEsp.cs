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
    public partial class RelatClienteEsp : Form
    {
        public RelatClienteEsp()
        {
            InitializeComponent();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            string termoBusca = txbNome.Text.Trim();

            // Busca cliente por nome ou RA
            var cliente = Listas.Clientes.FirstOrDefault(c =>
                c.Nome.Equals(termoBusca, StringComparison.OrdinalIgnoreCase) ||
                c.RA.Equals(termoBusca, StringComparison.OrdinalIgnoreCase));

            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado!");
                return;
            }

            // Exibe dados pessoais
            lblNome.Text = cliente.Nome;
            lblCpf.Text = cliente.CPF;
            lblEmail.Text = cliente.Email;
            lblRA.Text = cliente.RA;
            dtpDataNasc.Value = cliente.DataNasc;
            lblEndereco.Text = cliente.Endereco ?? "Não informado";

            // Filtra empréstimos do cliente
            var emprestimosCliente = Listas.Emprestimos
                .Where(emp => emp.Cliente == cliente)
                .ToList();

            cbxBuscaLivro.Items.Clear();
            foreach (var emp in emprestimosCliente)
            {
                cbxBuscaLivro.Items.Add(emp); // Assumindo que sobrescreveu ToString()
            }

            // Estatísticas de empréstimos
            lblQuantEmp.Text = emprestimosCliente.Count.ToString();

            var multas = Listas.Multas.Where(m => m.Emprestimo.Cliente == cliente).ToList();
            lblQuantMulta.Text = multas.Count.ToString();

            // Gênero mais frequente
            var generoMaisEmprestado = emprestimosCliente
                .GroupBy(emp => emp.Livro.Genero)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault()?.Key ?? "Nenhum";

            // Autor mais frequente
            var autorMaisEmprestado = emprestimosCliente
                .GroupBy(emp => emp.Livro.Autor)
                .OrderByDescending(a => a.Count())
                .FirstOrDefault()?.Key ?? "Nenhum";

            lblGenEmp.Text = generoMaisEmprestado;
            lblAutEmp.Text = autorMaisEmprestado;
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
                    var card = CardRelatCliente.CriarCard(emprestimo.Livro);
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

            var cliente = emprestimoSelecionado.Cliente;
            var multa = Listas.Multas.FirstOrDefault(m => m.Emprestimo == emprestimoSelecionado);

            var relatorio = new TestePIM.Dados.Relatorio
            {
                Cliente = cliente,
                Livro = emprestimoSelecionado.Livro,
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
