namespace ADA.ShoppingKart.Infraestructure.Configurations
{
    public static class CorsConfig
    {
        public static void AddCorsConfig(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("DefaultPolicy",
                           builder =>
                           {
                               builder.AllowAnyOrigin()
                                    .WithOrigins("http://127.0.0.1:3000", "http://localhost:3000") //React Client
                                    .AllowAnyHeader()
                                    .AllowAnyMethod();
                           });
            });
        }

        public static void UseCorsConfig(this IApplicationBuilder app, IWebHostEnvironment? env = null)
        {
            app.UseCors("DefaultPolicy");
        }

    }
}
