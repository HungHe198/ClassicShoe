﻿// <auto-generated />
using System;
using ClassicShoe.DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassicShoe.DATA.Migrations
{
    [DbContext(typeof(ClassicShoeDbContext))]
    [Migration("20241110182655_lan1")]
    partial class lan1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassicShoe.DATA.Models.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VaiTroId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VaiTroId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.DeGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChatLieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CongNghe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenDe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeGiays");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.Giay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HangSanXuatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LoaiGiayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HangSanXuatId");

                    b.HasIndex("LoaiGiayId");

                    b.ToTable("Giays");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.GiayChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BaoHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DeGiayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("GiayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MauSacId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayNhanKho")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ThanGiayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeGiayId");

                    b.HasIndex("GiayId");

                    b.HasIndex("MauSacId");

                    b.HasIndex("ThanGiayId");

                    b.ToTable("GiayChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HangSanXuat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DieuKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HangSanXuats");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KhachHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaGiamGiaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTaoHoaDon")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhuongThucThanhToan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("ThanhTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("KhachHangId");

                    b.HasIndex("MaGiamGiaId");

                    b.HasIndex("NhanVienId");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("GiayChiTietId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HoaDonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GiayChiTietId");

                    b.HasIndex("HoaDonId");

                    b.ToTable("HoaDonChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiemTichLuy")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TongChiTieu")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.LoaiGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhongCach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiGiays");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.MaGiamGia", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GT_HoaDonToiThieu")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GT_ToiDaGiam")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int>("PhanTramGiam")
                        .HasColumnType("int");

                    b.Property<string>("TenMaGiamGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaGiamGias");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenMau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MauSacs");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VaiTroId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VaiTroId");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.ThanGiay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChatLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThietKe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ThanGiays");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.VaiTro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaVaiTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenVaiTro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VaiTros");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.Admin", b =>
                {
                    b.HasOne("ClassicShoe.DATA.Models.VaiTro", "VaiTro")
                        .WithMany("Admins")
                        .HasForeignKey("VaiTroId");

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.Giay", b =>
                {
                    b.HasOne("ClassicShoe.DATA.Models.HangSanXuat", "HangSanXuat")
                        .WithMany("Giays")
                        .HasForeignKey("HangSanXuatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.LoaiGiay", "LoaiGiay")
                        .WithMany("Giays")
                        .HasForeignKey("LoaiGiayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HangSanXuat");

                    b.Navigation("LoaiGiay");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.GiayChiTiet", b =>
                {
                    b.HasOne("ClassicShoe.DATA.Models.DeGiay", "DeGiay")
                        .WithMany("GiayChiTiets")
                        .HasForeignKey("DeGiayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.Giay", "Giay")
                        .WithMany("GiayChiTiets")
                        .HasForeignKey("GiayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.MauSac", "MauSac")
                        .WithMany("GiayChiTiets")
                        .HasForeignKey("MauSacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.ThanGiay", "ThanGiay")
                        .WithMany("GiayChiTiets")
                        .HasForeignKey("ThanGiayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeGiay");

                    b.Navigation("Giay");

                    b.Navigation("MauSac");

                    b.Navigation("ThanGiay");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HoaDon", b =>
                {
                    b.HasOne("ClassicShoe.DATA.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.MaGiamGia", "MaGiamGia")
                        .WithMany()
                        .HasForeignKey("MaGiamGiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("MaGiamGia");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("ClassicShoe.DATA.Models.GiayChiTiet", "GiayChiTiet")
                        .WithMany()
                        .HasForeignKey("GiayChiTietId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassicShoe.DATA.Models.HoaDon", "HoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("HoaDonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GiayChiTiet");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.NhanVien", b =>
                {
                    b.HasOne("ClassicShoe.DATA.Models.VaiTro", "VaiTro")
                        .WithMany("NhanViens")
                        .HasForeignKey("VaiTroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.DeGiay", b =>
                {
                    b.Navigation("GiayChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.Giay", b =>
                {
                    b.Navigation("GiayChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HangSanXuat", b =>
                {
                    b.Navigation("Giays");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.LoaiGiay", b =>
                {
                    b.Navigation("Giays");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.MauSac", b =>
                {
                    b.Navigation("GiayChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.ThanGiay", b =>
                {
                    b.Navigation("GiayChiTiets");
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.VaiTro", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("NhanViens");
                });
#pragma warning restore 612, 618
        }
    }
}
