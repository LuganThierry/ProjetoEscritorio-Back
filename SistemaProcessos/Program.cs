using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using SistemaProcessos.Data;
using SistemaProcessos.Repositories;
using SistemaProcessos.Repositories.Interfaces;

namespace SistemaProcessos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkMySql()
                .AddDbContext<SistemaProcessosDBContext>(
                    options => options.UseMySql(builder.Configuration.GetConnectionString("DataBase"),
                        new MySqlServerVersion(new Version(8, 0, 30)))
                );



            builder.Services.AddScoped<IPessoasRepository, PessoasRepository>();
            builder.Services.AddScoped<IProcessosRepository, ProcessosRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(options =>
            {
                options.AllowAnyOrigin();
                options.AllowAnyMethod();
                options.AllowAnyHeader();
            });

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}