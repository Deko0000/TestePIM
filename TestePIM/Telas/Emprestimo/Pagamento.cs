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
using TestePIM.Controle.Emprestimo;
using TestePIM.Dados;

namespace TestePIM.Telas.Emprestimo
{
    public partial class Pagamento : Form
    {
        public Cliente clienteSelecionado;

        public Pagamento()
        {
            InitializeComponent();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            string busca = txbNome.Text.Trim();

            clienteSelecionado = Listas.Clientes.FirstOrDefault(c =>
                c.Nome.Equals(busca, StringComparison.OrdinalIgnoreCase) ||
                c.CPF.Equals(busca, StringComparison.OrdinalIgnoreCase));

            if (clienteSelecionado != null)
            {
                txbNome.Text = clienteSelecionado.Nome;
                txbCPF.Text = clienteSelecionado.CPF;
                AtualizarServicos();
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.");
            }
        }

        private void chxEmp_CheckedChanged(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
                AtualizarServicos();
        }

        private void chxLeituraLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
                AtualizarServicos();
        }

        private void chxComputador_CheckedChanged(object sender, EventArgs e)
        {
            if (clienteSelecionado != null)
                AtualizarServicos();
        }

        private void AtualizarServicos()
        {
            cbxBuscaPedidos.Items.Clear();
            panelLivro.Controls.Clear();

            List<object> servicosPendentes = new List<object>();

            if (chxEmp.Checked)
            {
                servicosPendentes.AddRange(Listas.Emprestimos
                    .Where(e => e.Cliente == clienteSelecionado && e.Status));
            }

            if (chxLeituraLocal.Checked)
            {
                servicosPendentes.AddRange(Listas.LeiturasLocais
                    .Where(l => l.Cliente == clienteSelecionado && l.Status));
            }

            if (chxComputador.Checked)
            {
                servicosPendentes.AddRange(Listas.UsosComputador
                    .Where(u => u.Cliente == clienteSelecionado && u.Status));
            }

            if (servicosPendentes.Count == 0)
            {
                MessageBox.Show("Nenhum serviço pendente encontrado.");
                return;
            }

            cbxBuscaPedidos.DataSource = null;
            cbxBuscaPedidos.DataSource = servicosPendentes;
            cbxBuscaPedidos.DisplayMember = "Descricao"; // Crie uma propriedade Descricao em cada classe
        }

        private void cbxBuscaPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selecionado = cbxBuscaPedidos.SelectedItem;
            panelLivro.Controls.Clear();

            Livro livro = null;

            if (selecionado is TestePIM.Dados.Emprestimo emp)
                livro = emp.Livro;
            else if (selecionado is LeituraLocal leitura)
                livro = leitura.Livro;
            // UsoComputador pode não ter livro

            if (livro != null)
            {
                var card = CardLivros.CriarCard(livro);
                card.Left = (panelLivro.Width - card.Width) / 2;
                panelLivro.Controls.Add(card);
            }

            AtualizarValorServico();
        }

        private void AtualizarValorServico()
        {
            decimal valor = 0;

            object selecionado = cbxBuscaPedidos.SelectedItem;

            if (selecionado is TestePIM.Dados.Emprestimo)
                valor = 10.00m;
            else if (selecionado is LeituraLocal)
                valor = 5.00m;
            else if (selecionado is UsoComputador)
                valor = 50.00m;

            lblValorServico.Text = $"R$ {valor:F2}";
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (cbxBuscaPedidos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um serviço para confirmar pagamento.");
                return;
            }

            object selecionado = cbxBuscaPedidos.SelectedItem;

            if (selecionado is TestePIM.Dados.Emprestimo emp)
                emp.Status = false;
            else if (selecionado is LeituraLocal leitura)
                leitura.Status = false;
            else if (selecionado is UsoComputador uso)
                uso.Status = false;

            MessageBox.Show("Pagamento confirmado com sucesso.");
            AtualizarServicos();
            lblValorServico.Text = "R$ 0,00";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbxBuscaPedidos.DataSource = null;
            panelLivro.Controls.Clear();
            lblValorServico.Text = "R$ 0,00";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
