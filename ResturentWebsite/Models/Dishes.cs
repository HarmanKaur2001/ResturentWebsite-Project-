using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturentWebsite.Models
{
    public class Dishes
    {
        [Key]
        public int DishID { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string BreakfastDishes { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public String LunchDishes { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public String DinnerDishes { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public String Snacks { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public String EspacialDishes { get; set; }
    }
}
