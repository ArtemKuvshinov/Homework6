using Microsoft.Extensions.DependencyInjection;

namespace Homework6.Common.Swagger
{

    /// <summary>
    /// Расширения для конфигурации Swagger.
    /// </summary>
    public static class SwaggerConfiguration
    {
        /// <summary>
        /// Настройка документов Swagger.
        /// </summary>
        /// <param name="services">Коллекция сервисов для DI.</param>
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerDocument(c =>
            {
                c.Title = "Buildings";
                c.DocumentName = SwaggerDocParts.Buildings;
                c.ApiGroupNames = new[] { SwaggerDocParts.Buildings };
                c.GenerateXmlObjects = true;
            }).
            AddSwaggerDocument(c =>
            {
                c.Title = "ConstructionCompany";
                c.DocumentName = SwaggerDocParts.ConstructionCompany;
                c.ApiGroupNames = new[] { SwaggerDocParts.ConstructionCompany };
                c.GenerateXmlObjects = true;
            });


        }
    }
}
