﻿namespace Homework6.DAL.Domain
{
    /// <summary>
    /// User roles.
    /// </summary>
    public class UserRoles
    {
        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// User.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Role.
        /// </summary>
        public Role Role { get; set; }
    }
}
