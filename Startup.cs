using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcEFBootstrapAngular.Data;
using AspNetMvcEFBootstrapAngular.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AspNetMvcEFBootstrapAngular
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration Configuration)
        {
            configuration = Configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ItemsContext>(cfg =>
            cfg.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddControllersWithViews();
            services.AddTransient<INullMailService, NullMailService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseNodeModules();


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Fallback",
                    "{controller}/{action}/{id?}",
                    new { controller = "Items", action = "Index" });
            });
        }
    }
}
