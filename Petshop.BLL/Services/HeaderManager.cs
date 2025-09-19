using Petshop.BLL.Services.Contracts;
using Petshop.BLL.ViewModels;

namespace Petshop.BLL.Services;

public class HeaderManager : IHeaderService
{
    private readonly IBioService _bioService;

    public HeaderManager(IBioService bioService)
    {
        _bioService = bioService;
    }

    public async Task<HeaderViewModel> GetHeaderViewModel()
    {
        var bio = await _bioService.GetAllAsync();

        var headerViewModel = new HeaderViewModel
        {
            Bio = bio.FirstOrDefault()
        };

        return headerViewModel;
    }
}
