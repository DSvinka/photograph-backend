using App.Extensions;
using App.Extensions.Attributes;
using AutoMapper;
using Database.Repositories;
using Domain.Abstractions.Services.Auth;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

/// <summary>
/// Контроллер который отвечает за текстовые поля сайта
/// </summary>
[Route("api/strings")]
[ApiController] [Produces("application/json")]
public class StringsController: ControllerBase
{
    private readonly StringsRepository _stringsRepository;
    
    private readonly IAuthenticateService _authenticateService;
    private readonly IMapper _mapper;

    /// <summary>
    /// StringsController
    /// </summary>
    /// <param name="stringsRepository"></param>
    /// <param name="mapper"></param>
    /// <param name="authenticateService"></param>
    public StringsController(StringsRepository stringsRepository, IMapper mapper, IAuthenticateService authenticateService)
    {
        _stringsRepository = stringsRepository;
        _mapper = mapper;
        _authenticateService = authenticateService;
    }

    /// <summary>
    /// Получает все строки
    /// </summary>
    /// <returns>
    /// Словарь из строк
    /// </returns>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="404">Строки не найдены</response>
    // GET: api/strings
    [HttpGet, AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)] 
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<StringsResponse>> GetStrings()
    {
        var models = await _stringsRepository.GetAllAsync();
        if (models.Count == 0)
        {
            return NotFound();
        }
        
        var response = new StringsResponse();
        response.Strings = new Dictionary<string, string>();

        foreach (var model in models)
        {
            response.Strings.Add(model.Key, model.Value);
        }
        
        return Ok(response);
    }
    
    /// <summary>
    /// Получает определенную строку по ключу
    /// </summary>
    /// <returns>
    /// Определенная строка
    /// </returns>
    /// <param name="key">Ключ строки</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="404">Строка не найдена</response>
    // GET: api/strings/{key}
    [HttpGet("{key}"), AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)] 
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<StringResponse>> GetString(string key)
    {
        var model = await _stringsRepository.GetByKeyAsync(key);
        if (model == null)
        {
            return NotFound();
        }

        var response = _mapper.Map<StringModel, StringResponse>(model);
        return Ok(response);
    }

    /// <summary>
    /// Изменяет строку
    /// </summary>
    /// <param name="key">Ключ строки</param>
    /// <param name="request">Форма запроса</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>
    /// <response code="400">В запросе допущена ошибка</response>
    // PATCH: api/settings/{key}
    [HttpPatch("{key}"), Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateString(string key, [FromBody] StringRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }
        
        var updateModel = _mapper.Map<StringRequest, StringModel>(request);
        updateModel.Key = key;
        
        var model = await _stringsRepository.GetByKeyAsync(key);
        if (model == null)
        {
            await _stringsRepository.AddAsync(updateModel);
        }
        else
        {
            _stringsRepository.Update(model, updateModel);
        }
        
        await _stringsRepository.CommitAsync();
        return Ok();
    }
    
    /// <summary>
    /// Удаляет определенную строку по ключу
    /// </summary>
    /// <param name="key">Ключ строки</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>
    /// <response code="404">Строка не найдена</response>
    // GET: api/strings/{key}
    [HttpDelete("{key}"), AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)] 
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteString(string key)
    {
        var model = await _stringsRepository.GetByKeyAsync(key);
        if (model == null)
        {
            return NotFound();
        }

        _stringsRepository.Remove(model);
        await _stringsRepository.CommitAsync();
        return Ok();
    }
}