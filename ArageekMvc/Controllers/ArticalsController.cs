using ArageekMvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ArageekMvc.Controllers
{
    public class ArticalsController : Controller
    {
        ArticalVM articalVM;
        List<ArticalVM> articalVMs;

        public TestBindingController()
        {
            articalVM = new ArticalVM() { FirstName = "Brothers", LastName = "Karamazov" 
            };

            articalVMs = new List<ArticalVM>()
            {
                new ArticalVM() { FirstName ="shock",LastName ="doctrine"},
                new ArticalVM() { FirstName ="Elahly",LastName="Club"}
            };
        }
        public IActionResult ViewDataBinding()
        {
            return View(articalVM);
        }
    }
}
