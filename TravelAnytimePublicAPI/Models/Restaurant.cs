using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAnytimePublicAPI.Models
{
    [Table("Restaurants")]
    public class Restaurant
    {
        [Key]
        [Required]
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string description { get; set; }
        public string keywords { get; set; }
        public string phone_number { get; set; }
        public string restaurant_email { get; set; }
        public string address { get; set; }
        public string opens { get; set; }
        public string closes { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string area { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public int price { get; set; }
        public string reserve_url { get; set; }
        public string mobile_reserve_url { get; set; }
        public string image_url { get; set; }
        public List<RestaurantReview> reviews { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
