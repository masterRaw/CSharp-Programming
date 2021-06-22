using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace mvc.Models
{
    public class Category
    {
        [Key]
        public int UID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,1000000000,ErrorMessage ="Contact number must be of 10 digits." )]
        public int display { get; set; }
        

    }    
}
