using Calc.Superpower;
using CalcCore;
using CalcCore.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CalcWinform1
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
            //INJECCION DE DEPENDENCIAS
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddScoped<ICalc, CalcNormal>().AddScoped<Form1>();




            using (var serviceProvider = serviceCollection.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }

        }
    }
}