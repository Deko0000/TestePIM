using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Telas
{
    public partial class FuncionariosCadastrados : Form
    {
        public FuncionariosCadastrados()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarFuncionarios(Listas.Funcionarios);
        }




        private void ConfigurarDataGridView()
        {
            dgvFuncionarios.Columns.Clear();
            dgvFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // Coluna Nome
            DataGridViewTextBoxColumn nomeCol = new DataGridViewTextBoxColumn();
            nomeCol.HeaderText = "Nome";
            nomeCol.Name = "colNome";
            nomeCol.ReadOnly = true;
            dgvFuncionarios.Columns.Add(nomeCol);

            // Coluna RA
            DataGridViewTextBoxColumn matriculaCol = new DataGridViewTextBoxColumn();
            matriculaCol.HeaderText = "Matrícula";
            matriculaCol.Name = "colMatricula";
            matriculaCol.ReadOnly = true;
            dgvFuncionarios.Columns.Add(matriculaCol);

            // Coluna de seleção
            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.HeaderText = "Selecionar";
            chkCol.Name = "chkSelecionar";
            dgvFuncionarios.Columns.Add(chkCol);

            dgvFuncionarios.AllowUserToAddRows = false;
        }

        private void CarregarFuncionarios(List<Funcionario> funcionarios)
        {
            dgvFuncionarios.Rows.Clear();

            foreach (var funcionario in funcionarios)
            {
                dgvFuncionarios.Rows.Add(funcionario.Nome, funcionario.NumIdentifica, false);
            }
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            string termo = txbBuscar.Text.Trim().ToLower();

            var filtrados = Listas.Funcionarios
                .Where(f => f.Nome.ToLower().Contains(termo) || f.NumIdentifica.ToLower().Contains(termo))
                .ToList();

            CarregarFuncionarios(filtrados);
        }

        private List<DataGridViewRow> ObterSelecionados()
        {
            return dgvFuncionarios.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["chkSelecionar"].Value))
                .ToList();
        }

        private Form ativaForm = null;
        private void abreEditForm(Form editForm)
        {
            if (ativaForm != null)
                ativaForm.Close();

            ativaForm = editForm;
            editForm.TopLevel = false;
            editForm.FormBorderStyle = FormBorderStyle.None;
            editForm.Dock = DockStyle.Fill;
            panelHeader.Visible = false;
            panelDataGrid.Visible = false;// sempre oculta ao abrir um form interno
            panelFunCadastrados.Controls.Add(editForm);
            panelFunCadastrados.Tag = editForm;
            editForm.BringToFront();
            editForm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();

            if (selecionados.Count != 1)
            {
                MessageBox.Show("Selecione exatamente um funcionário para editar.");
                return;
            }

            string matriculaSelecionada = selecionados[0].Cells["colMatricula"].Value.ToString();

            var funcionario = Listas.Funcionarios.FirstOrDefault(f => f.NumIdentifica == matriculaSelecionada);

            if (funcionario != null)
            {
                var formEditar = new EditarFuncionario();
                formEditar.FuncionarioParaEditar = funcionario;

                // Assina o evento FormClosed para quando fechar a edição mostrar o panelHeader de novo
                formEditar.FormClosed += (s, args) =>
                {
                    panelDataGrid.Visible = true;
                    panelHeader.Visible = true;
                     // Volta a mostrar o panelHeader
                    CarregarFuncionarios(Listas.Funcionarios); // Recarrega clientes atualizados
                };

                abreEditForm(formEditar);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();

            if (selecionados.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um funcionário para excluir.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir os funcionários selecionados?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                foreach (var row in selecionados)
                {
                    string matricula = row.Cells["colMatricula"].Value.ToString();
                    var funcionario = Listas.Funcionarios.FirstOrDefault(f => f.NumIdentifica == matricula);

                    if (funcionario != null)
                        Listas.Funcionarios.Remove(funcionario);
                }

                CarregarFuncionarios(Listas.Funcionarios);
                MessageBox.Show("Funcionário(s) excluído(s) com sucesso!");
            }
        }

        private void btnVerDados_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();

            if (selecionados.Count != 1)
            {
                MessageBox.Show("Selecione exatamente um funcionário para visualizar.");
                return;
            }

            string matriculaSelecionada = selecionados[0].Cells["colMatricula"].Value.ToString();

            var funcionario = Listas.Funcionarios.FirstOrDefault(f => f.NumIdentifica == matriculaSelecionada);

            if (funcionario != null)
            {
                var formVisualizar = new VerDadosFuncionario();
                formVisualizar.FuncionarioParaVisualizar = funcionario;

                // Assina o evento FormClosed para quando fechar a edição mostrar o panelHeader de novo
                formVisualizar.FormClosed += (s, args) =>
                {
                    panelHeader.Visible = true;
                    panelDataGrid.Visible = true;// Volta a mostrar o panelHeader
                    CarregarFuncionarios(Listas.Funcionarios); // Recarrega clientes atualizados
                };

                abreEditForm(formVisualizar);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
