using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class UserAllergySelection
    {
        public int ID { get; set; }

        // Try to get users who have the customer role only (Optional)
        // Set ForeginKey property in Migration
        [StringLength(450)]
        public string UserID { get; set; }

        [Display(Name = "Gluten Free?")]
        public string GlutenFree { get; set; }

        [Display(Name = "Vegetarian?")]
        public string Vegetarian { get; set; }

        [Display(Name = "Vegan?")]
        public string Vegan { get; set; }

        [Display(Name = "Dairy Free?")]
        public string DairyFree { get; set; }

        [Display(Name = "Nut Free?")]
        public string NutFree { get; set; }
    }
}
