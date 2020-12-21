using Homework6.DAL.Domain;
using Homework6.Models.DTO;
using Homework6.Repositories.Interfaces;
using AutoMapper;
using Homework6.DAL.Contexts;

namespace Homework6.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями Застройщик.
    /// </summary>
    public class ConstructionCompanyRepository : 
        BaseRepository<ConstructionCompanyDTO, ConstructionCompany>, 
        IConstructionCompanyRepository
    {
        public ConstructionCompanyRepository(Homework4Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
