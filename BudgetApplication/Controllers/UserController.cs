using Microsoft.AspNetCore.Mvc;

namespace BudgetApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }

    }
}
