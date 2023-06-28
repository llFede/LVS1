using CommunityToolkit.Mvvm.Input;
using LVS1.wpf.Managers;
using LVS1.wpf.Models.Validators;
using LVS1.wpf.Navigation;

namespace LVS1.wpf.ViewModels;

public partial class RegisterViewModel : ViewModelBase
{
    private readonly UserManager _userManager;
    private readonly NavigationServiceFactory _navigationFactory;

    public RegisterViewModel(UserManager userManager, NavigationServiceFactory navigationFactory)
    {
        _userManager = userManager;
        _navigationFactory = navigationFactory;
        User.PropertyChanged += (sender,e) => RaisePropertyChanged(nameof(User));
    }

    public RegisterUserModel User { get; set; } = new();

    [RelayCommand]
    public async Task Register()
    {
        if (!User.HasErrors)
        {
            await _userManager.Register(User);
            _navigationFactory.GetNavigationService<LoginViewModel>().Navigate();
        }
    }
}