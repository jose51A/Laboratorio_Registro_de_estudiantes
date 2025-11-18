using System;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Para Interaction.InputBox

namespace LabRegistroAuth
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Solicitar código rápido de administrador
            string codigo = Interaction.InputBox(
                "Ingrese el código de administrador para continuar:",
                "Autenticación",
                "");

            if (!AdminAuthenticator.ValidarCodigoAdministrador(codigo))
            {
                MessageBox.Show("Código incorrecto. La aplicación se cerrará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new MainForm());
        }
    }
}