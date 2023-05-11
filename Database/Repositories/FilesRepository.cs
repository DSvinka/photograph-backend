using Database.Abstractions;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories;

public class FilesRepository: BaseRepositoryWithId<FileModel, AppDbContext>
{
    public FilesRepository(AppDbContext context) : base(context, context.Files)
    {

    }
    
    public override IQueryable<FileModel> Include()
    {
        return _database;
    }

    public async Task<FileModel?> GetByNameAndType(string fileName, string fileType)
    {
        return await Include().SingleOrDefaultAsync(x => x.Filename.Equals($"{fileName}.{fileType}"));
    }
}