using AutoMapper;
using Homework6.Models.DTO;
using Homework6.Models.Requests.ConstructionCompany;
using Homework6.Models.Responses.ConstructionCompany;

namespace Homework6.Controllers.Mapping
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности "Застройщик".
    /// </summary>
    public class ConstructionCompanyProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ConstructionCompanyProfile"/>.
        /// </summary>
        public ConstructionCompanyProfile()
        {
            CreateMap<CreateConstructionCompanyRequest, ConstructionCompanyDTO>();
            CreateMap<UpdateConstructionCompanyRequest, ConstructionCompanyDTO>();
            CreateMap<ConstructionCompanyDTO, ConstructionCompanyResponse>();
        }
    }
}
