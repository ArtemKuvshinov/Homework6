using System;
using System.Collections.Generic;
using System.Text;
using Homework6.Models.DTO;
using Homework6.Services.Interfaces;
using AutoMapper;
using Homework6.DAL.Domain;
using System.Linq;
using Homework6.DAL.Contexts;
using Homework6.Repositories.Interfaces;
using System.Threading;

namespace Homework6.Services.Services
{
    /// <summary>
    /// Сервис для работы с данными "Здание".
    /// </summary>
    /// <inheritdoc cref="IBuildingService"/>
    public class BuildingService : IBuildingService
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Инициализирует экземпляр <see cref="BuildingService"/>.
        /// </summary>
        /// <param name="repository">Репозиторий</param>
        public BuildingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        ///<inheritdoc cref="ICreatable{TDto}.Create(TDto)"/>
        public void Create(BuildingDTO dto)
        {
            _unitOfWork.BeginTrasaction();
            try
            {
                _unitOfWork.Building.Create(dto);
                _unitOfWork.CommitTrasaction();
            }
            catch (Exception ex)
            {
                _unitOfWork.RollBackTrasaction();
            }
        }

        /// <inheritdoc cref="IGettableById{TDto}.Get(long, CancellationToken)"/>
        public BuildingDTO Get(long id, CancellationToken token = default)
        {
            return _unitOfWork.Building.Get(id);
        }

        /// <inheritdoc cref="IGettable{TDto}.Get(CancellationToken)"/>
        public IEnumerable<BuildingDTO> Get(CancellationToken token = default)
        {
            return _unitOfWork.Building.Get();
        }

        /// <inheritdoc cref="IUpdatable{TDto}.Update(TDto)"/>
        public void Update(BuildingDTO dto)
        {
            _unitOfWork.BeginTrasaction();
            try
            {
                _unitOfWork.Building.Update(dto);
                _unitOfWork.CommitTrasaction();
            }
            catch (Exception ex)
            {
                _unitOfWork.RollBackTrasaction();
            }
        }

        /// <inheritdoc cref="IDeletable.Delete(long[])"/>
        public void Delete(params long[] ids)
        {
            _unitOfWork.BeginTrasaction();
            try
            {
                _unitOfWork.Building.Delete(ids);
                _unitOfWork.CommitTrasaction();
            }
            catch (Exception ex)
            {
                _unitOfWork.RollBackTrasaction();
            }
        }

    }
}
