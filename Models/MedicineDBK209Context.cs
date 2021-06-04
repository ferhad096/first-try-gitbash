using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MedicineApp.Models
{
    public partial class MedicineDBK209Context : DbContext
    {
        public MedicineDBK209Context()
        {
        }

        public MedicineDBK209Context(DbContextOptions<MedicineDBK209Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Firm> Firms { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<MedicineToTag> MedicineToTags { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-O8ATDPP;Initial Catalog=MedicineDBK209;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Firm>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.ToTable("Medicine");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Firm)
                    .WithMany(p => p.Medicines)
                    .HasForeignKey(d => d.FirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicine_Firms");
            });

            modelBuilder.Entity<MedicineToTag>(entity =>
            {
                entity.ToTable("Medicine_to_tags");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.MedicineToTags)
                    .HasForeignKey(d => d.MedicineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicine_to_tags_Medicine");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.MedicineToTags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicine_to_tags_Tags");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Worder)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.WorderId)
                    .HasConstraintName("FK_Orders_Workers1");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.Property(e => e.ItemPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.MedicineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Medicine");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderItems_Orders");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
