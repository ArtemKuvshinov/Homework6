using Homework6.DAL.Domain;
using Homework6.Models.DTO;
using Homework6.Repositories.Interfaces.CRUD;

namespace Homework6.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для с объектами Застройщик.
    /// </summary>
   public interface IConstructionCompanyRepository : ICrudRepository<ConstructionCompanyDTO, ConstructionCompany>
    {
    }
}
