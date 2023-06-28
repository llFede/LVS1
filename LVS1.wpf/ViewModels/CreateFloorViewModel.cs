using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Input;
using LVS1.wpf.Data;
using LVS1.wpf.Navigation;
using Microsoft.EntityFrameworkCore;

namespace LVS1.wpf.ViewModels;

public partial class CreateFloorViewModel : ViewModelBase
{
    private readonly ApplicationDbContext _context;
    private readonly NavigationServiceFactory _navigationFactory;

    public CreateFloorViewModel(ApplicationDbContext context, NavigationServiceFactory navigationFactory)
    {
        _context = context;
        _navigationFactory = navigationFactory;
    }

    public int Number { get; set; }

    [RelayCommand]
    public async Task Create()
    {
        var currentFloor = await _context.Floors.FirstOrDefaultAsync(floor => floor.Number == Number);
            
        if (currentFloor is null)
        {
            var floor = new Models.Floor { Number = Number };
            await _context.AddAsync(floor);
            await _context.SaveChangesAsync();
            _navigationFactory.GetNavigationService<FloorListViewModel>().Navigate();
        }
    }
}