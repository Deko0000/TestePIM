using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePIM.Dados;
using TestePIM.Controle.Emprestimo;

namespace TestePIM.Telas.Emprestimo
{
    public partial class DevoluEmp : Form
    {
        // Propriedade que armazena o empréstimo selecionado para devolução
        public TestePIM.Dados.Emprestimo EmprestimoParaDevolver { get; set; }

        public DevoluEmp()
        {
            InitializeComponent();
        }

        // Construtor que recebe um empréstimo e carrega seus dados na tela
        public DevoluEmp(TestePIM.Dados.Emprestimo emprestimo) : this()
        {
            EmprestimoParaDevolver = emprestimo;
            CarregarDadosDoEmprestimo();
        }

        // Evento do botão Buscar: busca cliente pelo nome ou RA e carrega empréstimos ativos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busca = txbNome.Text.Trim();

            var cliente = Listas.Clientes.FirstOrDefault(c =>
                c.Nome.Equals(busca, StringComparison.OrdinalIgnoreCase) ||
                c.RA.Equals(busca, StringComparison.OrdinalIgnoreCase));

            if (cliente != null)
            {
                txbNome.Text = cliente.Nome;
                txbEmail.Text = cliente.Email;
                txbRA.Text = cliente.RA;

                // Filtra empréstimos ativos do cliente
                var emprestimos = Listas.Emprestimos
                    .Where(emp => emp.Cliente == cliente && emp.Status) // Somente ativos
                    .ToList();

                cbxBuscaLivro.DataSource = emprestimos;
                cbxBuscaLivro.DisplayMember = "TituloLivro";

                if (emprestimos.Count == 0)
                {
                    MessageBox.Show("Este cliente não possui empréstimos ativos.");
                }
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.");
            }
        }

        // Evento disparado ao selecionar um empréstimo na ComboBox de livros
        private void cbxBuscaLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuscaLivro.SelectedItem is TestePIM.Dados.Emprestimo emprestimo)
            {
                EmprestimoParaDevolver = emprestimo;
                CarregarDadosDoEmprestimo();
            }
        }

        // Carrega os dados do empréstimo selecionado nos campos da tela
        private void CarregarDadosDoEmprestimo()
        {
            if (EmprestimoParaDevolver != null)
            {
                txbNome.Text = EmprestimoParaDevolver.Cliente?.Nome ?? "";
                txbEmail.Text = EmprestimoParaDevolver.Cliente?.Email ?? "";
                txbRA.Text = EmprestimoParaDevolver.Cliente?.RA ?? "";

                dtpEmp.Value = EmprestimoParaDevolver.DataEmprestimo;

                // Data prevista para devolução (7 dias após o empréstimo)
                DateTime dataPrevista = EmprestimoParaDevolver.DataEmprestimo.AddDays(7);
                dtpDevolu.Value = DateTime.Today;

                string status;
                if (!EmprestimoParaDevolver.Status)
                {
                    // Empréstimo já devolvido
                    if (EmprestimoParaDevolver.DataDevolucao > dataPrevista)
                        status = "Devolvido com atraso";
                    else
                        status = "Devolvido";
                }
                else
                {
                    // Empréstimo ainda ativo
                    status = dataPrevista < DateTime.Today ? "Atrasado" : "Ativo";
                }

                txbStatus.Text = status;
                // Define a cor do status conforme a situação
                txbStatus.ForeColor = status == "Atrasado" ? Color.Red :
                                      status == "Devolvido" ? Color.Gray :
                                      status == "Devolvido com atraso" ? Color.Orange :
                                      Color.Green;

                // Exibe o card do livro emprestado
                panelLivro.Controls.Clear();
                if (EmprestimoParaDevolver.Livro != null)
                {
                    var card = CardDevolucao.CriarCard(EmprestimoParaDevolver.Livro);
                    card.Left = (panelLivro.Width - card.Width) / 2;
                    panelLivro.Controls.Add(card);
                }
            }
        }

        // Evento do botão Confirmar: realiza a devolução do empréstimo
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (EmprestimoParaDevolver == null || !EmprestimoParaDevolver.Status)
            {
                MessageBox.Show("Selecione um empréstimo válido para devolver.");
                return;
            }

            DateTime dataDevolucaoReal = dtpDevolu.Value.Date;
            DateTime dataPrevista = EmprestimoParaDevolver.DataEmprestimo.AddDays(7);

            bool estaAtrasado = dataDevolucaoReal > dataPrevista;

            // Atualiza status do empréstimo e quantidade do livro
            EmprestimoParaDevolver.Status = false;
            EmprestimoParaDevolver.Livro.Quantidade++;
            EmprestimoParaDevolver.DataDevolucao = dataDevolucaoReal;

            if (estaAtrasado)
            {
                try
                {
                    // Aplica multa se devolução estiver atrasada
                    VerificarStatus.AplicarMulta(EmprestimoParaDevolver);
                    MessageBox.Show("Devolução com atraso! Multa aplicada.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao aplicar multa: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Devolução realizada com sucesso.");
            }

            this.Close();
        }

        // Evento do botão Cancelar: fecha a tela sem realizar alterações
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento do botão Voltar: fecha a tela
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
