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
    public partial class VerDadosFuncionario : Form
    {
        // Construtor do formulário
        public VerDadosFuncionario()
        {
            InitializeComponent();
        }

        // Propriedade para receber o funcionário a ser visualizado
        public Funcionario FuncionarioParaVisualizar { get; set; }

        // Evento disparado ao alterar o estado do checkbox de mostrar senha
        private void cbxMostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            // Alterna entre mostrar e ocultar a senha
            if (txbSenha.PasswordChar == '\0')
            {
                txbSenha.PasswordChar = '*'; // Mostra a senha
            }
            else
            {
                txbSenha.PasswordChar = '\0'; // Oculta a senha
            }
        }

        // Evento disparado ao carregar o formulário
        private void FormVerDadosFuncionario_Load(object sender, EventArgs e)
        {
            // Verifica se há um funcionário para visualizar
            if (FuncionarioParaVisualizar != null)
            {
                // Preenche os campos com os dados do funcionário
                txbNome.Text = FuncionarioParaVisualizar.Nome;
                txbEmail.Text = FuncionarioParaVisualizar.Email;
                txbCPF.Text = FuncionarioParaVisualizar.CPF;
                dtpDataNasc.Value = FuncionarioParaVisualizar.DataNasc;
                txbEndereco.Text = FuncionarioParaVisualizar.Endereco;
                txbSenha.Text = FuncionarioParaVisualizar.Senha;
                lblIdentificaFuncionario.Text = FuncionarioParaVisualizar.NumIdentifica;

                // Torna os campos somente leitura para evitar edição
                txbNome.ReadOnly = true;
                txbEmail.ReadOnly = true;
                txbCPF.ReadOnly = true;
                dtpDataNasc.Enabled = false;
                txbEndereco.ReadOnly = true;
            }
        }

        // Evento disparado ao clicar no botão Voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário
        }
    }
}
