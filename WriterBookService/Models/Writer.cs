using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WriterBookService.Models
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public virtual ICollection<WriterBook> WriterBooks { get; set; }
    }
} 