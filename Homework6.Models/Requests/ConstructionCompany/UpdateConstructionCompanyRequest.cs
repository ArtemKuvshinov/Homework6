using System.ComponentModel.DataAnnotations;

namespace Homework6.Models.Requests.ConstructionCompany
{ 
    /// <summary>
    /// Запрос на изменение записи Застройщик.
    /// </summary>
    public class UpdateConstructionCompanyRequest
    {
        /// <summary>
        /// Идентификатор сущности.
        /// </summary>
        [Required]
        public long Id { get; set; }

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
