using System.Threading.Tasks;

namespace Homework6.Repositories.Interfaces.CRUD
{
    /// <summary>
    /// Интерфейс для удаления сущностей.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Domain model.</typeparam>
    public interface IDeletable
    {
        /// <summary>
        /// Групповое удаление сущностей.
        /// </summary>
        /// <param name="ids">Идентификаторы.</param>
        void Delete(params long[] ids);
    }
}