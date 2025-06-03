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
            AtualizarTabela();
        }

        private void VerificaMultas_Load(object sender, EventArgs e)
        {
            dtpInicio.Value = DateTime.Today.AddMonths(-1);
            dtpFinal.Value = DateTime.Today;
        }

        private void ConfigurarDataGridView()
        {
            dgvMultas.Columns.Clear();
            dgvMultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Título", Name = "colTitulo", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cliente", Name = "colCliente", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data Empréstimo", Name = "colDataEmprestimo", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Prev. Devolução", Name = "colDataPrevista", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data Devolvida", Name = "colDataDevolvida", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Dias em Atraso", Name = "colDiasAtraso", ReadOnly = true });
            dgvMultas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Multa (R$)", Name = "colMulta", ReadOnly = true });

            dgvMultas.AllowUserToAddRows = false;
            dgvMultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private bool aplicarFiltroDatas = false;

        private void AtualizarTabela()
        {
            string termo = txbBusca.Text.Trim().ToLower();
            DateTime inicio = dtpInicio.Value.Date;
            DateTime final = dtpFinal.Value.Date;

            var emprestimosComMulta = Listas.Emprestimos
                .Where(e =>
                    // Filtro de multa
                    (!e.Status && e.DataDevolvida.HasValue && e.DataDevolvida.Value > e.DataParaDevolucao) || // devolvido com atraso
                    (e.Status && e.DataParaDevolucao < DateTime.Today) // ainda ativo e atrasado
                )
                .Where(e =>
                    // Filtro por período
                    !aplicarFiltroDatas || (e.DataEmprestimo.Date >= inicio && e.DataEmprestimo.Date <= final)
                )
                .Where(e =>
                    // Filtro por texto
                    string.IsNullOrEmpty(termo) ||
                    e.Livro.Titulo.ToLower().Contains(termo) ||
                    e.Cliente.Nome.ToLower().Contains(termo)
                )
                .ToList();

            dgvMultas.Rows.Clear();

            foreach (var emp in emprestimosComMulta)
            {
                int diasAtraso = 0;
                if (!emp.Status && emp.DataDevolvida.HasValue)
                    diasAtraso = (emp.DataDevolvida.Value - emp.DataParaDevolucao).Days;
                else if (emp.Status)
                    diasAtraso = (DateTime.Today - emp.DataParaDevolucao).Days;

                decimal valorMulta = CalcularMulta(diasAtraso);

                dgvMultas.Rows.Add(
                    emp.Livro.Titulo,
                    emp.Cliente.Nome,
                    emp.DataEmprestimo.ToShortDateString(),
                    emp.DataParaDevolucao.ToShortDateString(),
                    emp.Status ? "-" : emp.DataDevolvida?.ToShortDateString(),
                    diasAtraso,
                    valorMulta.ToString("C")
                );
            }
        }

        private decimal CalcularMulta(int diasAtraso)
        {
            return diasAtraso * 1.50m; // Exemplo: R$1,50 por dia
        }

        private void txbBusca_TextChanged(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            aplicarFiltroDatas = true;
            AtualizarTabela();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            aplicarFiltroDatas = false;
            AtualizarTabela();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
