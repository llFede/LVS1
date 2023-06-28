using CommunityToolkit.Mvvm.ComponentModel;
using LVS1.wpf.ViewModels;

namespace LVS1.wpf.Navigation;

public class NavigationStore
{
    private ViewModelBase _currentViewModel;

    public ViewModelBase CurrentViewModel 
    { 
        get => _currentViewModel; 
        set
        {
            _currentViewModel = value;
            CurrentViewModelChanged?.Invoke();
        }
    }
    public event Action? CurrentViewModelChanged;
}