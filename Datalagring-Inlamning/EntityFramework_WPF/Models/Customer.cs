using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_WPF.Models {

    [Index(nameof(Email), IsUnique = true)]

    internal class Customer {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public int PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(5)]
        public int Postalcode { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string Country { get; set; } = null!;

        public string FullName => $"{FirstName} {LastName}";

        public virtual ICollection<Subject> Subjects { get; set; }

    }
}
