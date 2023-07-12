using Microsoft.AspNetCore.Mvc;

namespace Master.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
