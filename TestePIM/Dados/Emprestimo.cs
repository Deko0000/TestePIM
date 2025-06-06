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

        // Data em que o empréstimo foi realizado
        public DateTime DataEmprestimo { get; set; }

        // Data prevista para devolução do livro
        public DateTime DataParaDevolucao { get; set; }

        //Data da Devolução de fato
        public DateTime? DataDevolvida { get; set; }       

        //indica se foi pago ou não
        public bool Pago { get; set; }        

        // Status do empréstimo: true = ativo, false = devolvido
        public bool Status { get; set; }


       


    } 
}

