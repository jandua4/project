using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class FoodChain
    {
        public int FoodChainID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string FoodChainName { get; set; }

        [Display(Name = "Description")]
        [StringLength(255, ErrorMessage = "Max 255 Characters")]
        public string Description { get; set; }

        // Menu Filepath. Should be nullable
        [Display(Name = "Menu")]
        public string MenuLink { get; set; }

        [Display(Name = "Gluten Free Options?")]
        public string GlutenFreeOptions { get; set; }

        [Display(Name = "Vegetarian Options?")]
        public string VegetarianOptions { get; set; }

        [Display(Name = "Vegan Options?")]
        public string VeganOptions { get; set; }

        [Display(Name = "Dairy Free Options?")]
        public string DairyFreeOptions { get; set; }

        [Display(Name = "Nut Free Options?")]
        public string NutFreeOptions { get; set; }

        [Display(Name = "Other Allergies Accommodated")]
        public string OtherOptions { get; set; }

        // Navigation
        public ICollection<Allergy> Allergies { get; set; }
    }
}
