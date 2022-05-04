using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Repositories.DBModels
{
    public partial class clothes_storeContext : DbContext
    {
        public clothes_storeContext()
        {
        }

        public clothes_storeContext(DbContextOptions<clothes_storeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategories> TblCategories { get; set; }
        public virtual DbSet<TblClothes> TblClothes { get; set; }
        public virtual DbSet<TblCustomers> TblCustomers { get; set; }
        public virtual DbSet<TblSales> TblSales { get; set; }
        public virtual DbSet<TblSalesDetails> TblSalesDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(" Data Source=LAPTOP-HN5KS8GJ;Initial Catalog=clothes_store;Integrated Security=True ; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("tblCategories");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<TblClothes>(entity =>
            {
                entity.HasKey(e => e.ClothId);

                entity.ToTable("tblClothes");

                entity.Property(e => e.ClothColor).HasMaxLength(15);

                entity.Property(e => e.ClothName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ClothPic)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblClothes)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__tblClothe__Categ__3B75D760");
            });

            modelBuilder.Entity<TblCustomers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("tblCustomers");

                entity.Property(e => e.CreditCardNum).HasMaxLength(12);

                entity.Property(e => e.CreditCardTokef).HasColumnType("date");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CustomerPassword)
                    .IsRequired()
                    .HasMaxLength(9);
            });

            modelBuilder.Entity<TblSales>(entity =>
            {
                entity.HasKey(e => e.SaleId);

                entity.ToTable("tblSales");

                entity.Property(e => e.SaleDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblSales)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__tblSales__Custom__403A8C7D");
            });

            modelBuilder.Entity<TblSalesDetails>(entity =>
            {
                entity.HasKey(e => e.SaleDetailsId);

                entity.ToTable("tblSalesDetails");

                entity.Property(e => e.ClothAmount).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Cloth)
                    .WithMany(p => p.TblSalesDetails)
                    .HasForeignKey(d => d.ClothId)
                    .HasConstraintName("FK__tblSalesD__Cloth__44FF419A");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.TblSalesDetails)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK__tblSalesD__SaleI__440B1D61");
            });
        }
    }
}
