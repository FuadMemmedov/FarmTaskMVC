using Microsoft.AspNetCore.Mvc;
using MVCFarmTask.DAL;
using MVCFarmTask.ViewModels;

namespace MVCFarmTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Workers = _dbContext.Workers.ToList(),
                Products = _dbContext.Products.ToList()
            };



            return View(homeVM);
        }
    }
}
