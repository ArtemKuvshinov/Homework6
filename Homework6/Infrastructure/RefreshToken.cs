using System;
using System.Text.Json.Serialization;

namespace Homework6.Infrastructure
{
    /// <summary>
    /// RT model.
    /// </summary>
    public class RefreshToken
    {
        /// <summary>
        /// User name.
        /// </summary>
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        /// <summary>
        /// RT value.
        /// </summary>
        [JsonPropertyName("tokenString")]
        public string TokenString { get; set; }

        /// <summary>
        /// Expipe date.
        /// </summary>
        [JsonPropertyName("expireAt")]
        public DateTime ExpireAt { get; set; }
    }
}
