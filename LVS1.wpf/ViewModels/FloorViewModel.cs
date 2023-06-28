using LVS1.wpf.Data;

namespace LVS1.wpf.ViewModels;

public class FloorViewModel : ViewModelBase
{
    private readonly ApplicationDbContext _context;

    public FloorViewModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public Models.Floor Floor { get; set; }
    public FloorViewModel SetModel(Models.Floor floor)
    {
        Floor = floor;
        return this;
    }
}