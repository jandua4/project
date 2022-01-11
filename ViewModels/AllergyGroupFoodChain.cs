using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;

namespace Restaurant.ViewModels
{
    public class AllergyGroupFoodChain
    {
        public IEnumerable<FoodChain> FoodChains { get; set; }
        public IEnumerable<Allergy> Allergies { get; set; }
        public IEnumerable<AllergyGroup> AllergyGroups { get; set; }

    }

}
