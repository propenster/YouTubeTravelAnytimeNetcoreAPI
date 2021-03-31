using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAnytimePublicAPI.Models
{
    [Table("RestaurantReviews")]
    public class RestaurantReview
    {
        [Key]
        [Required]
        public int id { get; set; }
        public string author { get; set; }
        public string email { get; set; }
        public string body { get; set; }
        public int restaurant_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        [ForeignKey("restaurant_id")]
        public Restaurant restaurant { get; set; }
    }
}
