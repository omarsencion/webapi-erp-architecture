﻿using System.Linq;
using EMS.Core.Domain.Entities;
using EMS.Core.Domain.Specification;

namespace EMS.Core.Domain.Service
{
    public interface IService<TEntity> : IWriteOnlyService<TEntity> where TEntity : IAggregateRoot, new()
    {
        TEntity FindBy(ISpecification<TEntity> spec, bool @readonly = false);

        IQueryable<TEntity> FilterBy(ISpecification<TEntity> spec, bool @readonly = false);

        IQueryable<TEntity> GetAll(bool @readonly = false);

        TEntity GetById(object id, bool @readonly = false);
    }
}