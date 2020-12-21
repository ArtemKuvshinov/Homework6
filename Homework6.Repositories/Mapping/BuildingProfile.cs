using AutoMapper;
using Homework6.DAL.Domain;
using Homework6.Models.DTO;

namespace Homework6.Services.Mapping
{
    /// <summary>
    /// Профиль маппинга (здание).
    /// </summary>
    public class BuildingProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="BuildingProfile"/>
        /// </summary>
        public BuildingProfile()
        {
            CreateMap<Building, BuildingDTO>().ReverseMap();
        }
    }
}
