using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM.Dados
{
    public class UsoComputador
    {
        // Cliente que está utilizando o computador
        public Cliente Cliente { get; set; }

        // Dia em que o computador foi utilizado
        public DateTime DataUso { get; set; }

        //determina o valor do empréstimo
        public decimal ValorTotal { get; set; }
        public bool Status { get; set; }

        // Forma de pagamento utilizada
        public string FormaPagamento { get; set; }

    }
}
