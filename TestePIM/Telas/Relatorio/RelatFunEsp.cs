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
    public partial class RelatFunEsp : Form
    {
        public RelatFunEsp()
        {
            InitializeComponent();
        }

        private void btnBuscaFun_Click(object sender, EventArgs e)
        {
            string termoBusca = txbNome.Text.Trim();

            // Busca funcionario por nome ou RA
            var funcionario = Listas.Funcionarios.FirstOrDefault(f =>
                f.Nome.Equals(termoBusca, StringComparison.OrdinalIgnoreCase) ||
                f.Id.ToString().Equals(termoBusca, StringComparison.OrdinalIgnoreCase));

            if (funcionario == null)
            {
                MessageBox.Show("Funcionario não encontrado!");
                return;
            }

            // Exibe dados pessoais
            lblNome.Text = funcionario.Nome;
            lblCpf.Text = funcionario.CPF;
            lblEmail.Text = funcionario.Email;
            lblMatricula.Text = funcionario.NumIdentifica;
            dtpDataNasc.Value = funcionario.DataNasc;
            lblEndereco.Text = funcionario.Endereco ?? "Não informado";

            // Filtra empréstimos do funcionario
            var emprestimosFun = Listas.Emprestimos
                .Where(emp => emp.Funcionario == funcionario)
                .ToList();

            cbxBuscaLivro.Items.Clear();
            foreach (var emp in emprestimosFun)
            {
                cbxBuscaLivro.Items.Add(emp); // Assumindo que sobrescreveu ToString()
            }

            // Estatísticas de empréstimos
            lblQuantEmp.Text = emprestimosFun.Count.ToString();

            var multas = Listas.Multas.Where(m => m.Emprestimo.Funcionario == funcionario).ToList();
            lblQuantMulta.Text = multas.Count.ToString();
           
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

            var funcionario = emprestimoSelecionado.Funcionario;
            var multa = Listas.Multas.FirstOrDefault(m => m.Emprestimo == emprestimoSelecionado);

            var relatorio = new TestePIM.Dados.Relatorio
            {
                Funcionario = funcionario,
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
