using System.Collections.Generic;

namespace DoomsdayLogs.Tool.Domain
{
    public interface IReadOnlyRepository<TEntity, TKey>
    {
        List<TEntity> SelectAll();

        TEntity SelectById(int id);
    }
}
