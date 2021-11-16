using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Context.Repositories
{
  public class Repository<TEntity> : IRepository<TEntity> where TEntity: class, new()
  {
    protected readonly ApplicationContext _dbContext;

    public Repository(ApplicationContext dbContext)
    {
      this._dbContext = dbContext;
    }

    public IQueryable<TEntity> GetAll()
    {
      try
      {
        return _dbContext.Set<TEntity>();
      }
      catch (Exception e)
      {
        throw new Exception($"Couldn't retrieve entities: {e.Message}");
      }
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
      if (entity == null)
      {
        throw new Exception($"{nameof(AddAsync)} entity must be not be null");
      }

      try
      {
        await _dbContext.AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
      }
      catch (Exception ex)
      {
        throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
      }
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
      if (entity == null)
      {
        throw new Exception($"{nameof(AddAsync)} entity must be not be null");
      }

      try
      {
        _dbContext.Update(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
      }
      catch (Exception ex)
      {
        throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
      }
    }
  }
}