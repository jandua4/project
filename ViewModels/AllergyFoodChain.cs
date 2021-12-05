using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.Models;

namespace Restaurant.ViewModels
{
    public class AllergyFoodChain
    {
        public int ID { get; set; }
        public int FoodChainID { get; set; }
        public int AllergyID { get; set; }

        // Navigation
        public FoodChain FoodChain { get; set; }
        public Allergy Allergy { get; set; }
    }
}
