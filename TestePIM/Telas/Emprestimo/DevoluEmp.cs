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
        public TestePIM.Dados.Emprestimo EmprestimoParaDevolver { get; set; }
        public TestePIM.Dados.Multa MultaParaDevolver { get; set; }

       
        public DevoluEmp()
        {
            InitializeComponent();
        }

        public DevoluEmp(TestePIM.Dados.Emprestimo emprestimo) : this()
        {
            EmprestimoParaDevolver = emprestimo;
            CarregarDadosDoEmprestimo();
        }

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

                var emprestimos = Listas.Emprestimos
                    .Where(emp => emp.Cliente == cliente && emp.Status) // apenas ativos
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

        private void cbxBuscaLivro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuscaLivro.SelectedItem is TestePIM.Dados.Emprestimo emprestimo)
            {
                EmprestimoParaDevolver = emprestimo;
                CarregarDadosDoEmprestimo();
            }
        }

        private void CarregarDadosDoEmprestimo()
        {
            if (EmprestimoParaDevolver != null)
            {
                txbNome.Text = EmprestimoParaDevolver.Cliente?.Nome ?? "";
                txbEmail.Text = EmprestimoParaDevolver.Cliente?.Email ?? "";
                txbRA.Text = EmprestimoParaDevolver.Cliente?.RA ?? "";

                dtpEmp.Value = EmprestimoParaDevolver.DataEmprestimo;
                dtpDevoluPrevista.Value = EmprestimoParaDevolver.DataParaDevolucao;


                txbValorMulta.Text = MultaParaDevolver.ValorMulta.ToString("C2"); // formato de moeda
            }
            else
            {
                txbValorMulta.Text = "R$ 0,00"; // ou algum valor padrão

            }


                DateTime hoje = DateTime.Today;
                string status;

                if (!EmprestimoParaDevolver.Status && EmprestimoParaDevolver.DataDevolvida.HasValue)
                {
                    if (EmprestimoParaDevolver.DataDevolvida.Value > EmprestimoParaDevolver.DataParaDevolucao)
                        status = "Devolvido com atraso";
                    else
                        status = "Devolvido";

                    dtpDaDevolu.Value = EmprestimoParaDevolver.DataDevolvida.Value;
                }
                else
                {
                    dtpDaDevolu.Value = hoje;
                    status = EmprestimoParaDevolver.DataParaDevolucao < hoje ? "Atrasado" : "Ativo";
                }

                txbStatus.Text = status;
                txbStatus.ForeColor = status == "Atrasado" ? Color.Red :
                                      status == "Devolvido" ? Color.Gray :
                                      status == "Devolvido com atraso" ? Color.Orange :
                                      Color.Green;

                panelLivro.Controls.Clear();
                if (EmprestimoParaDevolver.Livro != null)
                {
                    var card = CardDevolucao.CriarCard(EmprestimoParaDevolver.Livro);
                    card.Left = (panelLivro.Width - card.Width) / 2;
                    panelLivro.Controls.Add(card);
                }
                if (MultaParaDevolver != null && MultaParaDevolver.ValorMulta > 0)
                {
                   

                    bool paga = MultaParaDevolver.Pago;

                    txbValorMulta.Visible = true;
                    lblValorMulta.Visible = true;
                    btnPagarMulta.Visible = !paga;
                    btnPagarMulta.Enabled = !paga;
                    btnPagarMulta.Text = paga ? "Pago" : "Pagar Multa";

                }
                else
                {
                    txbValorMulta.Visible = false;
                    lblValorMulta.Visible = false;
                    btnPagarMulta.Visible = false;
                }

        }            
            
        

        private void btnPagarMulta_Click(object sender, EventArgs e)
        {
            // (aqui você pode abrir a tela de pagamento)

            // Simulando o pagamento para teste (substitua isso depois pela lógica real)
            MultaParaDevolver.Pago = true;

            MessageBox.Show("Multa paga com sucesso.");

            btnPagarMulta.Enabled = false;
            btnPagarMulta.Text = "Pago";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (EmprestimoParaDevolver == null || !EmprestimoParaDevolver.Status)
            {
                MessageBox.Show("Selecione um empréstimo válido para devolver.");
                return;
            }

            DateTime dataDevolucaoReal = dtpDaDevolu.Value.Date;
            DateTime dataPrevista = EmprestimoParaDevolver.DataParaDevolucao;

            bool estaAtrasado = dataDevolucaoReal > dataPrevista;

            // Se estiver atrasado e houver multa, mas não foi paga
            if (estaAtrasado && MultaParaDevolver != null && !MultaParaDevolver.Pago)
            {
                MessageBox.Show("Este empréstimo possui multa não paga. Realize o pagamento antes de concluir a devolução.");
                return;
            }

            // Prossegue com a devolução
            EmprestimoParaDevolver.Status = false;
            EmprestimoParaDevolver.DataDevolvida = dataDevolucaoReal;
            EmprestimoParaDevolver.Livro.Quantidade++;

            if (estaAtrasado)
            {
                try
                {
                    VerificarStatus.AplicarMulta(EmprestimoParaDevolver);
                    MessageBox.Show("Devolução com atraso! Multa registrada.");
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