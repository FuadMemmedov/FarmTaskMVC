using Microsoft.AspNetCore.Mvc;

namespace MVCFarmTask.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
