using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM
{
    public static class GerarIdentificacao
    {
        // Armazena o último ID gerado para funcionário
        private static int ultimoIdFuncionario = 0;
        // Armazena o último ID gerado para livro
        private static int ultimoIdLivro = 0;

        // Gera um novo ID e número de identificação para funcionário
        // Retorna uma tupla com o ID e o número de identificação formatado (ex: FUNC0001)
        public static (int, string) GerarIDFuncionario()
        {
            ultimoIdFuncionario++;
            string numIdentifica = "FUNC" + ultimoIdFuncionario.ToString("D4");
            return (ultimoIdFuncionario, numIdentifica);
        }

        // Gera um novo ID para livro e retorna esse ID
        public static int GerarIDLivro()
        {
            ultimoIdLivro++;
            return ultimoIdLivro;
        }
    }
}

