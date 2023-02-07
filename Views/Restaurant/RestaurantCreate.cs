using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantRaterMVC.Views.Restaurant
{
    public class RestaurantCreate
    {
        [Required]
        public string Name {get; set; }
        [StringLength(100)]
        
        [Required]
        public string Location {get; set; }
        [StringLength(100)]
    }
} 