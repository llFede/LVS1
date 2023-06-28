using CommunityToolkit.Mvvm.Input;
using LVS1.wpf.Managers;
using LVS1.wpf.Navigation;

namespace LVS1.wpf.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    private readonly UserManager _userManager;
    private readonly NavigationServiceFactory _navigationFactory;

    public LoginViewModel(UserManager userManager, NavigationServiceFactory navigationFactory)
    {
        _userManager = userManager;
        _navigationFactory = navigationFactory;
    }
    [RelayCommand]
    public void NavigateToRegister()
    {
        _navigationFactory.GetNavigationService<RegisterViewModel>().Navigate();
    }

    public string Email { get; set; }
    public string Password { get; set; }
    [RelayCommand]
    public async Task Login()
    {
        var authResult = await _userManager.Authorize(Email, Password);
        if (authResult.IsAuthorized)
        {
            _navigationFactory.GetNavigationService<FloorListViewModel>().Navigate();
        }
    }
}