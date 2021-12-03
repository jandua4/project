using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class FoodChain
    {
        public int FoodChainID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DbSet<Allergy> Allergy { get; set; }

        // Menu Filepath. Should be nullable
        public string Filename { get; set; }
    }
}
