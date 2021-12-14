using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturentWebsite.Models
{
    public class FeedBack
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }
        [Required]
        public Int64 PhoneNumber { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public String Address { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public String City { get; set; }
    }
}
