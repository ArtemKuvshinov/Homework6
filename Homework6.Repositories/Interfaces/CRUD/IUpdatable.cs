using System.Threading;
using System.Threading.Tasks;

namespace Homework6.Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс для изменения сущности.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Domain model.</typeparam>
    public interface IUpdatable<TDto, TModel>
    {
        /// <summary>
        /// Изменение сущности.
        /// </summary>
        /// <param name="dto">DTO.</param>
        void Update(TDto dto);
    }
}