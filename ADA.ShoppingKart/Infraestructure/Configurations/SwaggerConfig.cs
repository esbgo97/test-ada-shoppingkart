using Microsoft.OpenApi.Models;

namespace ADA.ShoppingKart.Infraestructure.Configurations
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfig(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "ADA Shopping Kart API",
                    Description = "Powered By Edward Bustos | 2023",
                    //TermsOfService = new Uri("https://www.google.com/"),
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Edward Bustos",
                        Email = "esbgo97@gmail.com",
                        Url = new Uri("https://esbgo97.github.io/cv/"),
                    }
                });

                var securitySchema = new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                };
                c.AddSecurityDefinition("Bearer", securitySchema);

                var securityRequirement = new OpenApiSecurityRequirement();
                securityRequirement.Add(securitySchema, new[] { "Bearer" });
                c.AddSecurityRequirement(securityRequirement);

            });

        }

        public static void UseSwaggerConfig(this IApplicationBuilder app, IWebHostEnvironment env = null)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ADA Shopping Kart API V1");
            });

        }
    }
}
