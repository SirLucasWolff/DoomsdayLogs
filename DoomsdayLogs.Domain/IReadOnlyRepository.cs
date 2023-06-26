namespace DoomsdayLogs.Domain
{
    public interface IReadOnlyRepository<TEntity, TKey>
    {
        List<TEntity> SelectAll();

        TEntity SelectById(int id);
    }
}