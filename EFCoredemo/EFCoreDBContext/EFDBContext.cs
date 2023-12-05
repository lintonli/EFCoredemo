using EFCoredemo.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoredemo.EFCoreDBContext
{
    public class EFDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server= EDIMUND; Database = MANY2MANY; Trusted_Connection = True; TrustServerCertificate = True; ");
     
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //1to1
            /* base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<Author>()
             .HasOne(a => a.book)
             .WithOne(b => b.Author)
             .HasForeignKey<Book>(a => a.AuthorId);*/

            //one to many
            /*base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>()
            .HasMany(a => a.Books)
            .WithOne(b => b.Author)
            .HasForeignKey(b => b.AuthorId);*/

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>()
            .HasMany(a => a.Books)
            .WithMany(b => b.Authors)
            .UsingEntity(j => j.ToTable("AuthorsBooks"));
        }
        public DbSet<Author> Authors { get; set; }  
        public DbSet<Book> Books { get; set; }
    }
}
