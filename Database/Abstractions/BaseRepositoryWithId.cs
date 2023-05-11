using Domain.Abstractions.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Abstractions;

public abstract class BaseRepositoryWithId<TModel, TContext> where TModel: BaseModelWithId where TContext: DbContext
{
    protected readonly TContext _context;
    protected readonly DbSet<TModel> _database;

    public BaseRepositoryWithId(TContext context, DbSet<TModel> database)
    {
        _context = context;
        _database = database;
    }
    
    public abstract IQueryable<TModel> Include();
    
    public virtual async Task<TModel?> GetByIdAsync(long id)
    {
        return await Include().SingleOrDefaultAsync(x => x.Id == id);
    }

    public virtual async Task<List<TModel>> GetAllAsync()
    {
        return await Include().ToListAsync();
    }
    
    public virtual async Task AddAsync(TModel model)
    {
        await _database.AddAsync(model);
    }
    
    public virtual void Update(TModel model)
    {
        _database.Update(model);
    }
    
    public virtual void Update(TModel oldModel, TModel newModel)
    {
        _context.Entry(oldModel).CurrentValues.SetValues(newModel);
        _database.Update(oldModel);
    }
    
    public virtual void Remove(TModel model)
    {
        _database.Remove(model);
    }

    public virtual async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }
}