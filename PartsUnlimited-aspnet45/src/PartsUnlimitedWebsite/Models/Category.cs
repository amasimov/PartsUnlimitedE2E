using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//My 1st change
//My 3d change
// my 4tj change
namespace PartsUnlimited.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}