using LVS1.wpf.Data;
using LVS1.wpf.ViewModels;

namespace LVS1.wpf.Navigation;

public class NavigationService<TViewModel> : INavigationService where TViewModel : ViewModelBase
{
    private readonly NavigationStore navigationStore;
    private readonly Func<TViewModel> createViewModel;

    public NavigationService(NavigationStore navigationStore, Func<TViewModel> createViewModel)
    {
        this.navigationStore = navigationStore;
        this.createViewModel = createViewModel;
    }
    public void Navigate()
    {
        navigationStore.CurrentViewModel = createViewModel();
    }
}