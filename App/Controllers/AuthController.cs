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
/// Контроллер который отвечает за авторизацию
/// </summary>
[ApiController]
[Route("api/auth")] [Produces("application/json")]
public class AuthController : ControllerBase
{
    private readonly UsersRepository _usersRepository;
    
    private readonly IAuthenticateService _authenticateService;
    private readonly IPasswordHashService _passwordHash;
    
    private readonly IMapper _mapper;

    /// <summary>
    /// AuthController
    /// </summary>
    /// <param name="usersRepository"></param>
    /// <param name="authenticateService"></param>
    /// <param name="passwordHash"></param>
    /// <param name="mapper"></param>
    public AuthController(UsersRepository usersRepository, IAuthenticateService authenticateService, IPasswordHashService passwordHash, IMapper mapper)
    {
        _passwordHash = passwordHash;
        _usersRepository = usersRepository;
        _authenticateService = authenticateService;
        _mapper = mapper;
    }

    /// <summary>
    /// Авторизирует пользователя, выдавая токены авторизации
    /// </summary>
    /// <returns>
    /// Данные пользователя, токены авторизации
    /// </returns>
    /// <param name="login">Форма запроса</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="400">В запросе допущена ошибка</response>   
    /// <response code="401">Не удалось авторизоваться</response>   
    // POST: api/auth/login
    [HttpPost("login"), AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginRequest login)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }
        
        var personalModel = await _usersRepository.GetByUsernameAsync(login.Username);
        if (personalModel == null)
        {
            return Unauthorized();
        }

        if (!_passwordHash.VerifyPasswordHash(personalModel.PasswordHash, login.Password))
        {
            return Unauthorized();
        }

        var tokenModel = await _authenticateService.LoginUser(personalModel);
        await _usersRepository.CommitAsync();

        return Ok(new LoginResponse()
        {
            Id = personalModel.Id,
            Username = personalModel.Username,
            Administrator = personalModel.Administrator,

            AccessToken = tokenModel.AccessToken,
            RefreshToken = tokenModel.RefreshToken,
        });
    }

    /// <summary>
    /// Получает новый токен авторизации
    /// </summary>
    /// <returns>
    /// Новые токены авторизации
    /// </returns>
    /// <param name="refreshToken">Форма запроса</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="400">В запросе допущена ошибка</response>   
    /// <response code="404">Запись не найдена</response>   
    // POST: api/auth/refresh
    [HttpPost("refresh"), AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<RefreshTokenResponse>> Refresh([FromBody] RefreshTokenRequest refreshToken)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }

        var personalModel = await _usersRepository.GetByRefreshTokenAsync(refreshToken.RefreshToken);
        if (personalModel == null)
        {
            return Problem(
                title: "Ошибка Авторизации",
                detail: "Токен не валидный!", 
                statusCode: StatusCodes.Status404NotFound);
        }
        
        var tokenModel = await _authenticateService.LoginUser(personalModel);
        await _usersRepository.CommitAsync();
        
        return Ok(new RefreshTokenResponse() {RefreshToken=tokenModel.RefreshToken, AccessToken=tokenModel.AccessToken});
    }

    /// <summary>
    /// Получает информацию о текущем пользователе
    /// </summary>
    /// <returns>
    /// Информация о текущем пользователе
    /// </returns>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="401">Вы не авторизованы</response>    
    // POST: api/auth/me
    [HttpGet("me"), Authorized]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<ActionResult<UserResponse>> Me()
    {
        var personalModel = await _authenticateService.GetUser(User);
        if (personalModel == null)
        {
            return Problem(
                title: "Ошибка Авторизации",
                detail: "Вы не авторизованы!",
                statusCode: StatusCodes.Status401Unauthorized);
        }

        var userResponse = _mapper.Map<UserModel, UserResponse>(personalModel);
        return Ok(userResponse);
    }
}