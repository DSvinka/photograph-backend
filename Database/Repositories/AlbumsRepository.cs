using Database.Abstractions;
using Domain.Models;
using Domain.Models.Albums;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories;

public class AlbumsRepository: BaseRepositoryWithId<AlbumModel, AppDbContext>
{
    private readonly FilesRepository _filesRepository;
    
    public AlbumsRepository(AppDbContext context, FilesRepository filesRepository) : base(context, context.Albums)
    {
        _filesRepository = filesRepository;
    }
    
    public override IQueryable<AlbumModel> Include()
    {
        return _database
            .Include(model => model.CoverFile)
            .Include(model => model.Files)
            .ThenInclude(model => model.File);
    }

    public async Task AddFileAsync(AlbumModel model, FileModel fileModel)
    {
        await _context.AlbumFiles.AddAsync(new AlbumFileRelation()
        {
            Album = model,
            File = fileModel
        });
    }

    public void RemoveFile(AlbumFileRelation albumFileRelation)
    {
        _context.AlbumFiles.Remove(albumFileRelation);
        _filesRepository.Remove(albumFileRelation.File);
    }

    public override void Remove(AlbumModel model)
    {
        base.Remove(model);
        foreach (var relation in model.Files)
        {
            _context.AlbumFiles.Remove(relation);
            _filesRepository.Remove(relation.File);
        }
        
        _filesRepository.Remove(model.CoverFile);
    }
}