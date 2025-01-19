using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace assignment.Models;

public partial class AssignmnetContext : DbContext
{
    public AssignmnetContext()
    {
    }

    public AssignmnetContext(DbContextOptions<AssignmnetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Purchase> Purchases { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SaleDetail> SaleDetails { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=assignmnet;User Id=sa;Password=Admin@123;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_customers1");

            entity.ToTable("customers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BitActive)
                .HasDefaultValue(1)
                .HasColumnName("bitActive");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("customerEmail");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("customerName");
            entity.Property(e => e.CustomerPhone)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("customerPhone");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_products2");

            entity.ToTable("products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("image");
            entity.Property(e => e.ProductName)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("product_name");
            entity.Property(e => e.PurchasePrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("purchase_price");
            entity.Property(e => e.SellingPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("selling_price");
        });

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("purchases");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.PurchaseDate).HasColumnName("purchase_date");
            entity.Property(e => e.PurchasePrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("purchase_price");
            entity.Property(e => e.Qty).HasColumnName("qty");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.ToTable("sale");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Balance)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("balance");
            entity.Property(e => e.CustomerId).HasColumnName("customerID");
            entity.Property(e => e.Discount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("discount");
            entity.Property(e => e.DiscountPercentage).HasColumnName("discount_percentage");
            entity.Property(e => e.Paid)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("paid");
            entity.Property(e => e.SalesDate).HasColumnName("sales_date");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<SaleDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sale_details1");

            entity.ToTable("sale_details");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PriceItem)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("price_item");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.SalesId).HasColumnName("sales_id");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
