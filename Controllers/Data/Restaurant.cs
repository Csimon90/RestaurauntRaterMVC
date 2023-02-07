using System.ComponentModel.DataAnnotations;

namespace RestaurantRaterMVC.Controllers.Data
{
    public class Restaurant
    {
        [Key]
        public int Id {get; set; }

        [Required]
        [MaxLength(100)]
        public string Name {get; set; }=null!;

        [Required]
        [MaxLength(100)]
        public string Location {get; set; }=null!;
    }

        public virtual List<Rating> Ratings {get; set; } = new List<Rating>();
        public double AverageFoodScore
        {
            get
            {
                return Ratings.Select(r => r.AverageFoodScore).Sum() / Ratings.Count;
            }
        }
        public double AverageCleanlinessScore
        {
            get
            {
                return Ratings.Select(r => r.AverageCleanlinessScore).Sum() / Ratings.Count;
            }
        }
        public double AverageAtmosphereScore
        {
            get
            {
                return Ratings.Select(r => r.AverageAtmosphereScore).Sum() / Ratings.Count;
            }
        }
        public double AverageAtmosphereScore => (Ratings.Count > 0)? Ratings.Average(r => r.AtmosphereScore) : 0;

    }
