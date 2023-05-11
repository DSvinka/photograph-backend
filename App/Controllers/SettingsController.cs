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
/// Контроллер который отвечает за настройку сайта
/// </summary>
[Route("api/settings")]
[ApiController] [Produces("application/json")]
public class SettingsController: ControllerBase
{
    private readonly SettingsRepository _settingsRepository;
    private readonly UsersRepository _usersRepository;
    
    private readonly IAuthenticateService _authenticateService;
    private readonly IMapper _mapper;

    /// <summary>
    /// SettingsController
    /// </summary>
    /// <param name="settingsRepository"></param>
    /// <param name="mapper"></param>
    /// <param name="authenticateService"></param>
    /// <param name="usersRepository"></param>
    public SettingsController(SettingsRepository settingsRepository, IMapper mapper, IAuthenticateService authenticateService, UsersRepository usersRepository)
    {
        _settingsRepository = settingsRepository;
        _mapper = mapper;
        _authenticateService = authenticateService;
        _usersRepository = usersRepository;
    }

    /// <summary>
    /// Получает настройки сайта
    /// </summary>
    /// <returns>
    /// Если авторизован - Полные настройки сайта. Иначе - Только настройки информации о сайте
    /// </returns>
    /// <response code="200">Операция успешно выполнена</response>
    // GET: api/settings
    [HttpGet, AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetSettings()
    {
        var model = await _settingsRepository.GetAsync();
        
        var userModel = await _authenticateService.GetUser(User);
        if (userModel == null || !userModel.Administrator)
        {
            var userResponse = _mapper.Map<SettingsModel, SettingsResponse>(model);
            return Ok(userResponse);
        }

        var adminResponse = _mapper.Map<SettingsModel, SettingsAdminResponse>(model);
        return Ok(adminResponse);
    }

    /// <summary>
    /// Изменение настроек сайта
    /// </summary>
    /// <param name="request">Форма запроса</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>
    /// <response code="400">В запросе допущена ошибка</response>  
    // PATCH: api/settings
    [HttpPatch, Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateSettings([FromBody] SettingsRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }
        
        var model = await _settingsRepository.GetAsync();
        var updateModel = _mapper.Map<SettingsRequest, SettingsModel>(request);
        
        _settingsRepository.Update(model, updateModel);
        await _settingsRepository.CommitAsync();
        
        return Ok();
    }
}