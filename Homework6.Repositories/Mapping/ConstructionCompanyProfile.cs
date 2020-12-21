using AutoMapper;
using Homework6.DAL.Domain;
using Homework6.Models.DTO;

namespace Homework6.Repositories.Mapping
{
    /// <summary>
    /// Профиль маппинга (Застройщик).
    /// </summary>
    public class ConstructionCompanyProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ConstructionCompanyProfile"/>
        /// </summary>
        public ConstructionCompanyProfile()
        {
            CreateMap<ConstructionCompany, ConstructionCompanyDTO>().ReverseMap();
        }
    }
}
