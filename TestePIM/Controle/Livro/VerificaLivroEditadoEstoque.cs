using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Controle
{
    internal class VerificaLivroEditadoEstoque
    {
        // Método responsável por validar os dados do livro editado no estoque
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

            // Verifica se a quantidade está dentro do limite permitido (1 a 50)
            if (livro.Quantidade < 1 || livro.Quantidade > 50)
            {
                MessageBox.Show("Quantidade inválida. Máximo permitido: 50.");
                return false;
            }

            // Retorna verdadeiro se todas as validações forem atendidas
            return true;
        }
    }
}
