using Microsoft.Extensions.DependencyInjection;

using ADA.ShoppingKart.Business.Implementations;
using ADA.ShoppingKart.Business.Interfaces;

namespace ADA.ShoppingKart.Business
{
    public static class BusinessStartup
    {
        public static void AddBusiness(this IServiceCollection services)
        {
            services.AddTransient<IUserBusiness, UserBusiness>();
            //services.AddTransient<IProductRepository, ProductRepository>();
        }

    }
}