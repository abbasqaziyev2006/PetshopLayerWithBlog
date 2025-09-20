﻿using Microsoft.Extensions.DependencyInjection;
using Petshop.BLL.Services;
using Petshop.BLL.Services.Contracts;
using PetShop.BusinessLogic.Mapping;

namespace Petshop.BLL;

public static class BussinessLogicLayerServiceRegistration
{
    public static IServiceCollection AddBussinessLogicLayerServices(this IServiceCollection services)
    {
        services.AddAutoMapper(confg => confg.AddProfile<MappingProfile>());
        services.AddScoped(typeof(ICrudService<,,,>), typeof(CrudManager<,,,>));
        services.AddScoped<IHeaderService, HeaderManager>();
        services.AddScoped<IFooterService, FooterManager>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<IHomeService, HomeManager>();
        services.AddScoped<IShopService, ShopManager>();
        services.AddScoped<IReviewService, ReviewManager>();
        services.AddScoped<IBlogService, BlogManager>();
        services.AddScoped<IBioService, BioManager>();
        services.AddScoped<ISocialService, SocialManager>();
        services.AddScoped<FileService>();
        services.AddScoped<WishlistManager>();
        services.AddScoped<BasketManager>();

        return services;
    }
}
