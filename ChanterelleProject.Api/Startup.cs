using ChanterelleProject.ClientServices.Services;
using ChanterelleProject.GlobalServices.Services;
using ChanterelleProject.Interfaces;
using ChanterelleProject.Models.Client;
using ChanterelleProject.Models.Client.ModelClientForViews;
using ChanterelleProject.Models.Global;
using ChanterelleProject.Models.Global.ModelsGlobalForViews;
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
            
            services.AddSingleton<IUtilisateur<int, Models.Global.UtilisateurGlobal, UtilisateurViewGlobal, ParaMedicalGlobal>, UtilisateurServicesGlobal>();
            services.AddSingleton<IUtilisateur<int, UtilisateurClient, UtilisateurViewClient,ParaMedicalClient>, UtilisateurServiceClient>();

            services.AddSingleton<IServices<int, SpecialisationParaMedicalGlobal>, SpecialisationParaMedicalServicesGlobal>();
            services.AddSingleton<IServices<int, SpecialisationParaMedicalClient>, SpecialisationParaMedicalServicesClient>();

            services.AddSingleton<IServices<int, TypeUtilisateurGlobal>, TypeUtilisateurServicesGlobal>();
            services.AddSingleton<IServices<int, TypeUtilisateurClient>, TypeUtilisateurServicesClient>();

            services.AddSingleton<IServices<int, MedecinExterneGlobal>, MedecinExterneServicesGlobal>();
            services.AddSingleton<IServices<int, MedecinExterneClient>, MedecinExterneServicesClient>();

            services.AddSingleton<IClasse<int, ClasseGlobal, ClasseViewGlobal>, ClasseServicesGlobal>();
            services.AddSingleton<IClasse<int, ClasseClient, ClasseViewClient>, ClasseServicesClient>();

            services.AddSingleton<IAllocationParaMedicals<int, AllocationParaMedicalsGlobal, AllocationParaMedicalsViewGlobal>, AllocationParaMedicalsServicesGlobal>();
            services.AddSingleton<IAllocationParaMedicals<int, AllocationParaMedicalsClient, AllocationParaMedicalsViewClient>, AllocationParaMedicalsServicesClient>();

            services.AddSingleton<IAllocationClasses<int, AllocationClassesGlobal, AllocationClassesViewGlobal>, AllocationClassesServicesGlobal>();
            services.AddSingleton<IAllocationClasses<int, AllocationClassesClient, AllocationClassesViewClient>, AllocationClassesServicesClient>();
            
            services.AddSingleton<ITraitement<int, TraitementGlobal, TraitementViewGlobal>, TraitementServicesGlobal>();
            services.AddSingleton<ITraitement<int, TraitementClient, TraitementViewClient>, TraitementServicesClient>();

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
