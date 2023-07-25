using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NotarialHelper;

public partial class NotarialOfficeContext : DbContext
{
    public NotarialOfficeContext()
    {
    }

    public NotarialOfficeContext(DbContextOptions<NotarialOfficeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Deal> Deals { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = DESKTOP-AI3C159; Database = NotarialOffice; Trusted_Connection=True; TrustServerCertificate=Yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdClient);

            entity.Property(e => e.IdClient).HasColumnName("id_client");
            entity.Property(e => e.Adress)
                .HasMaxLength(50)
                .HasColumnName("adress");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .HasColumnName("full_name");
            entity.Property(e => e.KindActivity)
                .HasMaxLength(50)
                .HasColumnName("kind_activity");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Deal>(entity =>
        {
            entity.HasKey(e => e.IdDeal);

            entity.Property(e => e.IdDeal).HasColumnName("id_deal");
            entity.Property(e => e.Commission)
                .HasMaxLength(50)
                .HasColumnName("commission");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.IdClient).HasColumnName("id_client");
            entity.Property(e => e.IdService).HasColumnName("id_service");
            entity.Property(e => e.Sum)
                .HasMaxLength(50)
                .HasColumnName("sum");

            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.Deals)
                .HasForeignKey(d => d.IdClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deals_Clients");

            entity.HasOne(d => d.IdServiceNavigation).WithMany(p => p.Deals)
                .HasForeignKey(d => d.IdService)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deals_Services");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.IdService);

            entity.Property(e => e.IdService).HasColumnName("id_service");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
