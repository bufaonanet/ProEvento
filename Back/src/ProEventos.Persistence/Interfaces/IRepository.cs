using System.Threading.Tasks;

namespace ProEventos.Persistence.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {       
        void add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteRange(TEntity[] entity);
        Task<bool> SaveChangesAsync();
    }
}