using Microsoft.AspNetCore.Mvc;

namespace MVCFarmTask.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
