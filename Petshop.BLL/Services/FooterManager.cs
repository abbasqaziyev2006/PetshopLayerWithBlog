using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels;

namespace Petshop.BLL.Services;

public class FooterManager : IFooterService
{
    private readonly ISocialService _socialService;
    private readonly IBioService _bioService;

    public FooterManager(ISocialService socialService, IBioService bioService)
    {
        _socialService = socialService;
        _bioService = bioService;
    }

    public async Task<FooterViewModel> GetFooterViewModel()
    {
        var socials = await _socialService.GetAllAsync(predicate: x => !x.IsDeleted);
        var bio = await _bioService.GetAllAsync();

        var footerViewModel = new FooterViewModel
        {
            Socials = socials.ToList(),
            Bio = bio.FirstOrDefault()
        };

        return footerViewModel;
    }
}
