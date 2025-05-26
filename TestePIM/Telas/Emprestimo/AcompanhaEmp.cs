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
    public partial class AcompanhaEmp : Form
    {
        public AcompanhaEmp()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            AtualizarTabela();
        }

        private void AcompanhaEmp_Load(object sender, EventArgs e)
        {
            cbxStatus.Items.Clear();
            cbxStatus.Items.AddRange(new string[] { "Todos", "Ativos", "Atrasados", "Devolvidos", "Devolvidos com atraso" });
            cbxStatus.SelectedIndex = 0;
        }

        private void ConfigurarDataGridView()
        {
            dgvEmprestimos.Columns.Clear();
            dgvEmprestimos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Título", Name = "colTitulo", ReadOnly = true });
            dgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cliente", Name = "colCliente", ReadOnly = true });
            dgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data Empréstimo", Name = "colDataEmprestimo", ReadOnly = true });
            dgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data Prev. Devolução", Name = "colDataPrevista", ReadOnly = true });
            dgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data Devolvida", Name = "colDataDevolvida", ReadOnly = true });
            dgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", Name = "colStatus", ReadOnly = true });

            dgvEmprestimos.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Selecionar", Name = "chkSelecionar" });

            dgvEmprestimos.AllowUserToAddRows = false;
            dgvEmprestimos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private bool aplicarFiltroDatas = false;
        private void AtualizarTabela()
        {
            string termo = txbBusca.Text.Trim().ToLower();
            string statusSelecionado = cbxStatus.SelectedItem?.ToString();
            DateTime inicio = dtpInicio.Value.Date;
            DateTime final = dtpFinal.Value.Date;

            var emprestimosFiltrados = Listas.Emprestimos
                .Where(e =>
                    (string.IsNullOrEmpty(termo) ||
                     e.Livro.Titulo.ToLower().Contains(termo) ||
                     e.Cliente.Nome.ToLower().Contains(termo)) &&

                    (statusSelecionado == "Todos" ||
                     (statusSelecionado == "Ativos" && e.Status && e.DataParaDevolucao >= DateTime.Today) ||
                     (statusSelecionado == "Atrasados" && e.Status && e.DataParaDevolucao < DateTime.Today) ||
                     (statusSelecionado == "Devolvidos" && !e.Status && e.DataDevolvida <= e.DataParaDevolucao) ||
                     (statusSelecionado == "Devolvidos com atraso" && !e.Status && e.DataDevolvida > e.DataParaDevolucao)) &&

                    (!aplicarFiltroDatas || (e.DataEmprestimo.Date >= inicio && e.DataEmprestimo.Date <= final))
                )
                .ToList();

            dgvEmprestimos.Rows.Clear();

            foreach (var emp in emprestimosFiltrados)
            {
                string status;

                if (!emp.Status) // Já devolvido
                {
                    status = emp.DataDevolvida > emp.DataParaDevolucao
                        ? "Devolvido com atraso"
                        : "Devolvido";
                }
                else // Ainda ativo
                {
                    status = emp.DataParaDevolucao < DateTime.Today
                        ? "Atrasado"
                        : "Ativo";
                }

                dgvEmprestimos.Rows.Add
                (
                    emp.Livro.Titulo,
                    emp.Cliente.Nome,
                    emp.DataEmprestimo.ToShortDateString(),
                    emp.DataParaDevolucao.ToShortDateString(),
                    emp.Status ? "-" : (emp.DataDevolvida.HasValue ? emp.DataDevolvida.Value.ToShortDateString() : "-"),
                    status, false
                );
            }
        }

        private List<DataGridViewRow> ObterSelecionados()
        {
            return dgvEmprestimos.Rows
                .Cast<DataGridViewRow>()
                .Where(r => Convert.ToBoolean(r.Cells["chkSelecionar"].Value))
                .ToList();
        }

        private Form ativaForm = null;

        private void abreEmpForm(Form form)
        {
            if (ativaForm != null)
                ativaForm.Close();

            ativaForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelHeader.Visible = false;
            panelBusca.Visible = false;

            panelAcomEmp.Controls.Clear();
            panelAcomEmp.Controls.Add(form);
            panelAcomEmp.Tag = form;
            form.BringToFront();
            form.Show();

            form.FormClosed += (s, args) =>
            {
                panelHeader.Visible = true;
                panelBusca.Visible = true;
                AtualizarTabela(); // Garante atualização ao voltar
            };
        }

        private void txbBusca_TextChanged(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void btnBuscaPeriodo_Click(object sender, EventArgs e)
        {
            aplicarFiltroDatas = true;
            AtualizarTabela();
        }
        private void btnLimparPeriodo_Click(object sender, EventArgs e)
        {
            aplicarFiltroDatas = false;
            AtualizarTabela();
        }

        private void btnVerDetalhes_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();
            if (selecionados.Count != 1)
            {
                MessageBox.Show("Selecione exatamente um empréstimo para visualizar.");
                return;
            }

            string titulo = selecionados[0].Cells["colTitulo"].Value.ToString();
            string clienteNome = selecionados[0].Cells["colCliente"].Value.ToString();

            var emprestimo = Listas.Emprestimos
                .FirstOrDefault(em => em.Livro.Titulo == titulo && em.Cliente.Nome == clienteNome);

            if (emprestimo != null)
            {
                var formDetalhes = new DetalhesEmp
                {
                    EmprestimoParaVisualizar = emprestimo
                };

                abreEmpForm(formDetalhes);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();
            if (selecionados.Count != 1)
            {
                MessageBox.Show("Selecione exatamente um empréstimo para fazer a devolução.");
                return;
            }

            string titulo = selecionados[0].Cells["colTitulo"].Value.ToString();
            string clienteNome = selecionados[0].Cells["colCliente"].Value.ToString();

            var emprestimo = Listas.Emprestimos
                .FirstOrDefault(em => em.Livro.Titulo == titulo && em.Cliente.Nome == clienteNome);

            if (emprestimo != null && emprestimo.Status)
            {
                var formDevolucao = new DevoluEmp(emprestimo);
                formDevolucao.EmprestimoParaDevolver = emprestimo;
                abreEmpForm(formDevolucao);
            }
            else
            {
                MessageBox.Show("Este empréstimo já foi devolvido.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();            
            
        }

        
    }
}
