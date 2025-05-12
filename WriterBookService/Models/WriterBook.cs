using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WriterBookService.Models
{
    public class WriterBook
    {
        [Key]
        public int WriterBookId { get; set; }

        [Required]
        public int WriterId { get; set; }

        [Required]
        public int BookId { get; set; }

        [ForeignKey("WriterId")]
        public virtual WriterBookService.Models.Writer Writer { get; set; }

        [ForeignKey("BookId")]
        public virtual WriterBookService.Models.Book Book { get; set; }
    }
} 