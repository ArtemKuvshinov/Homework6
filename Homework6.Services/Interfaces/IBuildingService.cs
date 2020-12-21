using System.Collections.Generic;
using Homework6.Models.DTO;
using Homework6.DAL.Domain;

namespace Homework6.Services.Interfaces
{
    /// <summary>
    /// Интерфейс для сервиса "Здание".
    /// </summary>
    public interface IBuildingService : ICrudService<BuildingDTO>
    {
    }
}
