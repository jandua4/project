using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class AllergyGroup
    {
        public int GroupID { get; set; }

        [Required]
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }

        // Multiple Allergies per Group
        public ICollection<Allergy> Allergies { get; set; }
    }
}
