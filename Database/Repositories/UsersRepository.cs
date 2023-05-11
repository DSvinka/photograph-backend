using Database.Abstractions;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories;

public class UsersRepository: BaseRepositoryWithId<UserModel, AppDbContext>
{
    public UsersRepository(AppDbContext context) : base(context, context.Users)
    {
    }
    
    public override IQueryable<UserModel> Include()
    {
        return _database;
    }
    
    public async Task<UserModel?> GetByUsernameAsync(string username)
    {
        return await Include().SingleOrDefaultAsync(model => model.Username.Equals(username));
    }

    public async Task<UserModel?> GetByRefreshTokenAsync(string refreshToken)
    {
        return await Include().SingleOrDefaultAsync(model => model.RefreshToken.Equals(refreshToken));
    }
}