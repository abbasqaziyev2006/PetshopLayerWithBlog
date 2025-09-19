using AutoMapper;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels;
using Petshop.DAL.DataContext.Entities;
using Petshop.DAL.Repositories.Contracts;

namespace Petshop.BLL.Services;

public class SocialManager :
    CrudManager<Social, SocialViewModel, SocialCreateViewModel, SocialUpdateViewModel>,
    ISocialService
{
    public SocialManager(IRepository<Social> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}


