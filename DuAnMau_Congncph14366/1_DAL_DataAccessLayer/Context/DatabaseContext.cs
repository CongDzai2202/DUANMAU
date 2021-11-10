using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _1_DAL_DataAccessLayer.Models;

#nullable disable

namespace _1_DAL_DataAccessLayer.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hang> Hangs { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-LR1T362Q\\SQLEXPRESS;Initial Catalog=DUANMAU;Persist Security Info=True;User ID=congnc22;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hang>(entity =>
            {
                entity.HasKey(e => new { e.Mahang, e.Tenhang })
                    .HasName("PK__HANG__0ED1C95440C65413");

                entity.Property(e => e.Hinhanh).IsUnicode(false);

                entity.Property(e => e.Manv).IsUnicode(false);

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Hangs)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HANG__MANV__38996AB5");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Sodienthoai)
                    .HasName("PK__KHACHHAN__7670E2980AA606A0");

                entity.Property(e => e.Manv).IsUnicode(false);

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Khachhangs)
                    .HasForeignKey(d => d.Manv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KHACHHANG__MANV__3B75D760");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manv)
                    .HasName("PK__NHANVIEN__603F5114BCF267B3");

                entity.Property(e => e.Manv).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
