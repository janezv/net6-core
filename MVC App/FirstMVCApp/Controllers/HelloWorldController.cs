using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs=new List<DogViewModel>();


        public IActionResult Index()
        {
            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogVM = new DogViewModel();
            return View(dogVM);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Hello()
        {
            DogViewModel doggo = new DogViewModel()
            {
                Name = "Shibimaru",
                Age =
5
            };

            return View(doggo);
        }
    }
}
