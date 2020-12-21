using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework6.DAL.Domain
{
    /// <summary>
    /// Строительный материал.
    /// </summary>
    public class Material : BaseEntity
    {
        /// <summary>
        /// Наименование.
        /// </summary>
        [StringLength(300)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Единица измерения.
        /// </summary>
        [StringLength(50)]
        [Required]
        public string Unit { get; set; }

        /// <summary>
        /// Срок службы.
        /// </summary>
        [Required]
        public int LifeTime { get; set; }

        /// <summary>
        /// Состав строительных материалов в здании.
        /// </summary>
        public ICollection<BuildingСomposition> BuildingСompositions { get; set; }
    }
}
