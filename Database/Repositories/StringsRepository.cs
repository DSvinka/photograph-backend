using Database.Abstractions;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories;

public class StringsRepository: BaseRepository<StringModel, AppDbContext>
{
    public StringsRepository(AppDbContext context) : base(context, context.Strings)
    {
    }
    
    public override IQueryable<StringModel> Include()
    {
        return _database;
    }
    
    public async Task<StringModel?> GetByKeyAsync(string key)
    {
        return await Include().SingleOrDefaultAsync(x => x.Key == key);
    }
}