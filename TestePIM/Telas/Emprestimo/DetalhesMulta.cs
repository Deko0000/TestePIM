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
    public partial class DetalhesMulta : Form
    {
        public Multa MultaParaVisualizar { get; set; }

        public DetalhesMulta()
        {
            InitializeComponent();
        }

        private void DetalhesMulta_Load(object sender, EventArgs e)
        {
            if (MultaParaVisualizar != null)
            {
                var emp = MultaParaVisualizar.Emprestimo;

                txbNomeCliente.Text = emp.Cliente.Nome;
                txbCPF.Text = emp.Cliente.CPF;
                if (emp.Funcionario != null)
                {
                    txbNomeFun.Text = emp.Funcionario.Nome;
                    txbMatricula.Text = emp.Funcionario.NumIdentifica;
                }
                else
                {
                    txbNomeFun.Text = "admin";
                    txbMatricula.Text = "admin";
                }

                txbStatus.Text = MultaParaVisualizar.Status ? "Ativa" : "Resolvida";
                txbDiasAtraso.Text = (emp.DataDevolvida.HasValue ?
                    (emp.DataDevolvida.Value - emp.DataParaDevolucao).Days : 0).ToString();
                txbValorMulta.Text = MultaParaVisualizar.ValorMulta.ToString("F2");

                dtpEmp.Value = emp.DataEmprestimo;
                dtpDevolu.Value = emp.DataParaDevolucao;
                dtpDataDevolvida.Value = emp.DataDevolvida ?? DateTime.Now;

                // Exibir o card do livro
                if (MultaParaVisualizar.Emprestimo.Livro != null)
                {
                    var card = CardMulta.CriarCard(MultaParaVisualizar.Emprestimo.Livro);
                    card.Left = (panelLivro.Width - card.Width) / 2;
                    panelLivro.Controls.Add(card);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
