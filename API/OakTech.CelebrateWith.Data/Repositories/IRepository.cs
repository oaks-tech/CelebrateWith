using OakTech.CelebrateWith.Data.Entities;

namespace OakTech.CelebrateWith.Data.Repositories
{
    public interface IRepository<TEntity> 
        where TEntity : Entity
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(Guid id);
        void Save(TEntity entity);
        void Delete(Guid id);
        TEntity Update(Guid id, TEntity entity);
    }
}
