using Microsoft.AspNetCore.Mvc;

namespace Master.Controllers.Api
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
