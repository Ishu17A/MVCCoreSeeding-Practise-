using Microsoft.AspNetCore.Mvc;

namespace MVCCorePractice.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
