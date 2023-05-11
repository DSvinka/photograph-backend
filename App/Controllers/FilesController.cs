using App.Extensions;
using Database.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

/// <summary>
/// Контроллер отвечающий за работу с файлами
/// </summary>
[Route("api/files")]
[ApiController]
public class FilesController: ControllerBase
{
    private readonly FilesRepository _filesRepository;

    /// <summary>
    /// FilesController
    /// </summary>
    /// <param name="filesRepository"></param>
    public FilesController(FilesRepository filesRepository)
    {
        _filesRepository = filesRepository;
    }

    /// <summary>
    /// Получает файл из базы данных
    /// </summary>
    /// <returns>
    /// Байты файла
    /// </returns>
    /// <param name="fileName">Имя файла</param>
    /// <param name="fileType">Тип файла</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="404">Запись не найдена</response>    
    // POST: api/files/{fileName}.{fileType}
    [HttpGet("{fileName}.{fileType}"), AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetFile(string fileName, string fileType)
    {
        var fileModel = await _filesRepository.GetByNameAndType(fileName, fileType);
        if (fileModel == null)
        {
            return NotFound();
        }
        
        var contentTypeStart = "audio";
        
        switch (fileType.ToLower())
        {
            case "mp3":
            case "wav":
                contentTypeStart = "audio";
                break;
             
            case "jpeg":
            case "jpg":
            case "png":
            case "gif":
                contentTypeStart = "image";
                break;
        }
        
        return File(fileModel.FileBytes, $"{contentTypeStart}/{fileModel.FileType.GetDisplayName()}");
    }
}