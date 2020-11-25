using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoOOAD.Entities
{
    public partial class DEMO_OOADContext : DbContext
    {
        public DEMO_OOADContext()
        {
        }

        public DEMO_OOADContext(DbContextOptions<DEMO_OOADContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietDs> ChiTietDs { get; set; }
        public virtual DbSet<ChiTietHd> ChiTietHd { get; set; }
        public virtual DbSet<DanhSachMa> DanhSachMa { get; set; }
        public virtual DbSet<Hinh> Hinh { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<LoaiMa> LoaiMa { get; set; }
        public virtual DbSet<MonAn> MonAn { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-SSH4RF4\\SQLEXPRESS;Initial Catalog=DEMO_OOAD;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDs>(entity =>
            {
                entity.HasKey(e => e.MaCt)
                    .HasName("PK_CHITIETDS");

                entity.ToTable("ChiTietDS");

                entity.Property(e => e.MaCt)
                    .HasColumnName("MaCT")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaDs)
                    .IsRequired()
                    .HasColumnName("MaDS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaMa)
                    .IsRequired()
                    .HasColumnName("MaMA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaDsNavigation)
                    .WithMany(p => p.ChiTietDs)
                    .HasForeignKey(d => d.MaDs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ChiTietDS_fk1");

                entity.HasOne(d => d.MaMaNavigation)
                    .WithMany(p => p.ChiTietDs)
                    .HasForeignKey(d => d.MaMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ChiTietDS_fk0");
            });

            modelBuilder.Entity<ChiTietHd>(entity =>
            {
                entity.HasKey(e => e.MaCthd)
                    .HasName("PK_CHITIETHD");

                entity.ToTable("ChiTietHD");

                entity.Property(e => e.MaCthd)
                    .HasColumnName("MaCTHD")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaHd)
                    .IsRequired()
                    .HasColumnName("MaHD")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaMa)
                    .IsRequired()
                    .HasColumnName("MaMA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.ChiTietHd)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ChiTietHD_fk1");

                entity.HasOne(d => d.MaMaNavigation)
                    .WithMany(p => p.ChiTietHd)
                    .HasForeignKey(d => d.MaMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ChiTietHD_fk0");
            });

            modelBuilder.Entity<DanhSachMa>(entity =>
            {
                entity.HasKey(e => e.MaDs)
                    .HasName("PK_DANHSACHMA");

                entity.ToTable("DanhSachMA");

                entity.Property(e => e.MaDs)
                    .HasColumnName("MaDS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ChiNhanh)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ngay).HasColumnType("date");
            });

            modelBuilder.Entity<Hinh>(entity =>
            {
                entity.HasKey(e => e.MaHinh)
                    .HasName("PK_HINH");

                entity.Property(e => e.MaHinh)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DuongDan)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaMa)
                    .IsRequired()
                    .HasColumnName("MaMA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaMaNavigation)
                    .WithMany(p => p.Hinh)
                    .HasForeignKey(d => d.MaMa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Hinh_fk0");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK_HOADON");

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NgayMua).HasColumnType("date");

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LoaiMa>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK_LOAIMA");

                entity.ToTable("LoaiMA");

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MonAn>(entity =>
            {
                entity.HasKey(e => e.MaMa)
                    .HasName("PK_MONAN");

                entity.Property(e => e.MaMa)
                    .HasColumnName("MaMA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Gia).HasColumnName("gia");

                entity.Property(e => e.MaDs)
                    .IsRequired()
                    .HasColumnName("MaDS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaLoai)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Mota)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.MonAn)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MonAn_fk0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
