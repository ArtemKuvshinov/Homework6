using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Homework6.DAL.Contexts
{ 
    /// <summary>
    /// Фабрика для создания нового контекста в процессе миграций.
    /// </summary>
    internal sealed class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<Homework4Context>
    {
        /// <summary>
        /// Создание контекста для миграций.
        /// </summary>
        /// <param name="args">Строковые аршументы миграций.</param>
        /// <returns>Контекст.</returns>
        public Homework4Context CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                               .SetBasePath(Directory.GetCurrentDirectory())
                               .AddJsonFile("appsettings.json", false, true)
                               .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
                                        true, true)
                               .AddEnvironmentVariables()
                               .Build();

            var connectionString = configuration.GetConnectionString(nameof(Homework4Context));

            var builder = new DbContextOptionsBuilder<Homework4Context>()
                   .UseNpgsql(connectionString, __options =>
                   {
                       __options.MigrationsAssembly(typeof(Homework4Context).Assembly.FullName);
                   });

            var context = new Homework4Context(builder.Options);

            return context;
        }
    }
}
