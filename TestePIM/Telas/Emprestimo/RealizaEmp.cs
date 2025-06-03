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
        // Propriedade para receber o livro selecionado de outra tela
        public Livro LivroRecebido { get; set; }
        public TestePIM.Dados.Emprestimo EmprestimoRecebido { get; set; }

        // Variável para armazenar o livro selecionado na tela
        Livro livroSelecionado = null;
        // Variável para armazenar o cliente selecionado na tela
        Cliente clienteSelecionado = null;

        public RealizaEmp()
        {
            InitializeComponent();
            txbAutor.ReadOnly = true; // Campo autor não editável
            txbRA.ReadOnly = true;    // Campo RA não editável
            txbValorEmp.ReadOnly = true;
        }

        // Evento disparado ao carregar a tela
        private void RealizaEmp_Load(object sender, EventArgs e)
        {
            // Inicializa as datas com valores padrão
            dtpEmprestimo.Value = DateTime.Now.Date;
            dtpDevolucao.Value = DateTime.Now.Date.AddDays(30);
            // prazo padrão de 30 dias para devolução

            // Se um livro foi recebido de outra tela, preenche os campos
            if (LivroRecebido != null)
            {
                livroSelecionado = LivroRecebido;
                txbLivro.Text = livroSelecionado.Titulo;
                txbAutor.Text = livroSelecionado.Autor;
                CarregarCapaLivro(livroSelecionado.CaminhoCapa);
            }

            if (EmprestimoRecebido != null)
            {
                txbValorEmp.Text = EmprestimoRecebido.ValorEmprestimo.ToString("C"); // formato de moeda
            }
            else
            {
                txbValorEmp.Text = "R$ 0,00"; // ou algum valor padrão
            }
        }

        // Carrega a imagem da capa do livro, se houver
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
                    // Carrega imagem de uma URL
                    using (HttpClient client = new HttpClient())
                    using (var response = client.GetAsync(caminho).Result)
                    using (var stream = response.Content.ReadAsStreamAsync().Result)
                    {
                        pbxCapa.Image = Image.FromStream(stream);
                    }
                }
                else if (File.Exists(caminho))
                {
                    // Carrega imagem de um arquivo local
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

        // Busca um livro pelo título ou ID digitado
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

        // Busca um cliente pelo nome ou RA digitado
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

        // Confirma e registra o empréstimo
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime dataEmprestimo = dtpEmprestimo.Value.Date;
            dtpDevolucao.MaxDate = dataEmprestimo.AddDays(30);
            DateTime dataParaDevolucao = dtpDevolucao.Value.Date;
<<<<<<< HEAD
=======

            
            
>>>>>>> 50ed36aa700d281488a6c6ac12cc82b0af56bda1

            string erro = VerificaRealizacaoEmp.VerificarCampos(
                livroSelecionado,
                clienteSelecionado,
                dataEmprestimo,
                dataParaDevolucao
            );

            if (erro != null)
            {
                MessageBox.Show(erro);
                return;
            }

            if (livroSelecionado == null || clienteSelecionado == null)
            {
                MessageBox.Show("Selecione o cliente e o livro antes de confirmar.");
                return;
            }

            // 🔒 Verifica se o empréstimo foi pago
            if (EmprestimoRecebido == null || !EmprestimoRecebido.Pago)
            {
                MessageBox.Show("O pagamento do empréstimo ainda não foi realizado.");
                return;
            }

            if (livroSelecionado.Quantidade <= 0)
            {
                MessageBox.Show("Livro indisponível para empréstimo.");
                return;
            }

<<<<<<< HEAD
            // Cria e adiciona o empréstimo
            var novoEmprestimo = new TestePIM.Dados.Emprestimo
            {
                Cliente = clienteSelecionado,
                Livro = livroSelecionado,
                DataEmprestimo = dataEmprestimo,
                DataParaDevolucao = dataParaDevolucao,
                Pago = true, // já foi pago
                Status = true
            };
=======
            
            
                // Cria um novo empréstimo e adiciona à lista
                var novoEmprestimo = new TestePIM.Dados.Emprestimo
                {
                    Cliente = clienteSelecionado,
                    Livro = livroSelecionado,
                    DataEmprestimo = dataEmprestimo,
                    DataParaDevolucao = dataParaDevolucao,
                    Status = true // ativo
                };
>>>>>>> 50ed36aa700d281488a6c6ac12cc82b0af56bda1

                livroSelecionado.Quantidade--;
                Listas.Emprestimos.Add(novoEmprestimo);

                MessageBox.Show("Empréstimo registrado com sucesso!");
                this.Close();
            
        }

        // Cancela a operação e fecha a tela
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Volta para a tela anterior
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // (aqui você pode abrir a tela de pagamento)

            // Simulando o pagamento para teste (substitua isso depois pela lógica real)
            EmprestimoRecebido.Pago = true;

            MessageBox.Show("Multa paga com sucesso.");

            btnPagar.Enabled = false;
            btnPagar.Text = "Pago";
        }
    }
}
