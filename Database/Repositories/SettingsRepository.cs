using Database.Abstractions;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories;

public class SettingsRepository: BaseRepository<SettingsModel, AppDbContext>
{
    public SettingsRepository(AppDbContext context) : base(context, context.Settings)
    {
    }
    
    public override IQueryable<SettingsModel> Include()
    {
        return _database;
    }
    
    public async Task<SettingsModel> GetAsync()
    {
        var model = await Include().SingleOrDefaultAsync();
        if (model == null)
        {
            model = new SettingsModel()
            {
                FrontendUrl = "http://localhost:8080",
                BackendUrl = "http://localhost:5290"
            };

            await AddAsync(model);
            await CommitAsync();
            await _context.Entry(model).ReloadAsync();
        }

        return model;
    }
}