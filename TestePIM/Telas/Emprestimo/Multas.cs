using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Telas.Emprestimo
{
    public partial class Multas : Form
    {
        public Multas()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            AplicarMultasPendentes(); // novo método
            AtualizarTabela();
        }

        private void AplicarMultasPendentes()
        {
            foreach (var emp in Listas.Emprestimos)
            {
                try
                {
                    TestePIM.Controle.Emprestimo.VerificarStatus.AplicarMulta(emp);
                }
                catch
                {
                    // Você pode exibir uma notificação ou ignorar
                }
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvMultas.Columns.Clear();
            dgvMultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Título", Name = "colTitulo", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cliente", Name = "colCliente", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data Empréstimo", Name = "colDataEmprestimo", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data Prev. Devolução", Name = "colDataPrevista", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data Devolvida", Name = "colDataDevolvida", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Valor Multa (R$)", Name = "colValorMulta", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Pago", Name = "colPago", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Selecionar", Name = "chkSelecionar" });

            dgvMultas.AllowUserToAddRows = false;
            dgvMultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AtualizarTabela()
        {
            MessageBox.Show("Quantidade de multas: " + Listas.Multas.Count);

            string termo = txbBusca.Text.Trim().ToLower();

            // Filtra multas ativas (Status = true) e que correspondem ao termo
            var multasFiltradas = Listas.Multas
                .Where(m =>
                    m.Status == true &&
                    (string.IsNullOrEmpty(termo) ||
                     m.Emprestimo.Livro.Titulo.ToLower().Contains(termo) ||
                     m.Emprestimo.Cliente.Nome.ToLower().Contains(termo))
                )
                .ToList();

            dgvMultas.Rows.Clear();

            foreach (var multa in multasFiltradas)
            {
                var emp = multa.Emprestimo;
                dgvMultas.Rows.Add(
                    emp.Livro.Titulo,
                    emp.Cliente.Nome,
                    emp.DataEmprestimo.ToShortDateString(),
                    emp.DataParaDevolucao.ToShortDateString(),
                    emp.DataDevolvida.HasValue ? emp.DataDevolvida.Value.ToShortDateString() : "-",
                    multa.ValorMulta.ToString("F2"),
                    multa.Pago ? "Sim" : "Não",
                    false
                );
            }
        }

        private List<DataGridViewRow> ObterSelecionados()
        {
            return dgvMultas.Rows
                .Cast<DataGridViewRow>()
                .Where(r => Convert.ToBoolean(r.Cells["chkSelecionar"].Value))
                .ToList();
        }

        // Exemplo: marcar multas selecionadas como pagas
        private void btnMarcarPago_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();

            if (selecionados.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma multa para marcar como paga.");
                return;
            }

            foreach (var row in selecionados)
            {
                string titulo = row.Cells["colTitulo"].Value.ToString();
                string clienteNome = row.Cells["colCliente"].Value.ToString();

                var multa = Listas.Multas
                    .FirstOrDefault(m => m.Emprestimo.Livro.Titulo == titulo && m.Emprestimo.Cliente.Nome == clienteNome);

                if (multa != null)
                {
                    multa.Pago = true;
                    multa.Status = false; // Marca como resolvida
                }
            }

            AtualizarTabela();
            MessageBox.Show("Multas marcadas como pagas com sucesso!");
        }

        // Exemplo: excluir multas selecionadas
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();

            if (selecionados.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma multa para excluir.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir as multas selecionadas?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            foreach (var row in selecionados)
            {
                string titulo = row.Cells["colTitulo"].Value.ToString();
                string clienteNome = row.Cells["colCliente"].Value.ToString();

                var multa = Listas.Multas
                    .FirstOrDefault(m => m.Emprestimo.Livro.Titulo == titulo && m.Emprestimo.Cliente.Nome == clienteNome);

                if (multa != null)
                {
                    Listas.Multas.Remove(multa);
                }
            }

            AtualizarTabela();
            MessageBox.Show("Multas excluídas com sucesso!");
        }

        private void txbBusca_TextChanged(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
