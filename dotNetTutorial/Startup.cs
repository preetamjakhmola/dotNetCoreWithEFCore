using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetTutorial.Contract;
using dotNetTutorial.DbModels;
using dotNetTutorial.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Infrastructure; 
namespace dotNetTutorial
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
         
        public void ConfigureServices(IServiceCollection services)
        {
             services.AddMvc(o => o.EnableEndpointRouting = false);
            services.AddControllers();
            // services.AddHttpClient();
            services.AddEntityFrameworkSqlServer();
            services.AddDbContextPool<StudentManagementContextRepository>((servProvider,opBuilder) => {
                opBuilder.UseSqlServer(Configuration.GetConnectionString("DbConstr"));
                opBuilder.UseInternalServiceProvider(servProvider);
            });
            services.AddTransient<IEmployee,Employee>(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            
            app.UseAuthorization();
           //  app.UseMvcWithDefaultRoute();
            app.UseMvc(route =>
            {
                route.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
