using System.ComponentModel.DataAnnotations;

namespace Homework6.Models.DTO
{
   public class BuildingDTO : BaseDto
    {
        /// <summary>
        /// Адрес здания.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        /// <summary>
        ///  Назначение здания.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Purpose { get; set; }

        /// <summary>
        /// Количетсво этажей.
        /// </summary>
        [Required]
        public int NumberOfFloors { get; set; }

        /// <summary>
        /// Кадастровый номер.
        /// </summary>
        [Required]
        [RegularExpression(@"\d{2}[:]\d{6,7}[:]\d{2}[:]\d{2}")]
        public string CadastralNumber { get; set; }

        /// <summary>
        /// Поставщик.
        /// </summary>
        public ConstructionCompanyDTO ConstructionCompany { get; set; }

        /// <summary>
        /// Кол-во помещений.
        /// </summary>
        public int NumberOfFlat { get; set; }
    }
}
