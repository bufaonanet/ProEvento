using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProEventos.Persistence.Context;
using ProEventos.Persistence.Interfaces;

namespace ProEventos.Persistence
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ProEventosContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(ProEventosContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void add(TEntity entity) 
        {
            _dbSet.Add(entity);            
        }

        public void Update(TEntity entity) 
        {
            _dbSet.Update(entity);
        }

        public void Delete(TEntity entity) 
        {
            _dbSet.Remove(entity);
        }

        public void DeleteRange(TEntity[] entityArray) 
        {
            _dbSet.RemoveRange(entityArray);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}