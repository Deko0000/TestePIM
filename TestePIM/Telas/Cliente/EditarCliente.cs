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
            InitializeComponent(); // Inicializa os componentes do formulário
        }

        // Propriedade para receber o cliente que será editado
        public Cliente ClienteParaEditar { get; set; }

        // Evento disparado ao carregar o formulário
        private void FormEditarCliente_Load(object sender, EventArgs e)
        {
            if (ClienteParaEditar != null)
            {
                // Preenche os campos do formulário com os dados do cliente selecionado
                txbNome.Text = ClienteParaEditar.Nome;
                txbEmail.Text = ClienteParaEditar.Email;
                txbCPF.Text = ClienteParaEditar.CPF;
                dtpDataNasc.Value = ClienteParaEditar.DataNasc;
                txbEndereco.Text = ClienteParaEditar.Endereco;
                txbRA.Text = ClienteParaEditar.RA;
            }
        }

        // Evento disparado ao clicar no botão Confirmar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ClienteParaEditar != null)
            {
                // Exibe uma caixa de diálogo para confirmação da edição
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

                // Instancia a verificação de dados do cliente editado
                var verificador = new TestePIM.Controle.VerificaClienteEditado();

                // Valida o cliente editado
                if (!verificador.Validar(ClienteParaEditar))
                {
                    // Se não for válido, interrompe o método
                    return;
                }
            }

            MessageBox.Show("Cliente atualizado com sucesso!"); // Exibe mensagem de sucesso
            this.DialogResult = DialogResult.OK; // Define o resultado do diálogo como OK
            this.Close(); // Fecha o formulário
        }

        // Evento disparado ao clicar no botão Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa todos os campos do formulário
            txbNome.Clear();
            txbEmail.Clear();
            txbCPF.Clear();
            dtpDataNasc.Value = DateTime.Now;
            txbEmail.Clear();
            txbEndereco.Clear();
            txbRA.Clear();
        }

        // Evento disparado ao clicar no botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Define o resultado do diálogo como Cancel
            this.Close(); // Fecha o formulário
        }

        // Evento disparado ao clicar no botão Voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Define o resultado do diálogo como Cancel
            this.Close(); // Fecha o formulário
        }
    }
}
