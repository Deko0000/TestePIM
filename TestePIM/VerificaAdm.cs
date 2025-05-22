using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM
{
    public static class VerificaAdm
    {
        public static bool IsAdmin { get; private set; } = false;
        public static string FuncionarioLogado { get; private set; }

        public static void Logar(string funcionario, bool isAdmin)
        {
            FuncionarioLogado = funcionario;
            IsAdmin = isAdmin;
        }

        public static void Logout()
        {
            FuncionarioLogado = null;
            IsAdmin = false;
        }

    }
}

