using Microsoft.EntityFrameworkCore.Query;
using Petshop.BLL.ViewModels;
using Petshop.DAL.DataContext.Entities;
using PetShop.BusinessLogic.ViewModels;
using System.Linq.Expressions;

namespace Petshop.BLL.Services.Contracts;

public interface IProductService : ICrudService<Product, ProductViewModel, ProductCreateViewModel, ProductUpdateViewModel>
{
    Task<Product?> GetAsync(int id);

    Task<Product?> GetAsync(
        Expression<Func<Product, bool>> predicate,
        Func<IQueryable<Product>, IIncludableQueryable<Product, object>>? include = null
    );

}
