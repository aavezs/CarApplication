using System.Text.Json.Serialization;

namespace CarApplication.Model
{
    public class CarModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
        public string Color { get; set; }
    }
}
