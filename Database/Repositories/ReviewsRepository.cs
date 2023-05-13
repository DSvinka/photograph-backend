using Database.Abstractions;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories;

public class ReviewsRepository: BaseRepositoryWithId<ReviewModel, AppDbContext>
{
    public ReviewsRepository(AppDbContext context) : base(context, context.Reviews)
    {
    }
    
    public override IQueryable<ReviewModel> Include()
    {
        return _database
            .Include(model => model.User);
    }
    
    public async Task<ReviewModel?> GetByUserIdAsync(long id)
    {
        return await Include().SingleOrDefaultAsync(model => model.User.Id == id);
    }
}