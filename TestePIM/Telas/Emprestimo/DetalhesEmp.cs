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
    public partial class DetalhesEmp : Form
    {
        // Propriedade pública para receber o empréstimo a ser visualizado
        public TestePIM.Dados.Emprestimo EmprestimoParaVisualizar { get; set; }

        public DetalhesEmp()
        {
            InitializeComponent(); // Inicializa os componentes do formulário
        }

        // Evento disparado ao carregar o formulário
        private void DetalhesEmp_Load(object sender, EventArgs e)
        {
            if (EmprestimoParaVisualizar != null)
            {
                // Preenche os campos com os dados do livro emprestado
                txbTitulo.Text = EmprestimoParaVisualizar.Livro.Titulo;
                txbAutor.Text = EmprestimoParaVisualizar.Livro.Autor;
                txbISBN.Text = EmprestimoParaVisualizar.Livro.ISBN;

                // Preenche os campos com os dados do cliente
                txbNome.Text = EmprestimoParaVisualizar.Cliente.Nome;
                txbEmail.Text = EmprestimoParaVisualizar.Cliente.Email;
                txbRA.Text = EmprestimoParaVisualizar.Cliente.RA;

                // Preenche as datas de empréstimo e devolução
                dtpEmp.Value = EmprestimoParaVisualizar.DataEmprestimo;
                dtpDevolu.Value = EmprestimoParaVisualizar.DataDevolucao;

                // Determina o status do empréstimo
                string status;
                if (!EmprestimoParaVisualizar.Status)
                {
                    // Já devolvido
                    if (EmprestimoParaVisualizar.DataDevolucao > EmprestimoParaVisualizar.DataEmprestimo.AddDays(7))
                        status = "Devolvido com atraso";
                    else
                        status = "Devolvido";
                }
                else
                {
                    // Ainda não devolvido
                    if (EmprestimoParaVisualizar.DataDevolucao < DateTime.Today)
                        status = "Atrasado";
                    else
                        status = "Ativo";
                }

                txbStatus.Text = status;

                // Define a cor do texto do status conforme o valor
                txbStatus.ForeColor = status == "Atrasado" ? Color.Red :
                                      status == "Devolvido" ? Color.Gray :
                                      status == "Devolvido com atraso" ? Color.Orange :
                                      Color.Green;

                // Torna todos os campos somente leitura para evitar edição
                txbTitulo.ReadOnly = true;
                txbAutor.ReadOnly = true;
                txbISBN.ReadOnly = true;

                txbNome.ReadOnly = true;
                txbEmail.ReadOnly = true;
                txbRA.ReadOnly = true;
                txbStatus.ReadOnly = true;

                dtpEmp.Enabled = false;
                dtpDevolu.Enabled = false;
            }
            else
            {
                // Exibe mensagem de erro caso não haja empréstimo carregado
                MessageBox.Show("Nenhum empréstimo foi carregado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Evento do botão Voltar, fecha o formulário
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
