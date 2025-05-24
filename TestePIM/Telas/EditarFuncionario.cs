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
            InitializeComponent();
        }
        public Funcionario FuncionarioParaEditar { get; set; }

        private void FormEditarFuncionario_Load(object sender, EventArgs e)
        {
            if (FuncionarioParaEditar != null)
            {

                txbNome.Text = FuncionarioParaEditar.Nome;
                txbEmail.Text = FuncionarioParaEditar.Email;
                txbCPF.Text = FuncionarioParaEditar.CPF;
                dtpDataNasc.Value = FuncionarioParaEditar.DataNasc;
                txbEndereco.Text = FuncionarioParaEditar.Endereco;
                txbSenha.Text = FuncionarioParaEditar.Senha;                
                lblIdentificaFuncionario.Text = FuncionarioParaEditar.NumIdentifica;
            }
        }
        private void cbxMostraSenha_CheckedChanged(object sender, EventArgs e)
        {

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
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (FuncionarioParaEditar != null)
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja editar este funcionário?",
                                          "Confirmar Edição",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
                if (confirmacao != DialogResult.Yes)
                {
                    return;  // Usuário desistiu da edição
                }

                // Atualiza os dados do cliente com o que está nas caixas de texto
                FuncionarioParaEditar.Nome = txbNome.Text;
                FuncionarioParaEditar.Email = txbEmail.Text;
                FuncionarioParaEditar.CPF = txbCPF.Text;
                FuncionarioParaEditar.DataNasc = dtpDataNasc.Value;               
                FuncionarioParaEditar.Endereco = txbEndereco.Text;
                FuncionarioParaEditar.Senha = txbSenha.Text;

                // Instancia a verificação
                var verificador = new TestePIM.Controle.VerificaFuncionarioEditado();

                // Valida o cliente
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




        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbEmail.Clear();
            txbCPF.Clear();
            dtpDataNasc.Value = DateTime.Now;
            txbEmail.Clear();
            txbEndereco.Clear();           

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
