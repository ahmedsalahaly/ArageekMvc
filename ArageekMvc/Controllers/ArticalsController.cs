using Microsoft.AspNetCore.Mvc;

namespace ArageekMvc.Controllers
{
    public class ArticalsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
