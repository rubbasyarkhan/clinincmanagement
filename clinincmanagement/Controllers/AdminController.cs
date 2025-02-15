using Microsoft.AspNetCore.Mvc;

namespace clinincmanagement.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
