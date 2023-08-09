using CarApplication.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace CarApplication.Services
{
    public class CarService
    {
        public CarService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

       
        public IWebHostEnvironment WebHostEnvironment { get; }

       
        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "Data", "CarData.json");

        
        public IEnumerable<CarModel> GetProducts()
        {

            using var jsonFileReader = File.OpenText(JsonFileName);

           
            return JsonSerializer.Deserialize<CarModel[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            })!;
        }
    }
}
