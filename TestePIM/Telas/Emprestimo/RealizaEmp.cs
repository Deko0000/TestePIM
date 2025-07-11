﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePIM.Controle.Emprestimo;

namespace TestePIM.Telas.Emprestimo
{
    public partial class RealizaEmp : Form
    {
        // Propriedade para receber o livro selecionado de outra tela
        public Livro LivroRecebido { get; set; }
       


        // Variável para armazenar o livro selecionado na tela
        Livro livroSelecionado = null;
        // Variável para armazenar o cliente selecionado na tela
        Cliente clienteSelecionado = null;

        public RealizaEmp()
        {
            InitializeComponent();
            txbAutor.ReadOnly = true; // Campo autor não editável
            txbRA.ReadOnly = true;    // Campo RA não editável
            
        }

        // Evento disparado ao carregar a tela
        private void RealizaEmp_Load(object sender, EventArgs e)
        {
            
            // Inicializa as datas com valores padrão
            dtpEmprestimo.Value = DateTime.Now.Date;
            dtpDevolucao.Value = DateTime.Now.Date.AddDays(30);
            // prazo padrão de 30 dias para devolução

            // Se um livro foi recebido de outra tela, preenche os campos
            if (LivroRecebido != null)
            {
                livroSelecionado = LivroRecebido;
                txbLivro.Text = livroSelecionado.Titulo;
                txbAutor.Text = livroSelecionado.Autor;
                
            }
            
        }

        // Carrega a imagem da capa do livro, se houver
        private void CarregarCardLivro(Livro livro)
        {
            panelLivro.Controls.Clear();
            var card = CardLivroEmp.CriarCard(livro);
            card.Left = (panelLivro.Width - card.Width) / 2;
            panelLivro.Controls.Add(card);
        }

        // Busca um livro pelo título ou ID digitado
        private void btnBuscaLivro_Click(object sender, EventArgs e)
        {
            string termo = txbLivro.Text.Trim().ToLower();

            livroSelecionado = Listas.Livros
                .FirstOrDefault(l => l.Titulo.ToLower().Contains(termo) || l.Id.ToString() == termo);

            if (livroSelecionado != null)
            {
                txbLivro.Text = livroSelecionado.Titulo;
                txbAutor.Text = livroSelecionado.Autor;
                CarregarCardLivro(livroSelecionado);
            }
            else
            {
                MessageBox.Show("Livro não encontrado.");
            }
        }

        // Busca um cliente pelo nome ou RA digitado
        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            string termo = txbCliente.Text.Trim().ToLower();

            clienteSelecionado = Listas.Clientes
                .FirstOrDefault(c => c.Nome.ToLower().Contains(termo) || c.RA.ToLower() == termo);

            if (clienteSelecionado != null)
            {
                txbCliente.Text = clienteSelecionado.Nome;
                txbRA.Text = clienteSelecionado.RA;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado.");
            }
        }



        // Confirma e registra o empréstimo
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime dataEmprestimo = dtpEmprestimo.Value.Date;
            dtpDevolucao.MaxDate = dataEmprestimo.AddDays(30);
            DateTime dataParaDevolucao = dtpDevolucao.Value.Date;

            string erro = VerificaRealizacaoEmp.VerificarCampos(
                livroSelecionado,
                clienteSelecionado,
                dataEmprestimo,
                dataParaDevolucao
            );

            if (erro != null)
            {
                MessageBox.Show(erro);
                return;
            }

            if (livroSelecionado == null || clienteSelecionado == null)
            {
                MessageBox.Show("Selecione o cliente e o livro antes de confirmar.");
                return;
            }

            if (livroSelecionado.Quantidade <= 0)
            {
                MessageBox.Show("Livro indisponível para empréstimo.");
                return;
            }

            var novoEmprestimo = new TestePIM.Dados.Emprestimo
            {
                Cliente = clienteSelecionado,
                Livro = livroSelecionado,
                DataEmprestimo = dataEmprestimo,
                DataParaDevolucao = dataParaDevolucao,
                Status = true,                
            };

            livroSelecionado.Quantidade--;
            Listas.Emprestimos.Add(novoEmprestimo);

            MessageBox.Show("Empréstimo registrado com sucesso!");
        }

        // Cancela a operação e fecha a tela
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Volta para a tela anterior
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
