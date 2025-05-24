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
        public VerDadosCliente()
        {
            InitializeComponent();
        }
        public Cliente ClienteParaVisualizar { get; set; }
        private void FormVerDadosCliente_Load(object sender, EventArgs e)
        {
            

            if (ClienteParaVisualizar != null)
            {


                txbNome.Text = ClienteParaVisualizar.Nome;
                txbEmail.Text = ClienteParaVisualizar.Email;
                txbCPF.Text = ClienteParaVisualizar.CPF;
                dtpDataNasc.Value = ClienteParaVisualizar.DataNasc;
                txbEndereco.Text = ClienteParaVisualizar.Endereco;
                txbRA.Text = ClienteParaVisualizar.RA;

                txbNome.ReadOnly = true;
                txbEmail.ReadOnly = true;
                txbCPF.ReadOnly = true;
                dtpDataNasc.Enabled = false;
                txbEndereco.ReadOnly = true;
                txbRA.ReadOnly = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {           
            this.Close();
        }       

        
    }
}
