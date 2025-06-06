using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePIM.Controle.Emprestimo;
using TestePIM.Dados;

namespace TestePIM.Telas.Emprestimo
{
    public partial class PagamentoMulta : Form
    {
        public Cliente clienteSelecionado;
        public Multa MultaParaPagar { get; set; }

        public PagamentoMulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busca = txbNome.Text.Trim();

            clienteSelecionado = Listas.Clientes.FirstOrDefault(c =>
                c.Nome.Equals(busca, StringComparison.OrdinalIgnoreCase) ||
                c.CPF.Equals(busca, StringComparison.OrdinalIgnoreCase));

            if (clienteSelecionado != null)
            {
                txbNome.Text = clienteSelecionado.Nome;
                txbCPF.Text = clienteSelecionado.CPF;

                var multasCliente = Listas.Multas
                    .Where(m => m.Emprestimo.Cliente == clienteSelecionado && !m.Pago && m.Status)
                    .ToList();

                cbxBuscaMulta.DataSource = multasCliente;
                cbxBuscaMulta.DisplayMember = "Emprestimo.Livro.Titulo";

                if (multasCliente.Count == 0)
                {
                    MessageBox.Show("Este cliente não possui multas pendentes.");
                    panelLivro.Controls.Clear();
                }
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.");
                cbxBuscaMulta.DataSource = null;
                panelLivro.Controls.Clear();
            }
        }

        private void cbxBuscaMulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuscaMulta.SelectedItem is Multa multa)
            {
                MultaParaPagar = multa;
                CarregarPainelMultaSelecionada();
            }
        }

        private void CarregarPainelMultaSelecionada()
        {
            if (MultaParaPagar == null) return;

            var emp = MultaParaPagar.Emprestimo;

            dtpEmp.Value = emp.DataEmprestimo;
            dtpDevoluPrevista.Value = emp.DataParaDevolucao;
            dtpDaDevolu.Value = emp.DataDevolvida ?? DateTime.Today;

            int diasAtraso = (emp.DataDevolvida.Value - emp.DataParaDevolucao).Days;

            txbStatus.Text = diasAtraso > 0 ? "Atrasado" : "No prazo";
            txbStatus.ForeColor = diasAtraso > 0 ? Color.Red : Color.Green;

            txbDiasAtraso.Text = diasAtraso.ToString();
            txbValorMulta.Text = MultaParaPagar.ValorMulta.ToString("C");

            // Montar card do livro
            panelLivro.Controls.Clear();
            if (emp.Livro != null)
            {
                var card = CardMulta.CriarCard(emp.Livro);
                card.Left = (panelLivro.Width - card.Width) / 2;
                panelLivro.Controls.Add(card);
            }
        }
        private void rbtnDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDinheiro.Checked)
            {
                rbtnPix.Checked = false;
                rbtnCartao.Checked = false;
            }
        }

        private void rbtnPix_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPix.Checked)
            {
                rbtnDinheiro.Checked = false;
                rbtnCartao.Checked = false;
            }
        }

        private void rbtnCartao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCartao.Checked)
            {
                rbtnDinheiro.Checked = false;
                rbtnPix.Checked = false;
            }
        }

        private string ObterFormaPagamento()
        {
            if (rbtnDinheiro.Checked) return "Dinheiro";
            if (rbtnPix.Checked) return "Pix";
            if (rbtnCartao.Checked) return "Cartão";
            return string.Empty;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (MultaParaPagar == null)
            {
                MessageBox.Show("Selecione uma multa.");
                return;
            }

            if (!rbtnDinheiro.Checked || !rbtnPix.Checked || !rbtnCartao.Checked)
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                return;
            }

            string forma = ObterFormaPagamento();
            if (string.IsNullOrEmpty(forma))
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                return;
            }

            MultaParaPagar.FormaPagamento = forma;


            MultaParaPagar.Pago = true;
            MultaParaPagar.Status = false;

            MessageBox.Show("Multa paga com sucesso!");

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
