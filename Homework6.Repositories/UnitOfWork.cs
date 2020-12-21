using System;
using System.Collections.Generic;
using System.Text;
using Homework6.Repositories.Interfaces;
using Homework6.DAL.Contexts;
using Homework6.Models.DTO;
using Homework6.DAL.Domain;
using AutoMapper;
using System.Data.Entity;

namespace Homework6.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly Homework4Context _сontext ;
        public IBuildingRepository Building { get; }
        public IConstructionCompanyRepository ConstructionCompany { get; }

        public UnitOfWork(Homework4Context сontext, IConstructionCompanyRepository constructionCompany, IBuildingRepository building)
        {
            this._сontext = сontext;
            this.Building = building;
            this.ConstructionCompany = constructionCompany;
        }

        /// <summary>
        /// Сохранение изменений в БД.
        /// </summary>
        public void Save()
        {
            _сontext.SaveChanges();
        }     

        /// <summary>
        /// Создание транзакции.
        /// </summary>
        public void BeginTrasaction()
        {
            _сontext.Database.BeginTransaction();
        }

        /// <summary>
        /// Коммит внесенных изменений.
        /// </summary>
        public void CommitTrasaction()
        {
            _сontext.Database.CommitTransaction();
        }

        /// <summary>
        /// Откат внесенных изменений.
        /// </summary>
        public void RollBackTrasaction()
        {
            _сontext.Database.RollbackTransaction();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                _сontext.Dispose();
        }
    }
}
