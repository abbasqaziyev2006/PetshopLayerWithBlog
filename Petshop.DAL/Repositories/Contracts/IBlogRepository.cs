using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

public interface IBlogRepository : IRepository<Blog>
{
    Task<List<Blog>> GetLatestAsync(int count);
}