using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDeNegocio;
using AcessoADados;


namespace ProjetoSistemaMaquiagem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*  Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);
              Application.Run(new TelaPrincipal()); */

            ClnFuncionario funcionario = new ClnFuncionario();
            funcionario.Nm_Funcionario = "Cuzão";
            funcionario.CPF_Funcionario = "66666666666";
            funcionario.Email_Funcionario = "cuzao@gmail.com";
            funcionario.Login_Funcionario = "Cuzao666";
            funcionario.Senha_Funcionario = "suamae";

            funcionario.Gravar();

            ClnLogin login = new ClnLogin();

            login.validarLogin("Cuzao666","suamae");

            login.validarLogin("aaa", "111");


        }
    }
}
