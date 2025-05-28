using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM
{
    public class Livro
    {
        // Identificador único do livro
        public int Id { get; set; }

        // Título do livro
        public string Titulo { get; set; }

        // Nome do autor do livro
        public string Autor { get; set; }

        // Código ISBN do livro
        public string ISBN { get; set; }

        // Ano de publicação do livro
        public string AnoPubli { get; set; }

        // Quantidade de exemplares disponíveis
        public int Quantidade { get; set; }

        // Gênero literário do livro
        public string Genero { get; set; }

        // Sinopse ou resumo do livro
        public string Sinopse { get; set; }

        //Valor empréstimo
        public decimal ValorEmp { get; set; }
         
        // Caminho para a imagem da capa do livro
        public string CaminhoCapa { get; set; }

        // Construtor que inicializa as propriedades do livro
        public Livro(string titulo, string autor, string isbn,
            string anoPubli, int quantidade, string genero, string sinopse, string caminhoCapa)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            AnoPubli = anoPubli;
            Quantidade = quantidade;
            Genero = genero;
            Sinopse = sinopse;
            CaminhoCapa = caminhoCapa;
        }

        // Método para definir o identificador único do livro
        public void DefinirIdentificacao()
        {
            Id = GerarIdentificacao.GerarIDLivro(); // Gera um novo ID para o livro
        }
    }
}
