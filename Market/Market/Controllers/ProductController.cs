using Microsoft.AspNetCore.Mvc;

namespace Market.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
