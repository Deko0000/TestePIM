using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePIM
{
    public static class VerificaAdm
    {
        // Indica se o usuário logado possui privilégios de administrador
        public static bool IsAdmin { get; private set; } = false;

        // Armazena o funcionário atualmente logado no sistema
        public static Funcionario FuncionarioLogado { get; private set; }

        // Realiza o login de um funcionário e define se ele é administrador
        public static void Logar(Funcionario funcionario, bool isAdmin)
        {
            FuncionarioLogado = funcionario;
            IsAdmin = isAdmin;
        }

        // Realiza o logout, limpando as informações do funcionário logado e privilégios
        public static void Logout()
        {
            FuncionarioLogado = null;
            IsAdmin = false;
        }
    }
}

