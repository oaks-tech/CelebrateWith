using OakTech.CelebrateWith.Data.Entities;

namespace OakTech.CelebrateWith.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(Guid id, TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
