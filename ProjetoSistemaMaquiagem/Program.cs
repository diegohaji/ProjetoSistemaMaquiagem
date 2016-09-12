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
              Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);
              Application.Run(new TelaPrincipal());

            //ClnCliente cliente = new ClnCliente();
            //cliente.Cd_cliente = 666;
            //cliente.Nm_Cliente = "CAPIROSCO";
            //cliente.CPF_cliente = "10035965607";
            //cliente.Email_cliente = "capeta@paunoseucu.com";
            //cliente.Gravar();
        }
    }
}
