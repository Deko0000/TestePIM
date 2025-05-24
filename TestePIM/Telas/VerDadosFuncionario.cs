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
        public VerDadosFuncionario()
        {
            InitializeComponent();
        }
        public Funcionario FuncionarioParaVisualizar { get; set; }
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
        }

        private void FormVerDadosFuncionario_Load(object sender, EventArgs e)
        {


            if (FuncionarioParaVisualizar != null)
            {


                txbNome.Text = FuncionarioParaVisualizar.Nome;
                txbEmail.Text = FuncionarioParaVisualizar.Email;
                txbCPF.Text = FuncionarioParaVisualizar.CPF;
                dtpDataNasc.Value = FuncionarioParaVisualizar.DataNasc;
                txbEndereco.Text = FuncionarioParaVisualizar.Endereco;
                txbSenha.Text = FuncionarioParaVisualizar.Senha;               
                lblIdentificaFuncionario.Text = FuncionarioParaVisualizar.NumIdentifica;

                txbNome.ReadOnly = true;
                txbEmail.ReadOnly = true;
                txbCPF.ReadOnly = true;
                dtpDataNasc.Enabled = false;
                txbEndereco.ReadOnly = true;                
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
