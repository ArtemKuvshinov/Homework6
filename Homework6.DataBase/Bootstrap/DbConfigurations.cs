using Homework6.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Homework6.DAL.Bootstrap
{
    /// <summary>
    /// Конфигурации БД.
    /// </summary>
    public static class DbConfigurations    
    {
        /// <summary>
        /// Подключение DbContext.
        /// </summary>
        /// <param name="services">Коллекция сервисов.</param>
        /// <param name="configuration">Конфигурация.</param>
        public static void ConfigureDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Homework4Context>(    
                options => options.UseNpgsql(
                    configuration.GetConnectionString(nameof(Homework4Context)),
                    builder => builder.MigrationsAssembly(typeof(Homework4Context).Assembly.FullName))
            );
        }
    }
}
