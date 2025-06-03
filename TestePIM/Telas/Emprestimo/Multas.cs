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
        // Guarda referência ao formulário atualmente aberto dentro do painel
        private Form ativaForm = null;
        public Multas()
        {
            InitializeComponent();
            ConfigurarDataGridView(); // Configura as colunas do DataGridView
            CarregarMultas(Listas.Multas); // Carrega os livros na grid

        }

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

            panelListaMulta.Controls.Clear();
            panelListaMulta.Controls.Add(form);
            panelListaMulta.Tag = form;
            form.BringToFront();
            form.Show();

            form.FormClosed += (s, args) =>
            {
                panelHeader.Visible = true;
                panelBusca.Visible = true;
                AtualizarTabela(); // Garante atualização ao voltar
            };
        }

        // Configura as colunas do DataGridView de livros
        private void ConfigurarDataGridView()
        {
            dgvMultas.Columns.Clear();
            dgvMultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Coluna de ID (somente leitura)
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.HeaderText = "ID";
            idCol.Name = "colID";
            idCol.ReadOnly = true;
            dgvMultas.Columns.Add(idCol);

            // Coluna de Título (somente leitura)
            DataGridViewTextBoxColumn clienteCol = new DataGridViewTextBoxColumn();
            clienteCol.HeaderText = "Cliente";
            clienteCol.Name = "colCliente";
            clienteCol.ReadOnly = true;
            dgvMultas.Columns.Add(clienteCol);

            // Coluna de Título (somente leitura)
            DataGridViewTextBoxColumn funCol = new DataGridViewTextBoxColumn();
            funCol.HeaderText = "Cliente";
            funCol.Name = "colCliente";
            funCol.ReadOnly = true;
            dgvMultas.Columns.Add(funCol);

            // Coluna de seleção (checkbox)
            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.HeaderText = "Selecionar";
            chkCol.Name = "chkSelecionar";
            dgvMultas.Columns.Add(chkCol);

            dgvMultas.AllowUserToAddRows = false;
        }

        private void CarregarMultas(List<TestePIM.Dados.Emprestimo> multas)
        {
            dgvMultas.Rows.Clear();

            foreach (var multa in multas)
            {
                dgvMultas.Rows.Add(multa.Cliente, multa.Funcionario, multa.Livro, false);
            }
        }

        private bool aplicarFiltroDatas = false;
        private void AtualizarTabela()
        {
            string termo = txbBusca.Text.Trim().ToLower();
            string statusSelecionado = cbxStatus.SelectedItem?.ToString();
            DateTime inicio = dtpInicio.Value.Date;
            DateTime final = dtpFinal.Value.Date;

            var multasFiltradas = Listas.Emprestimos
                .Where(m =>
                    (string.IsNullOrEmpty(termo) ||
                     m.Livro.Titulo.ToLower().Contains(termo) ||
                     m.Funcionario.Nome.ToLower().Contains(termo) ||
                     m.Cliente.Nome.ToLower().Contains(termo)) &&

                    (statusSelecionado == "Todos" ||                    
                     (statusSelecionado == "Atrasados" && m.Status && m.DataDevolucao < DateTime.Today) ||                     
                     (statusSelecionado == "Devolvidos com atraso" && !e.Status && e.DataDevolvida > e.DataParaDevolucao)) &&

                    (!aplicarFiltroDatas || (e.DataEmprestimo.Date >= inicio && e.DataEmprestimo.Date <= final))
                )
                .ToList();

            dgvMultas.Rows.Clear();

            foreach (var mul in multasFiltradas)
            {
                string status;

                if (!mul.Status) // Já devolvido
                {
                    status = mul.DataDevolvida > mul.DataParaDevolucao
                        ? "Devolvido com atraso"
                        : "Devolvido";
                }
                else // Ainda ativo
                {
                    status = mul.DataParaDevolucao < DateTime.Today
                        ? "Atrasado"
                        : "Ativo";
                }

                dgvMultas.Rows.Add
                (
                    mul.Multa.Cliente,
                    emp.Cliente.Nome,
                    emp.DataEmprestimo.ToShortDateString(),
                    emp.DataParaDevolucao.ToShortDateString(),
                    emp.Status ? "-" : (emp.DataDevolvida.HasValue ? emp.DataDevolvida.Value.ToShortDateString() : "-"),
                    status, false
                );
            }
        }
        // Retorna as linhas selecionadas pelo usuário (checkbox marcado)
        private List<DataGridViewRow> ObterSelecionados()
        {
            return dgvMultas.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["chkSelecionar"].Value) == true)
                .ToList();
        }

        private void ReorganizarIDs()
        {
            var livrosOrdenados = Listas.Livros.OrderBy(l => l.Id).ToList();

            // Limpa a lista original e adiciona os livros ordenados
            Listas.Livros.Clear();
            Listas.Livros.AddRange(livrosOrdenados);

            // Reatribui os IDs de 1 até N
            int novoId = 1;
            foreach (var livro in Listas.Livros)
            {
                livro.Id = novoId;
                novoId++;
            }

            // Atualiza o último ID na classe GerarIdentificacao
            GerarIdentificacao.ReajustarUltimoIdLivro(novoId - 1);
        }

        // Evento do botão Excluir: remove os livros selecionados da lista
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();

            if (selecionados.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos ums multa para excluir.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir a(s) multa(s) selecionada(s)?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                foreach (var row in selecionados)
                {
                    string id = row.Cells["colID"].Value.ToString();
                    var multa = Listas.Multas.FirstOrDefault(m => m.Id.ToString() == id);

                    if (multa != null)
                        Listas.Multas.Remove(multa);
                }

                // Reorganiza IDs após exclusão
                ReorganizarIDs();

                // Recarrega a grid
                CarregarMultas(Listas.Multas);
                MessageBox.Show("Multa(s) excluída(s) com sucesso!");
            }
        }
    }
}
