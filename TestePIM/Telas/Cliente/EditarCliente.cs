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
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }
        public Cliente ClienteParaEditar { get; set; }

        private void FormEditarCliente_Load(object sender, EventArgs e)
        {
            if (ClienteParaEditar != null)
            {
                

                txbNome.Text = ClienteParaEditar.Nome;
                txbEmail.Text = ClienteParaEditar.Email;
                txbCPF.Text = ClienteParaEditar.CPF;
                dtpDataNasc.Value = ClienteParaEditar.DataNasc;
                txbEndereco.Text = ClienteParaEditar.Endereco;
                txbRA.Text = ClienteParaEditar.RA;
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ClienteParaEditar != null)
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja editar este cliente?",
                                          "Confirmar Edição",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    return;  // Usuário desistiu da edição
                }

                // Atualiza os dados do cliente com o que está nas caixas de texto
                ClienteParaEditar.Nome = txbNome.Text;
                ClienteParaEditar.Email = txbEmail.Text;
                ClienteParaEditar.CPF = txbCPF.Text;
                ClienteParaEditar.DataNasc = dtpDataNasc.Value;
                ClienteParaEditar.RA = txbRA.Text;
                ClienteParaEditar.Endereco = txbEndereco.Text;

                // Instancia a verificação
                var verificador = new TestePIM.Controle.VerificaClienteEditado();

                // Valida o cliente
                if (!verificador.Validar(ClienteParaEditar))
                {
                    // Se não for válido, interrompe o método
                    return;
                }
            }

            MessageBox.Show("Cliente atualizado com sucesso!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }




        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbEmail.Clear();
            txbCPF.Clear();
            dtpDataNasc.Value = DateTime.Now;
            txbEmail.Clear();
            txbEndereco.Clear();
            txbRA.Clear();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
