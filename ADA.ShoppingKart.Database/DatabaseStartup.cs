using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.DependencyInjection;

namespace ADA.ShoppingKart.Database
{
    public static class DatabaseStartup
    {
        public static void AddDatabaseConfig(this IServiceCollection services, string connection)
        {
            services.AddDbContext<ShoppingKartDBContext>(options => {
                options.UseSqlServer(connection);
            })
            .BuildServiceProvider();
            services.AddScoped<DbContext, ShoppingKartDBContext>();
        }
    }
}