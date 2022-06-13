using ArageekMvc.Models;
using ArageekMvc.Repository;
using ArageekMvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ArageekMvc.Controllers
{
    public class ArticalsController : Controller
    {
        private readonly IArticalRepository articalRepository;

        public ArticalsController(IArticalRepository _articalRepository)
        {
            articalRepository = _articalRepository;
        }
        //ArticalVM articalVM;
        //List<ArticalVM> articalVMs;

        //public TestBindingController()
        //{
        //    articalVM = new ArticalVM() { FirstName = "Brothers", LastName = "Karamazov" 
        //    };

        //    articalVMs = new List<ArticalVM>()
        //    {
        //        new ArticalVM() { FirstName ="shock",LastName ="doctrine"},
        //        new ArticalVM() { FirstName ="Elahly",LastName="Club"}
        //    };
        //}
        public IActionResult ViewDataBinding()
        {
            return View();
        }
        public IActionResult Index()
        {
            List<Artical> articals = articalRepository.GetAll();

            List<ArticalVM> articalVMs = articals.Select(x =>
            new ArticalVM
            {
                Title = x.Title
                ,
                AuthorName = $"{x.auther.FirstName} {x.auther.LastName}"
                ,
                ID = x.Id
                ,
                ImageURL = x.ImageURL
            }).ToList();//mapping

            return View(articalVMs);
        }
    }
}
