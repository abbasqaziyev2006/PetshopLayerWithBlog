using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;
using PetShop.BusinessLogic.ViewModels;
using System.Linq.Expressions;

namespace Petshop.BLL.Services
{
    public class ProductManager
           : CrudManager<Product, ProductViewModel, ProductCreateViewModel, ProductUpdateViewModel>,
             IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductManager(IProductRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Product?> GetAsync(int id)
        {
            return await _repository.GetAsync(p => p.Id == id && !p.IsDeleted);
        }

        public async Task<Product?> GetAsync(
            Expression<Func<Product, bool>> predicate,
            Func<IQueryable<Product>, IIncludableQueryable<Product, object>>? include = null
        )
        {
            return await _repository.GetAsync(predicate, include);
        }
    }
}