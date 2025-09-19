using Petshop.DAL.DataContext.Entities;
using PetShop.BusinessLogic.ViewModels;

namespace Petshop.BLL.ViewModels;

public class HomeViewModel
{
    public List<CategoryViewModel> Categories { get; set; } = [];
    public List<ProductViewModel> Products { get; set; } = [];
    public List<ProductViewModel> PetClothingProducts { get; set; } = [];
    public List<ProductViewModel> PetFoodProducts { get; set; } = [];
    public List<ProductViewModel> ProductImages { get; set; } = [];
   
}

