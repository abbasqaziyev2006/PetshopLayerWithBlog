using PetShop.BusinessLogic.ViewModels;

namespace Petshop.BLL.ViewModels;

public class ShopViewModel
{
    public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
    public List<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
}