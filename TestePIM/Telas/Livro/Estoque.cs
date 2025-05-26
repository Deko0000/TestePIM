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
            // Guarda referência ao formulário atualmente aberto dentro do painel
            private Form ativaForm = null;

            public Estoque()
            {
                InitializeComponent();
                ConfigurarDataGridView(); // Configura as colunas do DataGridView
                CarregarLivros(Listas.Livros); // Carrega os livros na grid
            }

            // Configura as colunas do DataGridView de livros
            private void ConfigurarDataGridView()
            {
                dgvLivros.Columns.Clear();
                dgvLivros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Coluna de ID (somente leitura)
                DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn();
                idCol.HeaderText = "ID";
                idCol.Name = "colID";
                idCol.ReadOnly = true;
                dgvLivros.Columns.Add(idCol);

                // Coluna de Título (somente leitura)
                DataGridViewTextBoxColumn tituloCol = new DataGridViewTextBoxColumn();
                tituloCol.HeaderText = "Título";
                tituloCol.Name = "colTitulo";
                tituloCol.ReadOnly = true;
                dgvLivros.Columns.Add(tituloCol);

                // Coluna de seleção (checkbox)
                DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
                chkCol.HeaderText = "Selecionar";
                chkCol.Name = "chkSelecionar";
                dgvLivros.Columns.Add(chkCol);

                dgvLivros.AllowUserToAddRows = false;
            }

            // Carrega a lista de livros no DataGridView
            private void CarregarLivros(List<Livro> livros)
            {
                dgvLivros.Rows.Clear();

                foreach (var livro in livros)
                {
                    dgvLivros.Rows.Add(livro.Id.ToString(), livro.Titulo, false);
                }
            }

            // Filtra os livros conforme o texto digitado na busca
            private void txbBuscar_TextChanged(object sender, EventArgs e)
            {
                string termo = txbBuscar.Text.Trim().ToLower();

                var filtrados = Listas.Livros
                    .Where(l => l.Titulo.ToLower().Contains(termo) || l.Id.ToString().ToLower().Contains(termo))
                    .ToList();

                CarregarLivros(filtrados);
            }

            // Retorna as linhas selecionadas pelo usuário (checkbox marcado)
            private List<DataGridViewRow> ObterSelecionados()
            {
                return dgvLivros.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => Convert.ToBoolean(row.Cells["chkSelecionar"].Value) == true)
                    .ToList();
            }

            // Abre um formulário de edição/visualização dentro do painel
            private void abreEditForm(Form editForm)
            {
                if (ativaForm != null)
                    ativaForm.Close();

                ativaForm = editForm;
                editForm.TopLevel = false;
                editForm.FormBorderStyle = FormBorderStyle.None;
                editForm.Dock = DockStyle.Fill;

                panelEstoqueLivro.Controls.Clear(); // Limpa o painel antes de adicionar o novo form
                panelHeader.Visible = false;

                panelEstoqueLivro.Controls.Add(editForm);
                panelEstoqueLivro.Tag = editForm;
                editForm.BringToFront();
                editForm.Show();
            }

            // Evento do botão Editar: abre o formulário de edição para o livro selecionado
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

                    // Evento para quando o usuário cancelar a edição
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

                    // Reorganiza IDs após exclusão
                    ReorganizarIDs();

                    // Recarrega a grid
                    CarregarLivros(Listas.Livros);
                    MessageBox.Show("Livro(s) excluído(s) com sucesso!");
                }
            }

            // Evento do botão Ver Dados: abre o formulário de visualização para o livro selecionado
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

                    // Evento para quando o usuário fechar a visualização
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

            // Evento do botão Voltar: fecha o formulário de estoque
            private void btnVoltar_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
