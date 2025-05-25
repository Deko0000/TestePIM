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
    public partial class EditarFuncionario : Form
    {
        public EditarFuncionario()
        {
            InitializeComponent(); // Inicializa os componentes do formulário
        }

        // Propriedade para receber o funcionário que será editado
        public Funcionario FuncionarioParaEditar { get; set; }

        // Evento disparado ao carregar o formulário
        private void FormEditarFuncionario_Load(object sender, EventArgs e)
        {
            if (FuncionarioParaEditar != null)
            {
                // Preenche os campos do formulário com os dados do funcionário
                txbNome.Text = FuncionarioParaEditar.Nome;
                txbEmail.Text = FuncionarioParaEditar.Email;
                txbCPF.Text = FuncionarioParaEditar.CPF;
                dtpDataNasc.Value = FuncionarioParaEditar.DataNasc;
                txbEndereco.Text = FuncionarioParaEditar.Endereco;
                txbSenha.Text = FuncionarioParaEditar.Senha;
                lblIdentificaFuncionario.Text = FuncionarioParaEditar.NumIdentifica;
            }
        }

        // Evento para mostrar ou ocultar a senha ao marcar/desmarcar o checkbox
        private void cbxMostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            // Alterna a visibilidade do campo de senha
            if (txbSenha.PasswordChar == '\0')
            {
                txbSenha.PasswordChar = '*'; // Mostra a senha                
            }
            else
            {
                txbSenha.PasswordChar = '\0'; // Oculta a senha
            }
            if (txbConfirmaSenha.PasswordChar == '\0')
            {
                txbConfirmaSenha.PasswordChar = '*'; // Mostra a senha                
            }
            else
            {
                txbConfirmaSenha.PasswordChar = '\0'; // Oculta a senha
            }
        }

        // Evento disparado ao clicar no botão Confirmar
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (FuncionarioParaEditar != null)
            {
                // Solicita confirmação do usuário para editar o funcionário
                var confirmacao = MessageBox.Show("Tem certeza que deseja editar este funcionário?",
                                          "Confirmar Edição",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    return;  // Usuário desistiu da edição
                }

                // Atualiza os dados do funcionário com o que está nas caixas de texto
                FuncionarioParaEditar.Nome = txbNome.Text;
                FuncionarioParaEditar.Email = txbEmail.Text;
                FuncionarioParaEditar.CPF = txbCPF.Text;
                FuncionarioParaEditar.DataNasc = dtpDataNasc.Value;
                FuncionarioParaEditar.Endereco = txbEndereco.Text;
                FuncionarioParaEditar.Senha = txbSenha.Text;

                // Instancia a classe de verificação de edição
                var verificador = new TestePIM.Controle.VerificaFuncionarioEditado();

                // Valida o funcionário editado
                if (!verificador.Validar(FuncionarioParaEditar, txbConfirmaSenha.Text))
                {
                    // Se não for válido, interrompe o método
                    return;
                }
            }

            MessageBox.Show("Funcionário atualizado com sucesso!");
            this.DialogResult = DialogResult.OK;
            this.Close();
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
        }

        // Evento disparado ao clicar no botão Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Evento disparado ao clicar no botão Voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
