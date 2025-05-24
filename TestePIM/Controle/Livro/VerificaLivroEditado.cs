using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Controle
{
    internal class VerificaLivroEditado
    {
        public bool Validar(Livro livro)
        {
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

            if (!int.TryParse(livro.AnoPubli, out int ano) || livro.AnoPubli.Length != 4)
            {
                MessageBox.Show("Digite um Ano válido.");
                return false;
            }           
            

            return true;
        }
    }
}
