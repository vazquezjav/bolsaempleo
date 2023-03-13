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
            services.AddSingleton<Microsoft.Extensions.Hosting.IHostEnvironment>();

            services.AddScoped<StateCivilService>();
            services.AddScoped<StateCivilRepository>();
            services.AddScoped<InstructionRepository>();
            services.AddScoped<InstructionService>();
        }

    }
}
