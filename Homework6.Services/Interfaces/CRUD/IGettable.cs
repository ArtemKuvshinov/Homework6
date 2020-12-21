using System.Collections.Generic;
using System.Threading;

namespace Homework6.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для получения сущностей.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Domain model.</typeparam>
    public interface IGettable<TDto>
    {
        /// <summary>
        /// Получение сущностей.
        /// </summary>
        /// <param name="token">Экземпляр <see cref="CancellationToken"/>.</param>
        /// <returns>Сущности.</returns>
        IEnumerable<TDto> Get(CancellationToken token = default);
    }
}