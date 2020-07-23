using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Interfaces
{
    public interface IDbContext : IDisposable
    {
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
        IModel GetModel();
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
