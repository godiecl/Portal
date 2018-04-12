using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Portal.DAO;

namespace Portal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            // Codigo para poblar la base de datos en caso de que no exista informacion
            using (IServiceScope scope = host.Services.CreateScope())
            {
                // Proveedor de los servicios
                IServiceProvider services = scope.ServiceProvider;

                try
                {
                    // Respositorio de Personas
                    IRepository<Models.Persona> repository = services.GetRequiredService<IRepository<Models.Persona>>();

                    if (repository.Find().ToList().Any())
                    {
                        return;
                    }

                    // Ingreso de informacion via repositorio
                    repository.Add(new Models.Persona {
                        RUT = "130144918",
                        Nombre = "Diego",
                        Paterno = "Urrutia",
                        Materno = "Astorga",
                        Password = "durrutia123"
                    });

                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Se produjo un error seteando la base de datos");
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
