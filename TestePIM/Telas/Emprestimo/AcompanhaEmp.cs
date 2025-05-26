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
            ConfigurarDataGridView(); // Configura as colunas do DataGridView
            AtualizarTabela(); // Preenche a tabela com os dados filtrados
        }

        private void AcompanhaEmp_Load(object sender, EventArgs e)
        {
            // Preenche o ComboBox de status com as opções disponíveis
            cbxStatus.Items.Clear();
            cbxStatus.Items.AddRange(new string[] { "Todos", "Ativos", "Atrasados", "Devolvidos", "Devolvidos com atraso" });
            cbxStatus.SelectedIndex = 0;
        }

        private void ConfigurarDataGridView()
        {
            // Configura as colunas do DataGridView de empréstimos
            dgvEmprestimos.Columns.Clear();
            dgvEmprestimos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Título", Name = "colTitulo", ReadOnly = true });
            dgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cliente", Name = "colCliente", ReadOnly = true });
            dgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data Empréstimo", Name = "colDataEmprestimo", ReadOnly = true });
            dgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Data Devolução", Name = "colDataDevolucao", ReadOnly = true });
            dgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", Name = "colStatus", ReadOnly = true });

            dgvEmprestimos.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Selecionar", Name = "chkSelecionar" });

            dgvEmprestimos.AllowUserToAddRows = false;
            dgvEmprestimos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AtualizarTabela()
        {
            // Atualiza a tabela de empréstimos conforme os filtros aplicados
            string termo = txbBusca.Text.Trim().ToLower();
            string statusSelecionado = cbxStatus.SelectedItem?.ToString();

            DateTime inicio = dtpInicio.Value.Date;
            DateTime final = dtpFinal.Value.Date;
            DateTime dataDaDevolucao = DataParaDevolucao.Value.Date;

            var emprestimosFiltrados = Listas.Emprestimos
                
                .Where(e =>
                    (string.IsNullOrEmpty(termo) ||
                     e.Livro.Titulo.ToLower().Contains(termo) ||
                     e.Cliente.Nome.ToLower().Contains(termo)) &&

                    (statusSelecionado == "Todos" ||
                     (statusSelecionado == "Ativos" && e.Status && e.DataParaDevolucao >= DateTime.Today) ||
                     (statusSelecionado == "Atrasados" && e.Status && e.DataParaDevolucao < DateTime.Today) ||
                     (statusSelecionado == "Devolvidos" && !e.Status && e.DataParaDevolucao <= e.DataEmprestimo.AddDays(7)) ||
                     (statusSelecionado == "Devolvidos com atraso" && !e.Status && e.DataParaDevolucao > e.DataParaDevolucao.AddDays(30))) &&

                    (e.DataEmprestimo.Date >= inicio && e.DataEmprestimo.Date <= final)
                )
                .ToList();

            dgvEmprestimos.Rows.Clear();

            foreach (var emp in emprestimosFiltrados)
            {
                string status;

                if (!emp.Status)
                {
                    // Se já foi devolvido, verifica se foi no prazo ou com atraso
                    status = emp.DataDevolucao <= emp.DataDevolucao.AddDays(30)
                        ? "Devolvido"
                        : "Devolvido com atraso";
                }
                else
                {
                    // Se ainda está ativo, verifica se está atrasado
                    status = emp.DataDevolucao < DateTime.Today
                        ? "Atrasado"
                        : "Ativo";
                }

                dgvEmprestimos.Rows.Add(
                    emp.Livro.Titulo,
                    emp.Cliente.Nome,
                    emp.DataEmprestimo.ToShortDateString(),
                    emp.DataDevolucao == DateTime.MinValue ? "-" : emp.DataDevolucao.ToShortDateString(),
                    status,
                    false);
            }
        }

        private List<DataGridViewRow> ObterSelecionados()
        {
            // Retorna a lista de linhas selecionadas pelo usuário
            return dgvEmprestimos.Rows
                .Cast<DataGridViewRow>()
                .Where(r => Convert.ToBoolean(r.Cells["chkSelecionar"].Value))
                .ToList();
        }

        private Form ativaForm = null; // Guarda referência ao formulário filho ativo

        private void abreEmpForm(Form form)
        {
            // Abre um formulário filho dentro do painel, ocultando cabeçalho e busca
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
                // Restaura a visibilidade dos painéis ao fechar o formulário filho
                panelHeader.Visible = true;
                panelBusca.Visible = true;
            };
        }

        private void txbBusca_TextChanged(object sender, EventArgs e)
        {
            // Atualiza a tabela ao digitar na busca
            AtualizarTabela();
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Atualiza a tabela ao trocar o status selecionado
            AtualizarTabela();
        }

        private void btnBuscaPeriodo_Click(object sender, EventArgs e)
        {
            // Atualiza a tabela ao clicar para buscar por período
            AtualizarTabela();
        }

        private void btnVerDetalhes_Click(object sender, EventArgs e)
        {
            // Abre o formulário de detalhes do empréstimo selecionado
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

                formDetalhes.FormClosed += (s, args) =>
                {
                    panelHeader.Visible = true;
                    panelBusca.Visible = true;
                };

                abreEmpForm(formDetalhes);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            // Abre o formulário de devolução para o empréstimo selecionado
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
                formDevolucao.FormClosed += (s, args) => AtualizarTabela();
                abreEmpForm(formDevolucao);
            }
            else
            {
                MessageBox.Show("Este empréstimo já foi devolvido.");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
        }
    }
}
