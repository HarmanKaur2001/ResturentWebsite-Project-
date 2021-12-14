using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturentWebsite.Models
{
    public class OurTeam
    {
        [Key]
        public int TeamID { get; set; }

        [Required]
        public int MasterChef { get; set; }

        [Required]
        public int SousChef { get; set; }

        [Required]
        public int CrewMembers { get; set; }

        [Required]
        public int Bartender { get; set; }

        [Required]
        public int Cashier { get; set; }
    }
}
