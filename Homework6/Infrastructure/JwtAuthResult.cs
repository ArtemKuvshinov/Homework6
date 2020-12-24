using System.Text.Json.Serialization;

namespace Homework6.Infrastructure
{
    /// <summary>
    /// Tokens result.
    /// </summary>
    public class JwtAuthResult
    {
        /// <summary>
        /// AT.
        /// </summary>
        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        /// RT.
        /// </summary>
        [JsonPropertyName("refreshToken")]
        public RefreshToken RefreshToken { get; set; }
    }
}
