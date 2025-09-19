using Petshop.BLL.ViewModels;
using Petshop.DAL.DataContext.Entities;
using System.Reflection.PortableExecutable;

namespace Petshop.BLL.Services.Contracts;

public interface ICategoryService : ICrudService<Category, CategoryViewModel, CreateCategoryViewModel, UpdateCategoryViewModel>
{
}

