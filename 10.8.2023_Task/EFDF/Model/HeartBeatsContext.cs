using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFDF.Models;

public partial class HeartBeatsContext : DbContext
{
    public HeartBeatsContext()
    {
    }

    public HeartBeatsContext(DbContextOptions<HeartBeatsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Donor> Donors { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        optionsBuilder.UseSqlServer("data source =LAPTOP-7BMC5C35\\SQLEXPRESS ;" +
            "database= EmployeeManagementcd; integrated security=SSPI; \nTrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Depno).HasName("PK__departme__00D49618E17E9B84");

            entity.ToTable("department");

            entity.Property(e => e.Depno)
                .ValueGeneratedNever()
                .HasColumnName("depno");
            entity.Property(e => e.Dname)
                .HasMaxLength(15)
                .HasColumnName("dname");
        });

        modelBuilder.Entity<Donor>(entity =>
        {
            entity.HasKey(e => e.Donorid).HasName("PK__donor__A58AD1096375493A");

            entity.ToTable("donor");

            entity.HasIndex(e => e.Email, "unq").IsUnique();

            entity.Property(e => e.Donorid)
                .ValueGeneratedNever()
                .HasColumnName("donorid");
            entity.Property(e => e.Alcoholic)
                .HasMaxLength(5)
                .HasColumnName("alcoholic");
            entity.Property(e => e.City)
                .HasMaxLength(25)
                .HasColumnName("city");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("dob");
            entity.Property(e => e.Email)
                .HasMaxLength(35)
                .HasColumnName("email");
            entity.Property(e => e.Gender)
                .HasMaxLength(15)
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.Num)
                .HasMaxLength(10)
                .HasColumnName("num");
            entity.Property(e => e.Password)
                .HasMaxLength(25)
                .HasColumnName("password");
            entity.Property(e => e.State)
                .HasMaxLength(25)
                .HasColumnName("state");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_emp");

            entity.ToTable("emp");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Addr)
                .HasMaxLength(35)
                .HasColumnName("addr");
            entity.Property(e => e.Depno).HasColumnName("depno");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .HasColumnName("name");

            entity.HasOne(d => d.DepnoNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Depno)
                .HasConstraintName("fk_dep");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.Repid).HasName("PK__report__207D7FC8881FF9EE");

            entity.ToTable("report");

            entity.Property(e => e.Repid)
                .ValueGeneratedNever()
                .HasColumnName("repid");
            entity.Property(e => e.Donorid).HasColumnName("donorid");
            entity.Property(e => e.Report1)
                .HasColumnType("text")
                .HasColumnName("report");
            entity.Property(e => e.Tym)
                .HasColumnType("datetime")
                .HasColumnName("tym");

            entity.HasOne(d => d.Donor).WithMany(p => p.Reports)
                .HasForeignKey(d => d.Donorid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk1");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.Reqid).HasName("PK__request__20C37201C8DFDB5E");

            entity.ToTable("request");

            entity.Property(e => e.Reqid)
                .ValueGeneratedNever()
                .HasColumnName("reqid");
            entity.Property(e => e.Donorid).HasColumnName("donorid");
            entity.Property(e => e.Request1)
                .HasColumnType("text")
                .HasColumnName("request");
            entity.Property(e => e.Tym)
                .HasColumnType("datetime")
                .HasColumnName("tym");

            entity.HasOne(d => d.Donor).WithMany(p => p.Requests)
                .HasForeignKey(d => d.Donorid)
                .HasConstraintName("fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
