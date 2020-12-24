using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Homework6.Repositories.Interfaces;
using Homework6.Services.Interfaces;

namespace Homework6.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Initialize <see cref="UserService"/>
        /// </summary>
        /// <param name="unitOfWork">UnitOfWork</param>
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        ///<inheritdoc/>
        public bool IsValidUserCredentials(string userName, string password)
        {
            return _unitOfWork.UserRepository.IsValidUserCredentials(userName, password);
        }

        ///<inheritdoc/>
        public bool IsAnExistingUser(string userName)
        {
            return _unitOfWork.UserRepository.IsAnExistingUser(userName);
        }

        ///<inheritdoc/>
        public string GetUserRole(string userName)
        {
            return _unitOfWork.UserRepository.GetUserRole(userName);
        }
    }
}
