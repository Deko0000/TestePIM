using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM.Dados
{
    public class LeituraLocal
    {
        // Cliente que está realizando a leitura local
        public Cliente Cliente { get; set; }

        // Livro que está sendo lido
        public Livro Livro { get; set; }

        // Data em que a leitura foi realizada
        public DateTime DataLeitura { get; set; }

        //determina o valor do empréstimo
        public decimal ValorTotal { get; set; }
        public bool Status { get; set; }

        // Forma de pagamento utilizada
        public string FormaPagamento { get; set; }
    }
}
