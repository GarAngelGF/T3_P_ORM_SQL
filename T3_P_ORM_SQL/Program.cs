using T3_P_ORM_SQL.Modelos;
using Microsoft.EntityFrameworkCore;

namespace T3_P_ORM_SQL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new Contextobd())
            {
                // Llamas al inicializador
                InicializarDB.Inicializar(context);
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
        
    }
}