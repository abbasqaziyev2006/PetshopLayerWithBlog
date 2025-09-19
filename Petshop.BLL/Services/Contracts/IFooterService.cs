using Petshop.BLL.ViewModels;

namespace Petshop.BLL.Services.Contracts;

public interface IFooterService
{
    Task<FooterViewModel> GetFooterViewModel();
}
