using CarApplication.Model;
using CarApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages
{
    public class DataModel : PageModel
    {
        private readonly CarService _CarServices;

        public List<CarModel> Cars { get; private set; }

        public DataModel(CarService gameServices)
        {
            _CarServices = gameServices;
        }

        public void OnGet()
        {
            // Retrieve the games using the GameServices
            IEnumerable<CarModel> gameModels = _CarServices.GetProducts();
            Cars = new List<CarModel>(gameModels);
        }
    }
}
