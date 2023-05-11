using App.Extensions;
using App.Extensions.Attributes;
using App.Utils;
using AutoMapper;
using Database.Repositories;
using Domain.Abstractions.Services.Auth;
using Domain.Models;
using Domain.Models.Albums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

/// <summary>
/// Контроллер который отвечает за фотоальбомы
/// </summary>
[Route("api/albums")]
[ApiController] [Produces("application/json")]
public class AlbumsController: ControllerBase
{
    private readonly AlbumsRepository _albumsRepository;
    private readonly SettingsRepository _settingsRepository;
    private readonly FilesRepository _filesRepository;
    
    private readonly IPasswordHashService _passwordHashService;
    private readonly IMapper _mapper;

    /// <summary>
    /// AlbumsController
    /// </summary>
    /// <param name="mapper"></param>
    /// <param name="albumsRepository"></param>
    /// <param name="passwordHashService"></param>
    /// <param name="settingsRepository"></param>
    /// <param name="filesRepository"></param>
    public AlbumsController(IMapper mapper, AlbumsRepository albumsRepository, IPasswordHashService passwordHashService, SettingsRepository settingsRepository, FilesRepository filesRepository)
    {
        _mapper = mapper;
        _albumsRepository = albumsRepository;
        _passwordHashService = passwordHashService;
        _settingsRepository = settingsRepository;
        _filesRepository = filesRepository;
    }

    /// <summary>
    /// Получает список всех доступных фотоальбомов.
    /// </summary>
    /// <returns>Список фотоальбомов.</returns>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>   
    /// <response code="404">Записи не найдены</response>   
    // GET: api/albums
    [HttpGet, AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<AlbumResponse>>> GetAlbums()
    {
        var settingsModel = await _settingsRepository.GetAsync();
        
        var models = await _albumsRepository.GetAllAsync();
        if (models.Count == 0)
            return NotFound();

        var responses = _mapper.Map<List<AlbumModel>, List<AlbumResponse>>(models);
        for (var i = 0; i < models.Count; i++)
        {
            var model = models[i];
            var response = responses[i];
            
            response.CoverFile = new FileResponse()
            {
                Id = model.CoverFileId,
                Url = model.CoverFile.GetFileUrl(settingsModel),
                Filename = model.CoverFile.Filename,
                Width = model.CoverFile.Width,
                Height = model.CoverFile.Height
            };
            
            response.Files = new List<FileResponse>();
            foreach (var relation in models[i].Files)
            {
                response.Files.Add(new FileResponse()
                {
                    Id = relation.Id,
                    Url = relation.File.GetFileUrl(settingsModel),
                    Filename = relation.File.Filename,
                    Width = relation.File.Width,
                    Height = relation.File.Height
                });
            }
        }
        
        return Ok(responses);
    }
    
    /// <summary>
    /// Получает конкретный фотоальбом с помощью ID.
    /// </summary>
    /// <returns>Фотоальбом</returns>
    /// <param name="id">ID Фотоальбома</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>   
    /// <response code="404">Запись не найдена</response>  
    // GET: api/albums/{id}
    [HttpGet("{id:long}"), AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<AlbumResponse>> GetAlbum(long id)
    {
        var settingsModel = await _settingsRepository.GetAsync();
        var model = await _albumsRepository.GetByIdAsync(id);
        if (model == null)
            return NotFound();

        var response = _mapper.Map<AlbumModel, AlbumResponse>(model);
        response.CoverFile = new FileResponse()
        {
            Id = model.CoverFile.Id,
            Url = model.CoverFile.GetFileUrl(settingsModel),
            Filename = model.CoverFile.Filename,
            Width = model.CoverFile.Width,
            Height = model.CoverFile.Height
        };
        
        response.Files = new List<FileResponse>();
        foreach (var relation in model.Files)
        {
            response.Files.Add(new FileResponse()
            {
                Id = relation.Id,
                Url = relation.File.GetFileUrl(settingsModel),
                Filename = relation.File.Filename,
                Width = relation.File.Width,
                Height = relation.File.Height
            });
        }
        
        return Ok(response);
    }

    /// <summary>
    /// Изменяет конкретный фотоальбом.
    /// </summary>
    /// <param name="request">Форма запроса</param>
    /// <param name="id">ID Фотоальбома</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>   
    /// <response code="404">Запись не найдена</response>
    /// <response code="400">В запросе допущена ошибка</response>  
    // PATCH: api/albums/{id}
    [HttpPatch("{id:long}"), Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UpdateAlbum([FromBody] AlbumRequest request, long id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }
        
        var model = await _albumsRepository.GetByIdAsync(id);
        if (model == null)
            return NotFound();
        
        var updateModel = _mapper.Map<AlbumRequest, AlbumModel>(request);
        updateModel.CoverFile = model.CoverFile;

        if (request.CoverFileBytes != null)
        {
            _filesRepository.Remove(model.CoverFile);

            var fileType = FilesUtils.GetFileType(request.CoverFileType);
            if (fileType == null)
            {
                return Problem(title: "Ошибка загрузки файла", detail: "Данный тип файла не поддерживается!",
                    statusCode: StatusCodes.Status400BadRequest);
            }

            var coverFileModel = new FileModel()
            {
                FileBytes = request.CoverFileBytes,
                Filename = FilesUtils.GetFileName(request.CoverFileName, fileType.Value),
                FileType = fileType.Value,
                Width = request.CoverFileWidth.Value,
                Height = request.CoverFileHeight.Value
            };

            updateModel.CoverFile = coverFileModel;

            await _filesRepository.AddAsync(coverFileModel);
        }
        
        _albumsRepository.Update(model, updateModel);
        await _albumsRepository.CommitAsync();

        return Ok();
    }
    
    /// <summary>
    /// Создаёт новый фотоальбом.
    /// </summary>
    /// /// <param name="request">Форма запроса</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>   
    /// <response code="400">В запросе допущена ошибка</response>
    // POST: api/albums/
    [HttpPost, Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> AddAlbum([FromBody] AlbumRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }

        if (request.CoverFileBytes == null)
        {
            return Problem(title: "CoverFileBytes is Null!", detail: "Проверьте правильность введенных данных.", statusCode: StatusCodes.Status400BadRequest);
        }

        var fileType = FilesUtils.GetFileType(request.CoverFileType);
        if (fileType == null)
        {
            return Problem(title: "Ошибка загрузки файла", detail: "Данный тип файла не поддерживается!", statusCode: StatusCodes.Status400BadRequest);
        }

        var coverFileModel = new FileModel()
        {
            FileBytes = request.CoverFileBytes,
            Filename = FilesUtils.GetFileName(request.CoverFileName, fileType.Value),
            FileType = fileType.Value,
            Width = request.CoverFileWidth.Value,
            Height = request.CoverFileHeight.Value
        };
        
        var model = _mapper.Map<AlbumRequest, AlbumModel>(request);
        model.CoverFile = coverFileModel;

        await _filesRepository.AddAsync(coverFileModel);
        await _albumsRepository.AddAsync(model);
        
        await _filesRepository.CommitAsync();
        await _albumsRepository.CommitAsync();

        return Ok();
    }

    /// <summary>
    /// Загружает фотографии в конкретный фотоальбом.
    /// </summary>
    /// <param name="file">Форма запроса</param>
    /// <param name="id">ID Фотоальбома</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>   
    /// <response code="400">В запросе допущена ошибка ИЛИ загруженный тип файла не поддерживается</response>
    /// <response code="404">Запись не найдена</response>
    // POST: api/albums/{id}/files
    [HttpPost("{id:long}/files"), Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UploadAlbumFile([FromBody] FileRequest file, long id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }
        
        var model = await _albumsRepository.GetByIdAsync(id);
        if (model == null)
            return NotFound();

        var fileType = FilesUtils.GetFileType(file.FileType);
        if (fileType == null)
        {
            return Problem(title: "Данный тип файла не поддерживается!", statusCode: StatusCodes.Status400BadRequest);
        }

        var fileModel = new FileModel()
        {
            FileBytes = file.FileBytes,
            Filename = FilesUtils.GetFileName(file.FileName, fileType.Value),
            FileType = fileType.Value,
            Width = file.Width,
            Height = file.Height
        };

        await _filesRepository.AddAsync(fileModel);
        await _albumsRepository.AddFileAsync(model, fileModel);
        
        await _filesRepository.CommitAsync();
        await _albumsRepository.CommitAsync();

        return Ok();
    }

    /// <summary>
    /// Удаляет конкретную фотографию из конкретного фотоальбома.
    /// </summary>
    /// <param name="albumId">ID Фотоальбома</param>
    /// <param name="fileId">ID Файла</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>
    /// <response code="404">Запись не найдена</response>
    // DELETE: api/albums/{albumId}/files/{fileId}
    [HttpDelete("{albumId:long}/files/{fileId:long}"), Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> DeleteAlbumFile(long albumId, long fileId)
    {
        var model = await _albumsRepository.GetByIdAsync(albumId);
        if (model == null)
            return NotFound();
        
        var file = model.Files.FirstOrDefault(x => x.Id == fileId);
        if (file == null)
            return NotFound();

        _albumsRepository.RemoveFile(file);
        await _albumsRepository.CommitAsync();

        return Ok();
    }
    
    /// <summary>
    /// Удаляет конкретный фотоальбом.
    /// </summary>
    /// <param name="id">ID Фотоальбома</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>
    /// <response code="404">Запись не найдена</response>
    // DELETE: api/albums/{id}
    [HttpDelete("{id:long}"), Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> DeleteAlbum(long id)
    {
        var model = await _albumsRepository.GetByIdAsync(id);
        if (model == null)
            return NotFound();
        
        _albumsRepository.Remove(model);
        await _albumsRepository.CommitAsync();

        return Ok();
    }
}