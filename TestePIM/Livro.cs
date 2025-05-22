using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM
{
    public class Livro
    {
      
        public int Id { get; private set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public string AnoPubli { get; set; }
        public int Quantidade { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }

        public Livro(string titulo, string autor, string isbn, 
            string anoPubli, int quantidade, string genero, string sinopse)
        {
           
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            AnoPubli = anoPubli;
            Quantidade = quantidade;
            Genero = genero;
            Sinopse = sinopse;
            
        }
        public void DefinirIdentificacao()
        {
            
            Id = GerarIdentificacao.GerarIDLivro();           
        }

    }
}
