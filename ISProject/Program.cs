using ISProject.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Windows.Forms;
using System;
using ISProject.Interfaces;
using ISProject.Realizations;

namespace ISProject
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
             .ConfigureAppConfiguration((hostingContext, config) =>
             {
                 config.AddJsonFile("appsettings.json");
             })
             .ConfigureServices((hostContext, services) =>
             {
                 services.AddDbContextFactory<ISDataContext>(options =>
                 {
                     options.UseSqlServer(hostContext.Configuration.GetConnectionString("DefaultConnection"));
                 });
                 services.AddSingleton<IISResourceService, ISResourceService>();
                 services.AddSingleton<Authorization>();
                 services.AddSingleton<ErrorForm>();
                 services.AddSingleton<Register>();
                 services.AddSingleton<SuccessForm>();
                 services.AddSingleton<MainMenu>();
                 services.AddSingleton<AddingHolding>();
                 services.AddSingleton<AddingCompany>();


             });
            using (var host = builder.Build())
            {
                var form = host.Services.GetRequiredService<Authorization>();
                Application.Run(form);
            }
        }
    }
}