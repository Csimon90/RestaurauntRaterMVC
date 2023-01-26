using System.ComponentModel.DataAnnotations;

namespace RestaurantRaterMVC.Models
{
    public class RestaurantListItem
    {
        public int Id {get; set; }
        public string Name{get; set; }
        [Display(Name = "Average Score")]
        public double Score {get; set; }
    }
}