﻿namespace TeleImot.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface ITeleImotDbContext
    {
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();

        void Dispose();
    }
}
