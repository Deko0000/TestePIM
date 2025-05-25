using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Telas
{
    public partial class VerDadosCliente : Form
    {
        // Construtor do formulário
        public VerDadosCliente()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário
        }

        // Propriedade para receber o cliente a ser visualizado
        public Cliente ClienteParaVisualizar { get; set; }

        // Evento disparado ao carregar o formulário
        private void FormVerDadosCliente_Load(object sender, EventArgs e)
        {
            // Verifica se há um cliente para visualizar
            if (ClienteParaVisualizar != null)
            {
                // Preenche os campos do formulário com os dados do cliente
                txbNome.Text = ClienteParaVisualizar.Nome;
                txbEmail.Text = ClienteParaVisualizar.Email;
                txbCPF.Text = ClienteParaVisualizar.CPF;
                dtpDataNasc.Value = ClienteParaVisualizar.DataNasc;
                txbEndereco.Text = ClienteParaVisualizar.Endereco;
                txbRA.Text = ClienteParaVisualizar.RA;

                // Torna os campos somente leitura para impedir edição
                txbNome.ReadOnly = true;
                txbEmail.ReadOnly = true;
                txbCPF.ReadOnly = true;
                dtpDataNasc.Enabled = false;
                txbEndereco.ReadOnly = true;
                txbRA.ReadOnly = true;
            }
        }

        // Evento do botão Voltar, fecha o formulário
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }
    }
}
