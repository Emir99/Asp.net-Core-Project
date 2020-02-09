using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Building
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Can't be blank!")]
        [MaxLength(50, ErrorMessage = "Can't be longer than 100!")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "You need to provide a valid email address!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Can't be blank!")]
        [Display(Name = "Building Type")]
        public Type1 Building_type { get; set; }

        [Required(ErrorMessage = "Can't be blank!")]
        [RangeUntilCurrentYear(1900, ErrorMessage = "Please enter a valid year!")]
        public DateTime Constructed_date { get; set; }

        [Required(ErrorMessage = "Can't be blank!")]
        [Range(0, 1000, ErrorMessage = "Must be in range from 0 to 1000!")]
        public int Stories { get; set; }

        public int OwnerId { get; set; }

        public Owner Owner { get; set; }

        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
        public class RangeUntilCurrentYearAttribute : RangeAttribute
        {
            public RangeUntilCurrentYearAttribute(int minimum) : base(minimum, DateTime.Now.Year) { }
        }
    }
}
