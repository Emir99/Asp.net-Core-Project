using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Owner
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Can't be blank!")]
        [MaxLength(25, ErrorMessage = "Can't be more than 25 characters!")]
        public string First_name { get; set; }

        [Required(ErrorMessage = "Can't be blank!")]
        [MaxLength(25, ErrorMessage = "Can't be more than 25 characters!")]
        public string Last_name { get; set; }

        [Range(1, 200, ErrorMessage = "Must be in range from 0 to 200!")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Can't be blank!")]
        [EmailAddress(ErrorMessage = "You need to provide a valid email address!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Can't be blank!")]
        [Range(0, 50, ErrorMessage = "Must be in range from 0 to 50!")]
        public string Ssn { get; set; }

        public ICollection<Building> Buildings { get; set; }
    }
}
