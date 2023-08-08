namespace DoomsdayLogs.Tool.Domain
{
    public interface IRepository<TBaseEntity, Tkey>
    {
        bool Insert(TBaseEntity baseEntity);

        bool Edit(int id, TBaseEntity baseEntity);

        bool Delete(int id);

        bool Exist(int id);
    }
}
