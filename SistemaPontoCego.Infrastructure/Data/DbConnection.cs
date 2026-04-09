using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EstiloUrbano.Infrastructure.Data;

namespace EstiloUrbano.Infrastructure
{
    public class DbConnection
    {
        public static void ConfigurarServicos(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=localhost;Database=ESTILOURBANO;Trusted_Connection=True;TrustServerCertificate=True;"));
        }
    }
}