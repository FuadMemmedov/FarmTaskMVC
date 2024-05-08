using Microsoft.AspNetCore.Mvc;

namespace MVCFarmTask.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
