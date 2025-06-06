using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Telas.Relatorio
{
    public partial class GerenciaRelat : Form
    {
        public GerenciaRelat()
        {
            InitializeComponent();
            ConfigurarGrid();
            CarregarRelatorios();
        }

        // Configura as colunas do DataGridView
        private void ConfigurarGrid()
        {
            dgvRelat.Columns.Clear();
            dgvRelat.AutoGenerateColumns = false;
            dgvRelat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelat.MultiSelect = false;

            dgvRelat.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "",
                Width = 30
            });

            dgvRelat.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 40
            });

            dgvRelat.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cliente",
                DataPropertyName = "ClienteNome",
                Width = 150
            });

            dgvRelat.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Funcionário",
                DataPropertyName = "FuncionarioNome",
                Width = 150
            });

            dgvRelat.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Livro",
                DataPropertyName = "LivroTitulo",
                Width = 200
            });
        }

        // Carrega a lista de relatórios no DataGridView
        private void CarregarRelatorios(string filtro = "")
        {
            var dados = Listas.Relatorios
                .Where(r =>
                    (r.Cliente?.Nome?.ToLower().Contains(filtro.ToLower()) ?? false) ||
                    (r.Funcionario?.Nome?.ToLower().Contains(filtro.ToLower()) ?? false))
                .Select(r => new
                {
                    Selecionado = false,
                    r.Id,
                    ClienteNome = r.Cliente?.Nome ?? "N/A",
                    FuncionarioNome = r.Funcionario?.Nome ?? "N/A",
                    LivroTitulo = r.Livro?.Titulo ?? "N/A"
                }).ToList();

            dgvRelat.DataSource = dados;
        }

        // Botão de filtro
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarRelatorios(txbFiltro.Text);
        }

        // Botão para excluir relatório selecionado
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvRelat.Rows.Count == 0) return;

            foreach (DataGridViewRow row in dgvRelat.Rows)
            {
                bool marcado = Convert.ToBoolean(row.Cells[0].Value);
                if (marcado)
                {
                    int id = Convert.ToInt32(row.Cells[1].Value);
                    var relatorio = Listas.Relatorios.FirstOrDefault(r => r.Id == id);
                    if (relatorio != null)
                        Listas.Relatorios.Remove(relatorio);
                }
            }

            CarregarRelatorios(txbFiltro.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
