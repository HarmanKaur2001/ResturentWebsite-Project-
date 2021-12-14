using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturentWebsite.Models
{
    public class Events
    {
        [Key]

        [Column(TypeName = "varchar(20)")]

        public String WineTasting { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]

        public string CocktailWorkshope { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]

        public String Brunch { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]

        public String Location { get; set; }
        [Required]

        public DateTime Date { get; set; }
    }
}
