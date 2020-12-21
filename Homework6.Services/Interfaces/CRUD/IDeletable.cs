namespace Homework6.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для удаления сущностей.
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