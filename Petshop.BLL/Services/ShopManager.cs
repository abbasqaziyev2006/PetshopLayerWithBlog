﻿using Microsoft.EntityFrameworkCore;
using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels;

namespace Petshop.BLL.Services;

public class ShopManager : IShopService
{
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;


    public ShopManager(IProductService productService, ICategoryService categoryService)
    {
        _productService = productService;
        _categoryService = categoryService;
    }

    public async Task<ShopViewModel> GetShopViewModelAsync()
    {
        var products = await _productService.GetAllAsync(include: q => q.Include(p => p.Category!));

        var categories = await _categoryService.GetAllAsync();

        var shopViewModel = new ShopViewModel
        {
            Products = products.ToList(),
            Categories = categories.ToList(),
        };

        return shopViewModel;
    }
}