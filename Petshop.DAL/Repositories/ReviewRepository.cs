using Petshop.DAL.DataContext;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.DAL.Repositories;

public class ReviewRepository : EfCoreRepository<Review>, IReviewRepository
{
    public ReviewRepository(AppDbContext context) : base(context)
    {
    }
}