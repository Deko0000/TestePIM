using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Captura os dados dos campos
            string nome = txbNome.Text.Trim();
            string email = txbEmail.Text.Trim();
            string cpf = txbCPF.Text.Trim();
            DateTime dataNasc = dtpDataNasc.Value;
            string ra = txbRA.Text.Trim().ToUpper();
            string endereco = txbEndereco.Text.Trim();

            // Cria o objeto Cliente
            Cliente cliente = new Cliente(
                nome, email, cpf, dataNasc, ra, endereco);

            // Cria o validador e verifica os dados
            VerificaCliente verificador = new VerificaCliente();
            if (verificador.Validar(cliente))
            {
                // Adiciona na lista                
                Listas.Clientes.Add(cliente);

                MessageBox.Show(cliente.Nome + " cadastrado com sucesso!");

                // Limpa os campos
                txbNome.Clear();
                txbEmail.Clear();
                txbCPF.Clear();                
                txbRA.Clear();
                txbEndereco.Clear();
            }
            // Caso contrário, os erros já foram mostrados pela classe VerificaCliente
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbEmail.Clear();
            txbCPF.Clear();
            dtpDataNasc.Value = DateTime.Now;
            txbRA.Clear();
            txbEndereco.Clear();
        }        
    }
}
