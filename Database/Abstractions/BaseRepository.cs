using Domain.Abstractions.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Abstractions;


/// <typeparam name="TModel">Модель базы данных</typeparam>
/// <typeparam name="TContext">Контекст базы данных</typeparam>
public abstract class BaseRepository<TModel, TContext> where TModel: BaseModel where TContext: DbContext
{
    protected readonly TContext _context;
    protected readonly DbSet<TModel> _database;

    public BaseRepository(TContext context, DbSet<TModel> database)
    {
        _context = context;
        _database = database;
    }
    
    public abstract IQueryable<TModel> Include();
    
    /// <summary>
    /// Выдаёт список состоящий из всех записей из базы данных
    /// </summary>
    /// <returns>Список всех записей</returns>
    public virtual async Task<List<TModel>> GetAllAsync()
    {
        return await Include().ToListAsync();
    }
    
    /// <summary>
    /// Добавляет запись в базу данных, но не сохраняет её.
    /// </summary>
    /// <param name="model">Новая модель</param>
    public virtual async Task AddAsync(TModel model)
    {
        await _database.AddAsync(model);
    }
    
    /// <summary>
    /// Обновляет запись в базе данных, но не сохраняет её.
    /// </summary>
    /// <param name="model">Изменённая модель</param>
    public virtual void Update(TModel model)
    {
        _database.Update(model);
    }

    /// <summary>
    /// Обновляет запись в базе данных путём копирование значений из новой модели в старую, но не сохраняет её.
    /// </summary>
    /// <param name="oldModel">Старая модель, в которую записывается значения</param>
    /// <param name="newModel">Новая модель, из которой читаются значения</param>
    public virtual void Update(TModel oldModel, TModel newModel)
    {
        _context.Entry(oldModel).CurrentValues.SetValues(newModel);
        _database.Update(oldModel);
    }
    
    /// <summary>
    /// Удаляет запись из базе данных, но не сохраняет изменения.
    /// </summary>
    /// <param name="model">Модель которую необходимо удалить</param>
    public virtual void Remove(TModel model)
    {
        _database.Remove(model);
    }

    /// <summary>
    /// Сохраняет и отправляет все сделанные изменения из оперативной памяти в базу данных.
    /// </summary>
    public virtual async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }
}