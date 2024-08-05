﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class DuAnNhom4Context : DbContext
{
    public DbSet<SanPhamMua> SanPhamMuas { get; set; } 


    public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

    public virtual DbSet<DanhGium> DanhGia { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KhoHang> KhoHangs { get; set; }

    public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<SanPhamGiamGium> SanPhamGiamGia { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
<<<<<<< HEAD
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-289J5PP0\\THUAN;Initial Catalog=Du_An_Nhom4;Integrated Security=True;Trust Server Certificate=True");
=======
        => optionsBuilder.UseSqlServer("Data Source=DUONG;Initial Catalog=Du_An_Nhom4;Integrated Security=True;Trust Server Certificate=True");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.ChiTietDonHangId).HasName("PK__ChiTietD__45B33F8310CBB336");
=======
            entity.HasKey(e => e.ChiTietDonHangId).HasName("PK__ChiTietD__45B33F833E5B338B");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.ToTable("ChiTietDonHang");

            entity.Property(e => e.ChiTietDonHangId)
                .ValueGeneratedNever()
                .HasColumnName("ChiTietDonHangID");
            entity.Property(e => e.DonHangId).HasColumnName("DonHangID");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.DonHang).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.DonHangId)
<<<<<<< HEAD
                .HasConstraintName("FK__ChiTietDo__DonHa__3E52440B");

            entity.HasOne(d => d.SanPham).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__ChiTietDo__SanPh__3F466844");
=======
                .HasConstraintName("FK__ChiTietDo__DonHa__5070F446");

            entity.HasOne(d => d.SanPham).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__ChiTietDo__SanPh__5165187F");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3
        });

        modelBuilder.Entity<DanhGium>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.DanhGiaId).HasName("PK__DanhGia__52C0CA25B0C76C09");
=======
            entity.HasKey(e => e.DanhGiaId).HasName("PK__DanhGia__52C0CA256C9735F5");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.Property(e => e.DanhGiaId)
                .ValueGeneratedNever()
                .HasColumnName("DanhGiaID");
            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.KhachHang).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.KhachHangId)
<<<<<<< HEAD
                .HasConstraintName("FK__DanhGia__KhachHa__4BAC3F29");

            entity.HasOne(d => d.SanPham).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__DanhGia__SanPham__4AB81AF0");
=======
                .HasConstraintName("FK__DanhGia__KhachHa__60A75C0F");

            entity.HasOne(d => d.SanPham).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__DanhGia__SanPham__5FB337D6");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.DonHangId).HasName("PK__DonHang__D159F4DEB2F5BBC1");
=======
            entity.HasKey(e => e.DonHangId).HasName("PK__DonHang__D159F4DEA48DB977");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.ToTable("DonHang");

            entity.Property(e => e.DonHangId)
                .ValueGeneratedNever()
                .HasColumnName("DonHangID");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
            entity.Property(e => e.NgayDatHang).HasColumnType("datetime");
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.KhachHang).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.KhachHangId)
<<<<<<< HEAD
                .HasConstraintName("FK__DonHang__KhachHa__3B75D760");
=======
                .HasConstraintName("FK__DonHang__KhachHa__4D94879B");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.HoaDonId).HasName("PK__HoaDon__6956CE69293C857A");
=======
            entity.HasKey(e => e.HoaDonId).HasName("PK__HoaDon__6956CE6959480DCE");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.ToTable("HoaDon");

            entity.Property(e => e.HoaDonId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HoaDonID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.Gmail).HasMaxLength(255);
            entity.Property(e => e.KhachHangId).HasColumnName("KhachHangID");
            entity.Property(e => e.NgayLapHoaDon).HasColumnType("datetime");
            entity.Property(e => e.PhuongThucThanhToanId).HasColumnName("PhuongThucThanhToanID");
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenKhachHang).HasMaxLength(255);
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.KhachHang).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.KhachHangId)
<<<<<<< HEAD
                .HasConstraintName("FK__HoaDon__KhachHan__52593CB8");

            entity.HasOne(d => d.PhuongThucThanhToan).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.PhuongThucThanhToanId)
                .HasConstraintName("FK__HoaDon__PhuongTh__534D60F1");
=======
                .HasConstraintName("FK__HoaDon__KhachHan__6754599E");

            entity.HasOne(d => d.PhuongThucThanhToan).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.PhuongThucThanhToanId)
                .HasConstraintName("FK__HoaDon__PhuongTh__68487DD7");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.HoaDonChiTietId).HasName("PK__HoaDonCh__603A404AF1483BBE");
=======
            entity.HasKey(e => e.HoaDonChiTietId).HasName("PK__HoaDonCh__603A404AFC92E054");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.HoaDonChiTietId).HasColumnName("HoaDonChiTietID");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GiamGia)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HoaDonId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HoaDonID");
            entity.Property(e => e.MaSanPham).HasMaxLength(50);
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.HoaDon).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.HoaDonId)
<<<<<<< HEAD
                .HasConstraintName("FK__HoaDonChi__HoaDo__571DF1D5");

            entity.HasOne(d => d.SanPham).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__HoaDonChi__SanPh__5812160E");
=======
                .HasConstraintName("FK__HoaDonChi__HoaDo__6C190EBB");

            entity.HasOne(d => d.SanPham).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__HoaDonChi__SanPh__6D0D32F4");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.KhachHangId).HasName("PK__KhachHan__880F211BA7AEE458");
=======
            entity.HasKey(e => e.KhachHangId).HasName("PK__KhachHan__880F211B452A0DD2");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.ToTable("KhachHang");

            entity.Property(e => e.KhachHangId)
                .ValueGeneratedNever()
                .HasColumnName("KhachHangID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenKhachHang).HasMaxLength(255);
        });

        modelBuilder.Entity<KhoHang>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.KhoHangId).HasName("PK__KhoHang__652256DE791F13C0");
=======
            entity.HasKey(e => e.KhoHangId).HasName("PK__KhoHang__652256DE4108FDD5");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.ToTable("KhoHang");

            entity.Property(e => e.KhoHangId)
                .ValueGeneratedNever()
                .HasColumnName("KhoHangID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.ViTriKho).HasMaxLength(255);

            entity.HasOne(d => d.SanPham).WithMany(p => p.KhoHangs)
                .HasForeignKey(d => d.SanPhamId)
<<<<<<< HEAD
                .HasConstraintName("FK__KhoHang__SanPham__440B1D61");
=======
                .HasConstraintName("FK__KhoHang__SanPham__5629CD9C");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3
        });

        modelBuilder.Entity<KhuyenMai>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.KhuyenMaiId).HasName("PK__KhuyenMa__820D7477AFF81F50");
=======
            entity.HasKey(e => e.KhuyenMaiId).HasName("PK__KhuyenMa__820D747716B87080");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.ToTable("KhuyenMai");

            entity.Property(e => e.KhuyenMaiId).HasColumnName("KhuyenMaiID");
            entity.Property(e => e.GiamGia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            entity.Property(e => e.TenKhuyenMai).HasMaxLength(255);
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.NguoiDungId).HasName("PK__NguoiDun__C4BBA4DD929DB5A6");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.TenDangNhap, "UQ__NguoiDun__55F68FC09C2D20BE").IsUnique();
=======
            entity.HasKey(e => e.NguoiDungId).HasName("PK__NguoiDun__C4BBA4DDA9DE0B94");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.TenDangNhap, "UQ__NguoiDun__55F68FC058C7FE5A").IsUnique();
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.HasIndex(e => e.Email, "UQ__NguoiDun__A9D10534F66D23E9").IsUnique();

            entity.Property(e => e.NguoiDungId).HasColumnName("NguoiDungID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.MatKhauMaHoa).HasMaxLength(255);
            entity.Property(e => e.TenDangNhap).HasMaxLength(50);
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.NhaCungCapId).HasName("PK__NhaCungC__8B891727010B2FD5");
=======
            entity.HasKey(e => e.NhaCungCapId).HasName("PK__NhaCungC__8B89172777DB940D");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.NhaCungCapId)
                .ValueGeneratedNever()
                .HasColumnName("NhaCungCapID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenNguoiLienHe).HasMaxLength(255);
            entity.Property(e => e.TenNhaCungCap).HasMaxLength(255);
        });

        modelBuilder.Entity<PhuongThucThanhToan>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.PhuongThucThanhToanId).HasName("PK__PhuongTh__333AD28D3AA7BBC7");
=======
            entity.HasKey(e => e.PhuongThucThanhToanId).HasName("PK__PhuongTh__333AD28D09CEEDA5");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.ToTable("PhuongThucThanhToan");

            entity.Property(e => e.PhuongThucThanhToanId)
                .ValueGeneratedNever()
                .HasColumnName("PhuongThucThanhToanID");
            entity.Property(e => e.TenPhuongThuc).HasMaxLength(255);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.SanPhamId).HasName("PK__SanPham__05180FF44FFD7792");
=======
            entity.HasKey(e => e.SanPhamId).HasName("PK__SanPham__05180FF4D840ACC2");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.ToTable("SanPham");

            entity.Property(e => e.SanPhamId)
                .ValueGeneratedNever()
                .HasColumnName("SanPhamID");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KichThuoc).HasMaxLength(50);
            entity.Property(e => e.MauSac).HasMaxLength(50);
            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.TenSanPham).HasMaxLength(255);
            entity.Property(e => e.TenThuongHieu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai).HasMaxLength(30);
        });

        modelBuilder.Entity<SanPhamGiamGium>(entity =>
        {
<<<<<<< HEAD
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPhamG__FAC7442D56D9F76F");
=======
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPhamG__FAC7442DF5561B37");
>>>>>>> b50953e3a273fd36b5338205ab359c70362c7ce3

            entity.Property(e => e.MaSanPham).ValueGeneratedNever();
            entity.Property(e => e.GiaBan).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.GiaGiam)
                .HasComputedColumnSql("([GiaBan]*((1)-[PhanTramGiam]/(100)))", false)
                .HasColumnType("decimal(21, 8)");
            entity.Property(e => e.MoTa).HasMaxLength(1000);
            entity.Property(e => e.PhanTramGiam).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TenSanPham).HasMaxLength(255);
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B11EEAFE295");

            entity.ToTable("Voucher");

            entity.Property(e => e.MaVoucher).ValueGeneratedNever();
            entity.Property(e => e.DieuKienSuDung).HasColumnType("text");
            entity.Property(e => e.GiaTri).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PhanTramGiam).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TenThuongHieu)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TenVoucher)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
