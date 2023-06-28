using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using LVS1.wpf.Navigation;

namespace LVS1.wpf.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly NavigationStore _navigationStore;

    public MainViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
        navigationStore.CurrentViewModelChanged += () => RaisePropertyChanged(nameof(CurrentViewModel)); ;
    }

    public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
}