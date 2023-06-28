using LVS1.wpf.Data;

namespace LVS1.wpf.ViewModels;

public class FloorItemViewModel : ViewModelBase
{
    private readonly ApplicationDbContext _context;

    public FloorItemViewModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public Models.Floor Floor { get; set; }
    public FloorItemViewModel SetModel(Models.Floor floor)
    {
        Floor = floor;
        return this;
    }
}