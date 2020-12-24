using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace Homework6.Models.Responses
{
    /// <summary>
    /// Ответ после авторизации.
    /// </summary>
    public class LoginResult
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("originalUserName")]
        public string OriginalUserName { get; set; }

        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }
    }

    /// <summary>
    /// Запрос на обновление Refresh токена.
    /// </summary>
    public class RefreshTokenRequest
    {
        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; }
    }
}
