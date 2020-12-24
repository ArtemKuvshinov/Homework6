using Homework6.DAL.Contexts;
using Homework6.Repositories.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Homework6.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями User.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        Homework4Context _context;

        public UserRepository(Homework4Context context)
        {
            _context = context;
        }

        ///<inheritdoc/>
        public string GetUserRole(string userName)
        {
            if (!IsAnExistingUser(userName))
            {
                return string.Empty;
            }

            var role = _context.UserRoles
                        .Include(x => x.User)
                        .Include(x => x.Role)
                        .SingleOrDefault(x => x.User.Login == userName).Role?.Name;

            if (string.IsNullOrEmpty(role))
                throw new ArgumentNullException("Can't find role.");

            return role;
        }

        ///<inheritdoc/>
        public bool IsAnExistingUser(string userName)
        {
            return _context.Users.Any(x => x.Login == userName);
        }

        ///<inheritdoc/>
        public bool IsValidUserCredentials(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            return _context.Users.Any(x => x.Login == userName && x.Password == password);
        }
    }
}
