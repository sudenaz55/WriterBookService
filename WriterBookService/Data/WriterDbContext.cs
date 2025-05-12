using System.Data.Entity;
using WriterBookService.Models;

namespace WriterBookService.Data
{
    public class WriterDbContext : DbContext
    {
        public WriterDbContext() : base("name=WriterDbContext")
        {
        }

        public DbSet<Writer> Writers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<WriterBook> WriterBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Writer>()
                .HasMany(w => w.WriterBooks)
                .WithRequired(wb => wb.Writer)
                .HasForeignKey(wb => wb.WriterId);

            modelBuilder.Entity<Book>()
                .HasMany(b => b.WriterBooks)
                .WithRequired(wb => wb.Book)
                .HasForeignKey(wb => wb.BookId);

            base.OnModelCreating(modelBuilder);
        }
    }
} 