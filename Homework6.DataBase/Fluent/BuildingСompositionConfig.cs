using Homework6.DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework6.DAL.Fluent
{
    /// <summary>
    /// Конфигурация миграций для <see cref="BuildingСomposition"/>.
    /// </summary>
    public class BuildingСompositionConfig : IEntityTypeConfiguration<BuildingСomposition>
    {
        /// <summary>
        /// Конфигурирование сущности <see cref="BuildingСomposition"/>.
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<BuildingСomposition> builder)
        {
            builder.BaseEntityWithLinksConfig<BuildingСomposition, Building, Material>(
                e => e.BuildingСompositions,
                e => e.BuildingСompositions);

            builder.ToTable("BuildingСompositions");
        }
    }
}
