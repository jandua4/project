using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class Allergy
    {
        public int AllergyID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        // Navigation
        public ICollection<FoodChain> FoodChains { get; set; }
    }
}
