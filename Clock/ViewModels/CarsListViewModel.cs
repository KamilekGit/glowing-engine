using Clock.Data.Models;

namespace Clock.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }
        public string currCategory {  get; set; }
    }
}
