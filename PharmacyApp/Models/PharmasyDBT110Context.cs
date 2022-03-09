using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PharmacyApp.Models
{
    public partial class PharmasyDBT110Context : DbContext
    {
        public PharmasyDBT110Context()
        {
        }

        public PharmasyDBT110Context(DbContextOptions<PharmasyDBT110Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Firm> Firms { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Tagtomedicine> Tagtomedicines { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\; initial catalog=PharmasyDBT110; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Firm>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.Descrption).HasMaxLength(400);

                entity.Property(e => e.ExpireDaTe).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.Medicines)
                    .HasForeignKey(d => d.FirmId)
                    .HasConstraintName("FK__Medicines__FirmI__267ABA7A");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.MedicineId)
                    .HasConstraintName("FK__Orders__Medicine__33D4B598");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.WorkerId)
                    .HasConstraintName("FK__Orders__WorkerId__32E0915F");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Tagtomedicine>(entity =>
            {
                entity.ToTable("tagtomedicine");

                entity.Property(e => e.TagtomedicineId).HasColumnName("tagtomedicineId");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.Tagtomedicines)
                    .HasForeignKey(d => d.MedicineId)
                    .HasConstraintName("FK__tagtomedi__Medic__2C3393D0");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.Tagtomedicines)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK__tagtomedi__TagId__2B3F6F97");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
