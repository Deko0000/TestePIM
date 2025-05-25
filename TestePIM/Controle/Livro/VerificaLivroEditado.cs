using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Controle
{
    // Classe responsável por validar os dados de um livro editado
    internal class VerificaLivroEditado
    {
        // Método que valida os campos obrigatórios do livro
        public bool Validar(Livro livro)
        {
            // Verifica se algum campo obrigatório está vazio ou em branco
            if (string.IsNullOrWhiteSpace(livro.Titulo) ||
                string.IsNullOrWhiteSpace(livro.Autor) ||
                string.IsNullOrWhiteSpace(livro.ISBN) ||
                string.IsNullOrWhiteSpace(livro.AnoPubli) ||
                string.IsNullOrWhiteSpace(livro.Genero) ||
                string.IsNullOrWhiteSpace(livro.Sinopse))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return false;
            }

            // Verifica se o ano de publicação é um número inteiro de 4 dígitos
            if (!int.TryParse(livro.AnoPubli, out int ano) || livro.AnoPubli.Length != 4)
            {
                MessageBox.Show("Digite um Ano válido.");
                return false;
            }

            // Retorna verdadeiro se todas as validações forem atendidas
            return true;
        }
    }
}
