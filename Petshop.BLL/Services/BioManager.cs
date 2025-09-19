using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

namespace Petshop.BLL.Services;

public class BioManager :
    CrudManager<Bio, BioViewModel, BioCreateViewModel, BioUpdateViewModel>,
    IBioService
{
    public BioManager(IRepository<Bio> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}