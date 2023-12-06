using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Repositories.Models
{
    public partial class Sunglasses2023DBContext : DbContext
    {
        public Sunglasses2023DBContext()
        {
        }

        public Sunglasses2023DBContext(DbContextOptions<Sunglasses2023DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public virtual DbSet<Sunglass> Sunglasses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                string ConnectionStr = config.GetConnectionString("DB");

                optionsBuilder.UseSqlServer(ConnectionStr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.MemberAccountId)
                    .HasName("PK__Account__0FB6405860D6FFF1");

                entity.ToTable("Account");

                entity.HasIndex(e => e.MemberEmail, "UQ__Account__3F37B77A275C04CE")
                    .IsUnique();

                entity.Property(e => e.MemberAccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemberAccountID");

                entity.Property(e => e.MemberAccountPassword).HasMaxLength(70);

                entity.Property(e => e.MemberEmail).HasMaxLength(100);

                entity.Property(e => e.MemberFullName).HasMaxLength(100);
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.ToTable("Manufacturer");

                entity.Property(e => e.ManufacturerId).HasMaxLength(30);

                entity.Property(e => e.ManufacturerDescription).HasMaxLength(250);

                entity.Property(e => e.ManufacturerName).HasMaxLength(100);
            });

            modelBuilder.Entity<Sunglass>(entity =>
            {
                entity.HasKey(e => e.SunglassesId)
                    .HasName("PK__Sunglass__4C4C38EA7FC3543A");

                entity.Property(e => e.SunglassesId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Feature).HasMaxLength(220);

                entity.Property(e => e.ManufacturerId).HasMaxLength(30);

                entity.Property(e => e.Material).HasMaxLength(40);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Shape).HasMaxLength(40);

                entity.Property(e => e.SunglassesName).HasMaxLength(100);

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Sunglasses)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Sunglasse__Manuf__3C69FB99");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
