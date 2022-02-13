using Microsoft.AspNetCore.Mvc;

namespace UserInformation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}