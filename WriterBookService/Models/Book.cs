using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WriterBookService.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string ISBN { get; set; }

        public DateTime PublicationDate { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<WriterBook> WriterBooks { get; set; }
    }
} 