using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6.Models.DTO
{
    /// <summary>
    /// Базовый класс для DTO.
    /// </summary>
    public abstract class BaseDto
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        public long Id { get; set; }
    }
}
