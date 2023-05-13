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
[Route("api/reviews")]
[ApiController] [Produces("application/json")]
public class ReviewsController: ControllerBase
{
    private readonly ReviewsRepository _reviewsRepository;
    
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
    public ReviewsController(IMapper mapper, IAuthenticateService authenticateService, ReviewsRepository reviewsRepository, IPasswordHashService passwordHashService)
    {
        _mapper = mapper;
        _authenticateService = authenticateService;
        _reviewsRepository = reviewsRepository;
        _passwordHashService = passwordHashService;
    }

    /// <summary>
    /// Получает список всех отзывов
    /// </summary>
    /// <returns>
    /// Список отзывов
    /// </returns>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>  
    /// <response code="404">Записи не найдены</response>    
    // GET: api/reviews
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<List<ReviewModel>>> GetReviews()
    {
        var models = await _reviewsRepository.GetAllAsync();
        if (models.Count == 0)
            return NotFound();

        var response = _mapper.Map<List<ReviewModel>, List<ReviewWithUserResponse>>(models);
        return Ok(response);
    }
    
    /// <summary>
    /// Получает конкретный отзыв
    /// </summary>
    /// <returns>
    /// Конкретный Отзыв
    /// </returns>
    /// <param name="id">ID Отзыва</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>  
    /// <response code="404">Запись не найдена</response>    
    // GET: api/reviews/{id}
    [HttpGet("{id:long}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<UserResponse>> GetReview(long id)
    {
        var model = await _reviewsRepository.GetByIdAsync(id);
        if (model == null)
            return NotFound();

        var response = _mapper.Map<ReviewModel, ReviewWithUserResponse>(model);
        return Ok(response);
    }

    /// <summary>
    /// Создает нового пользователя
    /// </summary>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>
    /// <response code="400">В запросе допущена ошибка</response>  
    // POST: api/reviews
    [HttpPost, Authorized(false)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> AddReview([FromBody] ReviewRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }
        
        var user = await _authenticateService.GetUser(User);
        if (user == null)
        {
            return Problem(
                title: "Ошибка Авторизации",
                detail: "Вы не авторизованы!",
                statusCode: StatusCodes.Status401Unauthorized);
        }

        var checkReview = await _reviewsRepository.GetByUserIdAsync(user.Id);
        if (checkReview != null)
        {
            return Problem(
                title: "Ошибка",
                detail: "Вы уже отправляли отзыв!",
                statusCode: StatusCodes.Status403Forbidden);
        }
        
        var model = _mapper.Map<ReviewRequest, ReviewModel>(request);
        model.User = user;

        await _reviewsRepository.AddAsync(model);
        await _reviewsRepository.CommitAsync();

        return Ok();
    }

    /// <summary>
    /// Изменяет конкретный отзыв
    /// </summary>
    /// <param name="request">Форма запроса</param>
    /// <param name="id">ID Отзыва</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>  
    /// <response code="404">Запись не найдена</response>
    /// <response code="400">В запросе допущена ошибка</response>  
    // PATCH: api/reviews/{id}
    [HttpPatch("{id:long}"), Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UpdateReview([FromBody] ReviewRequest request, long id)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState.GetErrorMessages());
        }
        
        var model = await _reviewsRepository.GetByIdAsync(id);
        if (model == null)
            return NotFound();
        
        var updateModel = _mapper.Map<ReviewRequest, ReviewModel>(request);

        _reviewsRepository.Update(model, updateModel);
        await _reviewsRepository.CommitAsync();

        return Ok();
    }
    
    /// <summary>
    /// Удаляет конкретный отзыв
    /// </summary>
    /// <param name="id">ID Отзыва</param>
    /// <response code="200">Операция успешно выполнена</response>
    /// <response code="403">У вас недостаточно прав</response>  
    /// <response code="404">Запись не найдена</response>     
    // DELETE: api/reviews/{id}
    [HttpDelete("{id:long}"), Authorized(true)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Produces("application/json")]
    public async Task<ActionResult> DeleteReview(long id)
    {
        var model = await _reviewsRepository.GetByIdAsync(id);
        if (model == null)
            return NotFound();

        _reviewsRepository.Remove(model);
        await _reviewsRepository.CommitAsync();

        return Ok();
    }
}