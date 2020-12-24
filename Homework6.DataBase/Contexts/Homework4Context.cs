using Microsoft.EntityFrameworkCore;
using Homework6.DAL.Domain;
using Homework6.DAL.Fluent;

namespace Homework6.DAL.Contexts
{
    /// <summary>
    /// Контекс для работы с БД "Здания".
    /// </summary>
    public class Homework4Context : DbContext
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="Homework4Context"/>.
        /// </summary>
        /// <param name="options">Опции для конфигурации контекста.</param>
        public Homework4Context(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Правила создания сущностей.
        /// </summary>
        /// <param name="builder">Билдер моделей.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
             builder.ApplyConfiguration(new BuildingСompositionConfig());
        }

        /// <summary>
        /// Здания.
        /// </summary>
        public DbSet<Building> Buildings { get; set; }

        /// <summary>
        /// Строительные компании.
        /// </summary>
        public DbSet<ConstructionCompany> ConstructionCompanies { get; set; }

        /// <summary>
        /// Материалы.
        /// </summary>
        public DbSet<Material> Materials { get; set; }

        /// <summary>
        /// Материалы используемые в конкретном здании.
        /// </summary>
        public DbSet<BuildingСomposition> BuildingСompositions { get; set; }

        /// <summary>
        /// Users.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Roles.
        /// </summary>
        public DbSet<Role> Roles { get; set; }

        /// <summary>
        /// User roles.
        /// </summary>
        public DbSet<UserRoles> UserRoles { get; set; }
    }
}
