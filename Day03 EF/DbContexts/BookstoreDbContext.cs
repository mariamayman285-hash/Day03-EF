using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day03_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Day03_EF.DbContexts
{
    internal class BookstoreDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=BookstoreDB; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(B =>
            {
                B.ToTable("Books");
                B.Property(B => B.Title)
                 .HasMaxLength(50);
                B.Property(B => B.price)
                 .HasColumnType("decimal(8,2)");
                B.Property(B => B.PublishedDate)
                 .IsRequired(false);
            });
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }
    }
}
