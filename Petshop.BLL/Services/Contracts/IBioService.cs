using Petshop.BLL.ViewModels;
using Petshop.DAL.DataContext.Entities;

namespace Petshop.BLL.Services.Contracts;

public interface IBioService : ICrudService<Bio, BioViewModel, BioCreateViewModel, BioUpdateViewModel>
{
}