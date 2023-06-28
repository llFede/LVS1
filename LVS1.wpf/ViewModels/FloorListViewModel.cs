using CommunityToolkit.Mvvm.Input;
using LVS1.wpf.Data;
using LVS1.wpf.Navigation;
using Microsoft.Extensions.DependencyInjection;

namespace LVS1.wpf.ViewModels;

public partial class FloorListViewModel : ViewModelBase
{
    private readonly ApplicationDbContext _context;
    private readonly NavigationServiceFactory _navigationFactory;
    private readonly IServiceProvider _serviceProvider;

    public FloorListViewModel(ApplicationDbContext context, NavigationServiceFactory navigationFactory, IServiceProvider serviceProvider)
    {
        _context = context;
        _navigationFactory = navigationFactory;
        _serviceProvider = serviceProvider;
    }

    public IEnumerable<FloorViewModel> Floors => _context
        .Floors
        .ToArray()
        .Select(floor => _serviceProvider.GetRequiredService<FloorViewModel>().SetModel(floor));

    [RelayCommand]
    public async Task AddFloor()
    {
        _navigationFactory.GetNavigationService<CreateFloorViewModel>().Navigate();
    }
}