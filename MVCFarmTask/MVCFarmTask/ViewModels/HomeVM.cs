using MVCFarmTask.Models;

namespace MVCFarmTask.ViewModels;

public class HomeVM
{
    public List<Worker> Workers { get; set; }
    public List<Product> Products { get; set; }
}
