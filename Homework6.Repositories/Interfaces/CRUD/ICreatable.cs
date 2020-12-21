using System.Threading.Tasks;

namespace Homework6.Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс для создания сущности.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Domain model.</typeparam>
    public interface ICreatable<TDto, TModel>
    {
        /// <summary>
        /// Создание сущности.
        /// </summary>
        /// <param name="dto">DTO.</param>
        void Create(TDto dto);
    }
}