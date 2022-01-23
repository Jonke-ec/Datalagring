using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_WPF.Models {

    internal class Subject {

        [Key]
        public int Id { get; set; }

        [Required]
        public string ErrandTitle { get; set; } = null!;

        [Required]
        [StringLength(200)]
        public string Description { get; set; } = null!;

        [Required]
        public string Status { get; set; } = null!;

        public DateTime ErrandDate { get; set; } = DateTime.Now;

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        
    }
}
