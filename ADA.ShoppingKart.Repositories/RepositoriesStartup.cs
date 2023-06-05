using ADA.ShoppingKart.Repositories.Interfaces;
using ADA.ShoppingKart.Repositories.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace ADA.ShoppingKart.Repositories
{
    public static class RepositoriesStartup
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();

        }
    }
}