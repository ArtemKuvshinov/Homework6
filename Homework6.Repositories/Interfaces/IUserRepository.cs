using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6.Repositories.Interfaces
{
    /// Интерфейс для работы с объектами User.
    public interface IUserRepository
    {
        /// <summary>
        /// Проверка пользователя на существование.
        /// </summary>
        bool IsAnExistingUser(string userName);

        /// <summary>
        /// Проверка данных пользователя.
        /// </summary>
        bool IsValidUserCredentials(string userName, string password);

        /// <summary>
        /// Возвращает роль пользователя.
        /// </summary>
        string GetUserRole(string userName);
    }
}