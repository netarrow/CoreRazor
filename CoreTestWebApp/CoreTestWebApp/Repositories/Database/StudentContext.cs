using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTestWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreTestWebApp.Repositories.Database
{
    public class StudentContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentDbGen;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsRequired()
                    .IsUnicode(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(1000)
                    .IsRequired()
                    .IsUnicode(true);

                entity.Property(e => e.CF)
                    .HasMaxLength(1000)
                    .IsRequired()
                    .IsUnicode(true);

                entity.Property(e => e.StudentId).IsRequired();
                entity.HasKey(_ => _.StudentId);


            });
        }

    }
}
