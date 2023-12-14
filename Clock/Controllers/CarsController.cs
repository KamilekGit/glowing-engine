using Clock.Data.interfaces;
using Clock.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Clock.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAllCars _allCars;
       private readonly ICarsCategory _allCategories;
        public CarsController(IAllCars iallcars, ICarsCategory icarscategory) { 
        _allCars = iallcars;
            _allCategories = icarscategory;
            
        }
        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.GetFavCars;
            obj.currCategory = "автомобили";

            return View(obj);
        }
    }
}
