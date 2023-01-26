using System.ComponentModel.DataAnnotations;

namespace RestaurantRaterMVC.Controllers.Data
{
    public class Restaurant
    {
        [Key]
        public int Id {get; set; }
        [Required]
        [MaxLength(100)]
        public string Name {get; set; }
        [Required]
        [MaxLength(100)]
        public string Location {get; set; }
        public virtual List<Ratings> Ratings {get; set; }
        public double AverageFoodScore
        {
            get
            {
                return Ratings.Count > 0 ? Ratings.Select(r => r.AverageFoodScore).Sum() / Ratings.Count : 0;
            }
        }
        public double AverageCleanlinessScore
        {
            get
            {
                return Ratings.Count > 0 ? Ratings.Select(r => r.AverageCleanlinessScore).Sum() / Ratings.Count : 0;
            }
        }
        public double AverageAtmosphereScore
        {
            get
            {
                return Ratings.Count > 0 ? Ratings.Select(r => r.AverageAtmosphereScore).Sum() / Ratings.Count : 0;
            }
        }
        public double Score
        {
            get
            {
                return (AverageFoodScore + AverageCleanlinessScore + AverageAtmosphereScore) / 3;
            }
        }
    }
}