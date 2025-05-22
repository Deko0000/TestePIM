using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM
{
    public static class GerarIdentificacao
    {
        private static int ultimoIdFuncionario = 0;
        private static int ultimoIdCliente = 0;
        private static int ultimoIdLivro = 0;

        // Para funcionário: retorna ID e Número de Identificação
        public static (int, string) GerarIDFuncionario()
        {
            ultimoIdFuncionario++;
            string numIdentifica = "FUNC" + ultimoIdFuncionario.ToString("D4");
            return (ultimoIdFuncionario, numIdentifica);
        }

        // Para cliente: só ID
        public static int GerarIDCliente()
        {
            ultimoIdCliente++;
            return ultimoIdCliente;
        }

        // Para livro: só ID
        public static int GerarIDLivro()
        {
            ultimoIdLivro++;
            return ultimoIdLivro;
        }
    }
}

