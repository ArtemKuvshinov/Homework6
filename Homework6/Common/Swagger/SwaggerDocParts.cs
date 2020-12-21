using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework6.Common.Swagger
{
    /// <summary>
    /// Константы для указания частей API в Swagger.
    /// </summary>
    public sealed class SwaggerDocParts
    {
        /// <summary>
        /// Константа для swagger-документа "Здание".
        /// </summary>
        public const string Buildings = nameof(Buildings);

        /// <summary>
        /// Константа для swagger-документа "Застройщик".
        /// </summary>
        public const string ConstructionCompany = nameof(ConstructionCompany);
    }
}
