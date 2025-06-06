using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePIM.Controle.Emprestimo;

namespace TestePIM.Telas.Relatorio
{
    public partial class RelatLivroGeral : Form
    {
        public RelatLivroGeral()
        {
            InitializeComponent();
        }

        private void CarregarCardLivro(Livro livro)
        {
            panelLivro.Controls.Clear();
            var card = CardLivroEmp.CriarCard(livro);
            card.Left = (panelLivro.Width - card.Width) / 2;
            panelLivro.Controls.Add(card);
        }
        private void btnBuscaInf_Click(object sender, EventArgs e)
        {
            // 1. Livro mais emprestado
            var livroMaisEmprestado = Listas.Emprestimos
                .GroupBy(emp => emp.Livro)
                .OrderByDescending(g => g.Count())
                .Select(g => new { Livro = g.Key, Total = g.Count() })
                .FirstOrDefault();

            // 2. Autor mais emprestado
            var autorMaisEmprestado = Listas.Emprestimos
                .GroupBy(emp => emp.Livro.Autor)
                .OrderByDescending(g => g.Count())
                .Select(g => new { Autor = g.Key, Total = g.Count() })
                .FirstOrDefault();

            // 3. Gênero mais emprestado
            var generoMaisEmprestado = Listas.Emprestimos
                .GroupBy(emp => emp.Livro.Genero)
                .OrderByDescending(g => g.Count())
                .Select(g => new { Genero = g.Key, Total = g.Count() })
                .FirstOrDefault();

            // 4. Total de empréstimos
            int totalEmprestimos = Listas.Emprestimos.Count;

            // 5. Total de multas
            int totalMultas = Listas.Multas.Count;

            // 6. Preencher TextBoxes com as informações
            txbLivMaisEmp.Text = livroMaisEmprestado?.Livro?.Titulo ?? "Nenhum";
            txbAutMaisPopular.Text = autorMaisEmprestado?.Autor ?? "Nenhum";
            txbGenMaisPopular.Text = generoMaisEmprestado?.Genero ?? "Nenhum";
            txbQuantEmp.Text = totalEmprestimos.ToString();
            txbQuantMultas.Text = totalMultas.ToString();

            // 7. Exibir a capa do livro mais emprestado no Panel
            CarregarCardLivro(livroMaisEmprestado?.Livro);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Buscar livro mais emprestado
            var livroMaisEmprestado = Listas.Emprestimos
                .GroupBy(emp => emp.Livro)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            if (livroMaisEmprestado == null)
            {
                MessageBox.Show("Não há empréstimos registrados para gerar relatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gerar objeto relatório
            var relatorio = new TestePIM.Dados.Relatorio
            {
                Livro = livroMaisEmprestado,
                Emprestimo = Listas.Emprestimos.FirstOrDefault(emp => emp.Livro == livroMaisEmprestado),
                Multa = Listas.Multas.FirstOrDefault(), // Pode personalizar para multa mais recente ou relevante
                Cliente = Listas.Emprestimos.FirstOrDefault(emp => emp.Livro == livroMaisEmprestado)?.Cliente,
                Funcionario = Listas.Emprestimos.FirstOrDefault(emp => emp.Livro == livroMaisEmprestado)?.Funcionario
            };

            relatorio.DefinirIdentificacao(); // Se tiver geração automática de ID

            // Adicionar à lista
            Listas.Relatorios.Add(relatorio);

            MessageBox.Show("Relatório confirmado e salvo com sucesso!", "Relatório", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
