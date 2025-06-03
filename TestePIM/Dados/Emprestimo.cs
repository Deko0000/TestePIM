using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM.Dados
{
    public class Emprestimo
    {
        // Cliente que está realizando o empréstimo
        public Cliente Cliente { get; set; }

        // Livro que está sendo emprestado
        public Livro Livro { get; set; }

        // Funcionário responsável pelo empréstimo
        public Funcionario Funcionario { get; set; }

<<<<<<< HEAD
        //determina o valor do empréstimo
        public decimal ValorEmp { get; set; }
=======
        // ➕ Valor fixo cobrado pelo empréstimo
        public decimal ValorEmprestimo = 10.00m;
>>>>>>> 7e24c23518c4ec90d1ea46c46f2d3d8c715634f6

        // Data em que o empréstimo foi realizado
        public DateTime DataEmprestimo { get; set; }

        // Data prevista para devolução do livro
        public DateTime DataParaDevolucao { get; set; }

        //Data da Devolução de fato
        public DateTime? DataDevolvida { get; set; }

<<<<<<< HEAD
        //indica se foi pago ou não
        public bool Pago { get; set; }
=======
        // indica se a multa foi paga
        public bool Pago { get; set; } 
>>>>>>> 7e24c23518c4ec90d1ea46c46f2d3d8c715634f6

        // Status do empréstimo: true = ativo, false = devolvido
        public bool Status { get; set; }        
    
        // Construtor com valor fixo (ex: R$ 10,00)
       
    } 
}

