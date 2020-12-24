using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Homework6.Models.Requests
{
    /// <summary>
    /// Запрос Логина и пароля.
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        [Required]
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        /// <summary>
        /// Пароль.
        /// </summary>
        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
