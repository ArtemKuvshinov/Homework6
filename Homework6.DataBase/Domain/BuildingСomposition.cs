using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework6.DAL.Domain
{
    /// <summary>
    /// Материалы используемые при строительстве здания.
    /// </summary>
    public class BuildingСomposition : BaseEntityWithLinks<Building, Material>
    {
    }
}
