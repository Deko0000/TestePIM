using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePIM.Controle.Emprestimo;

namespace TestePIM.Telas.Emprestimo
{
    public partial class RealizaEmp : Form
    {      
            public Livro LivroRecebido { get; set; } // Livro passado por outra tela

            Livro livroSelecionado = null;
            Cliente clienteSelecionado = null;

            public RealizaEmp()
            {
                InitializeComponent();
                txbAutor.ReadOnly = true;
                txbRA.ReadOnly = true;

                // Conectar evento Load do formulário para preencher dados iniciais
                
            }

            private void RealizaEmp_Load(object sender, EventArgs e)
            {
                if (LivroRecebido != null)
                {
                    livroSelecionado = LivroRecebido;
                    txbLivro.Text = livroSelecionado.Titulo;
                    txbAutor.Text = livroSelecionado.Autor;
                    CarregarCapaLivro(livroSelecionado.CaminhoCapa);
                }
            }

            private void CarregarCapaLivro(string caminho)
            {
                if (string.IsNullOrEmpty(caminho))
                {
                    pbxCapa.Image = null;
                    return;
                }

                try
                {
                    if (caminho.StartsWith("http"))
                    {
                        using (HttpClient client = new HttpClient())
                        using (var response = client.GetAsync(caminho).Result)
                        using (var stream = response.Content.ReadAsStreamAsync().Result)
                        {
                            pbxCapa.Image = Image.FromStream(stream);
                        }
                    }
                    else if (File.Exists(caminho))
                    {
                        pbxCapa.Image = Image.FromFile(caminho);
                    }
                    else
                    {
                        pbxCapa.Image = null;
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao carregar a capa.");
                    pbxCapa.Image = null;
                }
            }

            private void btnBuscaLivro_Click(object sender, EventArgs e)
            {
                string termo = txbLivro.Text.Trim().ToLower();

                livroSelecionado = Listas.Livros
                    .FirstOrDefault(l => l.Titulo.ToLower().Contains(termo) || l.Id.ToString() == termo);

                if (livroSelecionado != null)
                {
                    txbLivro.Text = livroSelecionado.Titulo;
                    txbAutor.Text = livroSelecionado.Autor;
                    CarregarCapaLivro(livroSelecionado.CaminhoCapa);
                }
                else
                {
                    MessageBox.Show("Livro não encontrado.");
                }
            }

            private void btnBuscaCliente_Click(object sender, EventArgs e)
            {
                string termo = txbCliente.Text.Trim().ToLower();

                clienteSelecionado = Listas.Clientes
                    .FirstOrDefault(c => c.Nome.ToLower().Contains(termo) || c.RA.ToLower() == termo);

                if (clienteSelecionado != null)
                {
                    txbCliente.Text = clienteSelecionado.Nome;
                    txbRA.Text = clienteSelecionado.RA;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.");
                }
            }

            private void btnConfirmar_Click(object sender, EventArgs e)
            {
                string erro = VerificaRealizacaoEmp.VerificarCampos(
                    livroSelecionado,
                    clienteSelecionado,
                    dtpEmprestimo.Value,
                    dtpDevolucao.Value
                );

                if (erro != null)
                {
                    MessageBox.Show(erro);
                    return;
                }

                if (livroSelecionado.Quantidade <= 0)
                {
                    MessageBox.Show("Livro indisponível para empréstimo.");
                    return;
                }

                var novoEmprestimo = new TestePIM.Dados.Emprestimo
                {
                    Livro = livroSelecionado,
                    Cliente = clienteSelecionado,
                    DataEmprestimo = dtpEmprestimo.Value,
                    DataDevolucao = dtpDevolucao.Value,
                    Status = true
                };

                livroSelecionado.Quantidade--;
                Listas.Emprestimos.Add(novoEmprestimo);

                MessageBox.Show("Empréstimo registrado com sucesso!");
                this.Close();
            }

        private void btnCancelar_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void btnVoltar_Click(object sender, EventArgs e)
            {
                this.Close();
            }
    }
}
