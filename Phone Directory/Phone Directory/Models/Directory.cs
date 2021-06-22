using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phone_Directory.Models
{
    public class Directory
    {
        [Key]
        public int UID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 999, ErrorMessage = "ISD Code must not be more than 3 digits.")]
        public int ISD { get; set; }

        [Required]
        [Range(1, 9999999999, ErrorMessage = "Contact number must be of 10 digits.")]
        public int Number { get; set; }



    }
}
