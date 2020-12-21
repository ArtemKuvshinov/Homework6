using System.ComponentModel.DataAnnotations;

namespace Homework6.Models.DTO
{
    public class ConstructionCompanyDTO : BaseDto
    {
        /// <summary>
        /// Наименование.
        /// </summary>
        [StringLength(300)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Адрес электронной почты.
        /// </summary>
        [StringLength(100)]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
