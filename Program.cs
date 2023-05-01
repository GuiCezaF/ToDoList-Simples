using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Repostorys;
using ToDoList.Data;
using ToDoList.Repositorys.Interfaces;

namespace ToDoList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<SistemaDeTarefasDBContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));

            builder.Services.AddScoped<ITarefaRepository, TarefaRepository>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}