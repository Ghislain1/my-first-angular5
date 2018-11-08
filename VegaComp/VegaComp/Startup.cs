using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Net;
using VegaComp.Interfaces;
using VegaComp.Persistence;

namespace VegaComp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IMakeRepository, MakeRepository>(); // TOD: Scoped becasue whey the request is done. the Gabagge collector should clean---

            services.AddScoped<IModelRepository, ModelRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //TODO: confurge the serve to call DB TODOD:See syntax of ConnectionString
            var connectionString = this.Configuration.GetConnectionString("Default");
            //if (!this.CheckConnection(connectionString))
            //{
            //    throw new Exception("Server is running" + connectionString);
            //}

            //
            services.AddAutoMapper();

            services.AddDbContext<VegaDbContext>(options => options.UseSqlServer(connectionString));

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        private bool CheckConnection(string connectionString)
        {
            bool result = false;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    result = true;
                }
            }
            catch (DbException ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}