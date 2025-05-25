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
    public partial class ClientesCadastrados : Form
    {
        public ClientesCadastrados()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarClientes(Listas.Clientes);
        }

        // Configura as colunas do DataGridView para exibir os clientes
        private void ConfigurarDataGridView()
        {
            dgvClientes.Columns.Clear();
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Coluna Nome
            DataGridViewTextBoxColumn nomeCol = new DataGridViewTextBoxColumn();
            nomeCol.HeaderText = "Nome";
            nomeCol.Name = "colNome";
            nomeCol.ReadOnly = true;
            dgvClientes.Columns.Add(nomeCol);

            // Coluna RA
            DataGridViewTextBoxColumn raCol = new DataGridViewTextBoxColumn();
            raCol.HeaderText = "RA";
            raCol.Name = "colRA";
            raCol.ReadOnly = true;
            dgvClientes.Columns.Add(raCol);

            // Coluna de seleção (checkbox)
            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.HeaderText = "Selecionar";
            chkCol.Name = "chkSelecionar";
            dgvClientes.Columns.Add(chkCol);

            dgvClientes.AllowUserToAddRows = false;
        }

        // Carrega a lista de clientes no DataGridView
        private void CarregarClientes(List<Cliente> clientes)
        {
            dgvClientes.Rows.Clear();

            foreach (var cliente in clientes)
            {
                dgvClientes.Rows.Add(cliente.Nome, cliente.RA, false);
            }
        }

        // Filtra os clientes conforme o texto digitado na busca
        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            string termo = txbBuscar.Text.Trim().ToLower();

            var filtrados = Listas.Clientes
                .Where(c => c.Nome.ToLower().Contains(termo) || c.RA.ToLower().Contains(termo))
                .ToList();

            CarregarClientes(filtrados);
        }

        // Retorna as linhas selecionadas no DataGridView
        private List<DataGridViewRow> ObterSelecionados()
        {
            return dgvClientes.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["chkSelecionar"].Value))
                .ToList();
        }

        private Form ativaForm = null;

        // Abre um formulário interno para edição ou visualização
        private void abreEditForm(Form editForm)
        {
            if (ativaForm != null)
                ativaForm.Close();

            ativaForm = editForm;
            editForm.TopLevel = false;
            editForm.FormBorderStyle = FormBorderStyle.None;
            editForm.Dock = DockStyle.Fill;
            panelHeader.Visible = false;  // sempre oculta ao abrir um form interno
            panelClientesCadastrados.Controls.Add(editForm);
            panelClientesCadastrados.Tag = editForm;
            editForm.BringToFront();
            editForm.Show();
        }

        // Evento do botão Editar: abre o formulário de edição para o cliente selecionado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();

            if (selecionados.Count != 1)
            {
                MessageBox.Show("Selecione exatamente um cliente para editar.");
                return;
            }

            string raSelecionado = selecionados[0].Cells["colRA"].Value.ToString();

            var cliente = Listas.Clientes.FirstOrDefault(c => c.RA == raSelecionado);

            if (cliente != null)
            {
                var formEditar = new EditarCliente();
                formEditar.ClienteParaEditar = cliente;

                // Ao fechar o formulário de edição, exibe novamente o cabeçalho e recarrega os clientes
                formEditar.FormClosed += (s, args) =>
                {
                    panelHeader.Visible = true;   // Volta a mostrar o panelHeader
                    CarregarClientes(Listas.Clientes); // Recarrega clientes atualizados
                };

                abreEditForm(formEditar);
            }
        }

        // Evento do botão Excluir: remove os clientes selecionados
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();

            if (selecionados.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um cliente para excluir.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir os clientes selecionados?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                foreach (var row in selecionados)
                {
                    string ra = row.Cells["colRA"].Value.ToString();
                    var cliente = Listas.Clientes.FirstOrDefault(c => c.RA == ra);

                    if (cliente != null)
                        Listas.Clientes.Remove(cliente);
                }

                CarregarClientes(Listas.Clientes);
                MessageBox.Show("Cliente(s) excluído(s) com sucesso!");
            }
        }

        // Evento do botão Ver Dados: abre o formulário de visualização para o cliente selecionado
        private void btnVerDados_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();

            if (selecionados.Count != 1)
            {
                MessageBox.Show("Selecione exatamente um cliente para visualizar.");
                return;
            }

            string raSelecionado = selecionados[0].Cells["colRA"].Value.ToString();

            var cliente = Listas.Clientes.FirstOrDefault(c => c.RA == raSelecionado);

            if (cliente != null)
            {
                var formVisualizar = new VerDadosCliente();
                formVisualizar.ClienteParaVisualizar = cliente;

                // Ao fechar o formulário de visualização, exibe novamente o cabeçalho e recarrega os clientes
                formVisualizar.FormClosed += (s, args) =>
                {
                    panelHeader.Visible = true;   // Volta a mostrar o panelHeader
                    CarregarClientes(Listas.Clientes); // Recarrega clientes atualizados
                };

                abreEditForm(formVisualizar);
            }
        }

        // Evento do botão Voltar: fecha o formulário atual
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
