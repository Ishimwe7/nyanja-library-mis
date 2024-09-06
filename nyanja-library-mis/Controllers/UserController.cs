using Microsoft.AspNetCore.Mvc;

namespace nyanja_library_mis.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
