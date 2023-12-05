using Microsoft.Reporting.WinForms;
using ProyectoVenta.Formularios;
using System.Configuration;
using System.Net;

namespace AdminSuppliers.Presenter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new Inicio());
        }
    }
}

