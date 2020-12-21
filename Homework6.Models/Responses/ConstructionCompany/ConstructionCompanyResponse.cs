
namespace Homework6.Models.Responses.ConstructionCompany
{
    /// <summary>
    /// Ответ на запросы для позиций Застройщик.
    /// </summary>
    public class ConstructionCompanyResponse
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Адрес электронной почты.
        /// </summary>
        public string Email { get; set; }
    }
}
