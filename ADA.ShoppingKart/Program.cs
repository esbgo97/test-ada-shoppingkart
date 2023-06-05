
using ADA.ShoppingKart.Infraestructure.Configurations;
using ADA.ShoppingKart.Database;
using Microsoft.Extensions.Configuration;

namespace ADA.ShoppingKart
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews();
            builder.Services.AddSwaggerConfig();
            builder.Services.AddCorsConfig();
            builder.Services.AddJWTConfig(builder.Configuration.GetValue<string>("SecretKey"));
            builder.Services.AddDatabaseConfig(builder.Configuration.GetConnectionString("DefaultConnection"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSwaggerConfig();
            app.UseCorsConfig();
            app.UseJWT();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=Index}/{id?}");

            app.MapFallbackToFile("index.html");

            app.Run();
        }
    }
}