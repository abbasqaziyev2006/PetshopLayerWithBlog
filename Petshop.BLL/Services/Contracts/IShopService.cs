using Petshop.BLL.ViewModels;

namespace Petshop.BLL.Services.Contracts;

public interface IShopService
{
    Task<ShopViewModel> GetShopViewModelAsync();
}
