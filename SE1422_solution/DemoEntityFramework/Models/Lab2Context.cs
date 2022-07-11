using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace DemoEntityFramework.Models
{
    public partial class Lab2Context : DbContext
    {
        public Lab2Context()
        {
        }

        public Lab2Context(DbContextOptions<Lab2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                //optionsBuilder.UseSqlServer("server=LAPTOP-0GU2ESDG\\SQLEXPRESS;database=Lab2;user=sa;password=123456789");
                optionsBuilder.UseSqlServer(config.GetConnectionString("MyConStr"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Major>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__Major__357D4CF8D34A51BB");

                entity.ToTable("Major");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("code")
                    .IsFixedLength(true);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.Major)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("major")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Scholarship).HasColumnName("scholarship");

                entity.HasOne(d => d.MajorNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Major)
                    .HasConstraintName("FK__Students__major__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
