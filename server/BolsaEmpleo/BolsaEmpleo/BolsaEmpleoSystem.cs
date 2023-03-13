using BolsaEmpleo.BIL;
using BolsaEmpleo.BIL.LANDING;
using BolsaEmpleo.DAL.DBContext;
using BolsaEmpleo.DAL.LANDING;

namespace BolsaEmpleo
{
    public static class BolsaEmpleoSystem
    {
        public static void addInstanceSystem(IServiceCollection services)
        {
            services.AddSingleton<IDbContext, PgDbContext>();
            //services.AddScoped<Microsoft.Extensions.Hosting.IHostEnvironment>();

            services.AddScoped<StateCivilService>();
            services.AddScoped<StateCivilRepository>();
            services.AddScoped<InstructionRepository>();
            services.AddScoped<InstructionService>();
            services.AddScoped<PersonRepository>();
            services.AddScoped<PersonService>();
            services.AddScoped<PersonAplicationRepository>();
            services.AddScoped<PersonAplicationService>();
            services.AddScoped<DocumentRepository>();
            services.AddScoped<DocumentService>();
            services.AddScoped<PersonInstructionRepository>();
            services.AddScoped<PersonInstructionService>();

        }

    }
}
