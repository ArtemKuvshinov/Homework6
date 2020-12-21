using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6.Models.Responses.Building
{
    /// <summary>
    /// Ответ на запросы для позиций Здание.
    /// </summary>
    public class BuildingResponse
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Адрес здания
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        ///  Назначение здания
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// Количетсво этажей
        /// </summary>
        public int NumberOfFloors { get; set; }

        /// <summary>
        /// Кол-во помещений.
        /// </summary>
        public int NumberOfFlat { get; set; }

        /// <summary>
        /// Кадастровый номер
        /// </summary>
        public string CadastralNumber { get; set; }

        /// <summary>
        /// Название компании застройщика.
        /// </summary>
        public string ConstructionCompanyName { get; set; }

        /// <summary>
        /// Электронная почта застройщика.
        /// </summary>
        public string ConstructionCompanyEmail { get; set; }
    }
}
