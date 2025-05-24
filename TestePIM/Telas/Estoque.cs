using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Telas
{
    public partial class Estoque : Form
    {
        private Form ativaForm = null;

        public Estoque()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CarregarLivros(Listas.Livros);
        }

        private void ConfigurarDataGridView()
        {
            dgvLivros.Columns.Clear();
            dgvLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
            idCol.HeaderText = "ID";
            idCol.Name = "colID";
            idCol.ReadOnly = true;
            dgvLivros.Columns.Add(idCol);
            

            DataGridViewTextBoxColumn tituloCol = new DataGridViewTextBoxColumn();
            tituloCol.HeaderText = "Título";
            tituloCol.Name = "colTitulo";
            tituloCol.ReadOnly = true;
            dgvLivros.Columns.Add(tituloCol);

            DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
            chkCol.HeaderText = "Selecionar";
            chkCol.Name = "chkSelecionar";
            dgvLivros.Columns.Add(chkCol);

            dgvLivros.AllowUserToAddRows = false;
        }

        private void CarregarLivros(List<Livro> livros)
        {
            dgvLivros.Rows.Clear();

            foreach (var livro in livros)            
            {                           
                dgvLivros.Rows.Add(livro.Id.ToString(), livro.Titulo, false);

            }
        }

        private void txbBuscar_TextChanged(object sender, EventArgs e)
        {
            string termo = txbBuscar.Text.Trim().ToLower();

            var filtrados = Listas.Livros
                .Where(l => l.Titulo.ToLower().Contains(termo) || l.Id.ToString().ToLower().Contains(termo))
                .ToList();

            CarregarLivros(filtrados);
        }

        private List<DataGridViewRow> ObterSelecionados()
        {
            return dgvLivros.Rows
                .Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["chkSelecionar"].Value) == true)
                .ToList();
        }

        private void abreEditForm(Form editForm)
        {
            if (ativaForm != null)
                ativaForm.Close();

            ativaForm = editForm;
            editForm.TopLevel = false;
            editForm.FormBorderStyle = FormBorderStyle.None;
            editForm.Dock = DockStyle.Fill;

            panelEstoqueLivro.Controls.Clear(); // importante
            panelHeader.Visible = false;

            panelEstoqueLivro.Controls.Add(editForm);
            panelEstoqueLivro.Tag = editForm;
            editForm.BringToFront();
            editForm.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();

            if (selecionados.Count != 1)
            {
                MessageBox.Show("Selecione exatamente um livro para editar.");
                return;
            }

            string idSelecionado = selecionados[0].Cells["colID"].Value.ToString();

            var livro = Listas.Livros.FirstOrDefault(l => l.Id.ToString() == idSelecionado);

            if (livro != null)
            {
                var formEditar = new EditarLivroEstoque();
                formEditar.LivroParaEditar = livro;

                formEditar.Cancelado += (s, args) =>
                {
                    panelEstoqueLivro.Controls.Clear();
                    panelHeader.Visible = true;
                    ativaForm = null;
                    CarregarLivros(Listas.Livros);
                };

                abreEditForm(formEditar);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();

            if (selecionados.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um livro para excluir.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir o(s) livro(s) selecionado(s)?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                foreach (var row in selecionados)
                {
                    string id = row.Cells["colID"].Value.ToString();
                    var livro = Listas.Livros.FirstOrDefault(l => l.Id.ToString() == id);

                    if (livro != null)
                        Listas.Livros.Remove(livro);
                }

                CarregarLivros(Listas.Livros);
                MessageBox.Show("Livro(s) excluído(s) com sucesso!");
            }
        }

        private void btnVerDados_Click(object sender, EventArgs e)
        {
            var selecionados = ObterSelecionados();

            if (selecionados.Count != 1)
            {
                MessageBox.Show("Selecione exatamente um livro para visualizar.");
                return;
            }

            string idSelecionado = selecionados[0].Cells["colID"].Value.ToString();

            var livro = Listas.Livros.FirstOrDefault(l => l.Id.ToString() == idSelecionado);

            if (livro != null)
            {
                var formVisualizar = new DadosLivroEstoque();
                formVisualizar.LivroParaVisualizar = livro;

                formVisualizar.Cancelado += (s, args) =>
                {
                    panelEstoqueLivro.Controls.Clear();
                    panelHeader.Visible = true;
                    ativaForm = null;
                    CarregarLivros(Listas.Livros);
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
