using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturentWebsite.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Starters { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string MainCourse { get; set; }
        [Required]
        public int Drinks { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public String Sides { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public String Desert { get; set; }
    }
}
