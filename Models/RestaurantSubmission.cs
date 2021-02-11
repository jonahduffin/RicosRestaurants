using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RicosRestaurants.Models
{
    public class RestaurantSubmission
    {
        public string submitterName { get; set; }
        [Required(ErrorMessage = "Please enter a restaurant name.")]
        public string restaurantName { get; set; }
        public string? favoriteDish { get; set; }
        [Phone(ErrorMessage = "Invalid phone number. Please enter a 10-digit number in a regular format.")]
        public string? restaurantPhone { get; set; }
    }
}
