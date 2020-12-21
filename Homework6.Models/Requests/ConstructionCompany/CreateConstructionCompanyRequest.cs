using Homework6.DAL.Domain;
using System.ComponentModel.DataAnnotations;

namespace Homework6.Models.Requests.ConstructionCompany
{
    /// <summary>
    /// Запрос на создание новой записи Застройщик.
    /// </summary>
    public class CreateConstructionCompanyRequest
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
