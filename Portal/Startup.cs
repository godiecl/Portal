using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portal.DAO;
using Portal.Data;
using Portal.Models;

namespace Portal
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Utilizacion de base de datos en memoria (no persistente)
            services.AddDbContext<ApplicationDbContext>(
                optionsBuilder => optionsBuilder.UseInMemoryDatabase("db"));

            services.AddMvc();

            // Servicio de repositorio de Persona
            services.AddScoped<IRepository<Persona>, EntityRepository<Persona>>();
            services.AddScoped<IRepository<Vehiculo>, EntityRepository<Vehiculo>>();

            // services.AddScoped<IRepository<Clase>, EntityRepository<Clase>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
