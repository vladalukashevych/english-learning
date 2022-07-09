using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Business.DataAccessors;
using SQLDataAccessor;

namespace WinForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static IServiceProvider ServiceProvider { get; set; }

        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new FormDesktop((ISetsDataAccessor)ServiceProvider.GetService(typeof(ISetsDataAccessor)), 
                (IWordsDataAccessor)ServiceProvider.GetService(typeof(IWordsDataAccessor))));
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<ISetsDataAccessor, SetsDataAccessor>().AddTransient<IWordsDataAccessor, WordsDataAccessor>();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
