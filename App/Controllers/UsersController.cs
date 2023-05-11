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
/// Контроллер который отвечает за пользователей
/// </summary>
[Route("api/users")]
[ApiController] [Produces("application/json")]
public class UsersController: ControllerBase
{
    private readonly UsersRepository _usersRepository;
    
    private readonly IPasswordHashService _passwordHashService;
    private readonly IAuthenticateService _authenticateService;
    private readonly IMapper _mapper;

    /// <summary>
    /// UsersController
    /// </summary>
    /// <param name="mapper"></param>
    /// <param name="authenticateService"></param>
    /// <param name="usersRepository"></param>
    /// <param name="passwordHashService"></param>
    public UsersController(IMapper mapper, IAuthenticateService authenticateService, UsersRepository usersRepository, IPasswordHashService passwordHashService)
    {
        _mapper = mapper;
        _authenticateService = authenticateService;
        _usersRepository = usersRepository;
        _passwordHashService = passwordHashService;
    }

    /// <summary>
    /// Получает список всех пользователей
    /// </summary>
    /// <returns>
    /// Список пользователей
    /// </returns>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>  
    /// <response code="404">Записи не найдены</response>    
    // GET: api/users
    [HttpGet, Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<UserModel>>> GetUsers()
    {
        var models = await _usersRepository.GetAllAsync();
        if (models.Count == 0)
            return NotFound();

        var response = _mapper.Map<List<UserModel>, List<UserResponse>>(models);
        return Ok(response);
    }
    
    /// <summary>
    /// Получает конкретного пользователя
    /// </summary>
    /// <returns>
    /// Конкретный пользователь
    /// </returns>
    /// <param name="id">ID Пользователя</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>  
    /// <response code="404">Запись не найдена</response>    
    // GET: api/users/{id}
    [HttpGet("{id:long}"), Authorized(false)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserResponse>> GetUser(long id)
    {
        var model = await _usersRepository.GetByIdAsync(id);
        if (model == null)
            return NotFound();

        var response = _mapper.Map<UserModel, UserResponse>(model);
        return Ok(response);
    }

    /// <summary>
    /// Создает нового пользователя
    /// </summary>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>
    /// <response code="400">В запросе допущена ошибка</response>  
    // POST: api/users
    [HttpPost, Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> AddUser([FromBody] UserRequest request)
    {
        if (!ModelState.IsValid || request.Password is null)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }
        
        var model = _mapper.Map<UserRequest, UserModel>(request);
        model.PasswordHash = _passwordHashService.PasswordHash(request.Password);

        await _usersRepository.AddAsync(model);
        await _usersRepository.CommitAsync();

        return Ok();
    }

    /// <summary>
    /// Изменяет конкретного пользователя
    /// </summary>
    /// <param name="request">Форма запроса</param>
    /// <param name="id">ID Пользователя</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>  
    /// <response code="404">Запись не найдена</response>
    /// <response code="400">В запросе допущена ошибка</response>  
    // PATCH: api/users/{id}
    [HttpPatch("{id:long}"), Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UpdateUser([FromBody] UserRequest request, long id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }
        
        var model = await _usersRepository.GetByIdAsync(id);
        if (model == null)
            return NotFound();
        
        var updateModel = _mapper.Map<UserRequest, UserModel>(request);

        if (request.Password != null)
        {
            updateModel.PasswordHash = _passwordHashService.PasswordHash(request.Password);
        }
        else
        {
            updateModel.PasswordHash = model.PasswordHash;
        }
        
        _usersRepository.Update(model, updateModel);
        await _usersRepository.CommitAsync();

        return Ok();
    }
    
    /// <summary>
    /// Удаляет конкретного пользователя
    /// </summary>
    /// <param name="id">ID Пользователя</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>  
    /// <response code="404">Запись не найдена</response>     
    // DELETE: api/users/{id}
    [HttpDelete("{id:long}"), Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Produces("application/json")]
    public async Task<ActionResult> DeleteUser(long id)
    {
        var model = await _usersRepository.GetByIdAsync(id);
        if (model == null)
            return NotFound();

        _usersRepository.Remove(model);
        await _usersRepository.CommitAsync();

        return Ok();
    }
}