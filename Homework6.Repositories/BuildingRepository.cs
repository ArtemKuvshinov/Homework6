using Homework6.DAL.Contexts;
using Homework6.DAL.Domain;
using Homework6.Models.DTO;
using Homework6.Repositories.Interfaces;
using AutoMapper;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Homework6.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями Здание.
    /// </summary>
    public class BuildingRepository : 
        BaseRepository<BuildingDTO, Building>, 
        IBuildingRepository
    {
        public BuildingRepository(Homework4Context context, IMapper mapper) : base(context, mapper)
        {
        }

        protected override IQueryable<Building> DefaultIncludeProperties(DbSet<Building> dbSet)
        {
            return DbSet.Include(x => x.ConstructionCompany);
        }
    }
}
