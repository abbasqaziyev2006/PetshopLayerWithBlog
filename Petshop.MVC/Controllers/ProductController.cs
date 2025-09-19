using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Petshop.BLL.Services.Contracts;
using Petshop.DAL.DataContext.Entities;


namespace PetShop.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IReviewService _reviewService;
        private readonly UserManager<AppUser> _userManager;

        public ProductController(IProductService productService, IReviewService reviewService, UserManager<AppUser> userManager)
        {
            _productService = productService;
            _reviewService = reviewService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Details(string id)
        {
            int productId = int.Parse(id.Split('-').Last());

            var model = await _productService.GetAsync(
                x => x.Id == productId && !x.IsDeleted,
                query => query
                    .Include(x => x.Category!)
                    .Include(x => x.Images)
                    .Include(x => x.ProductTags).ThenInclude(x => x.Tag!)
                    .Include(x => x.Reviews.Where(r => r.ReviewStatus == ReviewStatus.Approve))
                    .ThenInclude(r => r.AppUser!)
            );

            return View(model);
        }
    }
}