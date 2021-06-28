using ChanterelleProject.ClientServices.Services;
using ChanterelleProject.GlobalServices.Services;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Global;
using ConnectionDataBase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Data.SqlClient;


namespace ChanterelleProject.Api
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ChanterelleProject.Api", Version = "v1" });
            });
            services.AddSingleton<IConnection>((sp) => new Connection(SqlClientFactory.Instance, Configuration.GetConnectionString("ConnectionChanterelleDbProject")));
            
            services.AddSingleton<IUtilisateur<int, UtilisateurGlobal, UtilisateurFullAttributeForViewGlobal,ParaMedicalGlobal>, UtilisateurServicesGlobal>();
            services.AddSingleton<IUtilisateur<int, UtilisateurClient, UtilisateurFullAttributeForViewClient,ParaMedicalClient>, UtilisateurServiceClient>();

            services.AddSingleton<ISpecialisationParaMedical<int, SpecialisationParaMedicalGlobal>, SpecialisationParaMedicalServicesGlobal>();
            services.AddSingleton<ISpecialisationParaMedical<int, SpecialisationParaMedicalClient>, SpecialisationParaMedicalServicesClient>();

            services.AddSingleton<ITypeUtilisateur<int, TypeUtilisateurGlobal>, TypeUtilisateurServicesGlobal>();
            services.AddSingleton<ITypeUtilisateur<int, TypeUtilisateurClient>, TypeUtilisateurServicesClient>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ChanterelleProject.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
