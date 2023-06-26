using DoomsdayLogs.Domain;
using DoomsdayLogs.Domain.Shared;
using DoomsdayLogs.InfraORM;
using Microsoft.EntityFrameworkCore;

namespace DoomsdayLogs.Infra.ORM.BaseModule
{
    public class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey>,
        IReadOnlyRepository<TEntity, TKey>
        where TEntity : BaseEntity<TKey>, new()
    {
        private DoomsdayLogsDbContext _doomsdayLogsDbContext;
        private readonly DbSet<TEntity> dbSet;

        public BaseRepository(DoomsdayLogsDbContext doomsdayLogsDbContext)
        {
            _doomsdayLogsDbContext = doomsdayLogsDbContext;
            dbSet = doomsdayLogsDbContext.Set<TEntity>();
        }

        public bool Delete(int id)
        {
            TEntity baseEntityToRemove;
            try
            {
                baseEntityToRemove = SelectById(id);

                dbSet.Remove(baseEntityToRemove);
                _doomsdayLogsDbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(int id, TEntity baseEntity)
        {
            try
            {
                if (_doomsdayLogsDbContext.Entry(baseEntity).State != EntityState.Modified)
                {
                    var oldEntity = SelectById(id);

                    baseEntity.Id = id;

                    _doomsdayLogsDbContext.Entry(oldEntity).CurrentValues.SetValues(baseEntity);
                }

                _doomsdayLogsDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Exist(int id)
        {
            return dbSet.ToList().Exists(x => x.Id == id);
        }

        public bool Insert(TEntity baseEntity)
        {
            try
            {
                dbSet.Add(baseEntity);
                _doomsdayLogsDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TEntity> SelectAll()
        {
            return dbSet.ToList();
        }

        public TEntity SelectById(int id)
        {
            return dbSet.ToList().Find(x => x.Id == id);
        }
    }
}
