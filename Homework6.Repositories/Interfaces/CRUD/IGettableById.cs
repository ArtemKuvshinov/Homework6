using System.Threading.Tasks;

namespace Homework6.Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс для получения сущности по идентификатору.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Domain model.</typeparam>
    public interface IGettableById<TDto, TModel>
    {
        /// <summary>
        /// Получение сущности по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Экземпляр сущности.</returns>
        TDto Get(long id);
    }
}