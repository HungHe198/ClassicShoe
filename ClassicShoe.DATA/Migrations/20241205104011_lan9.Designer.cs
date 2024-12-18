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
    [Migration("20241205104011_lan9")]
    partial class lan9
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("fc0a6b18-24de-4603-bb2d-e80d642ca74c"),
                            MatKhau = "password1",
                            TaiKhoan = "admin1",
                            VaiTroId = new Guid("1a4b427d-63e7-4aea-bad5-864a05a321a9")
                        },
                        new
                        {
                            Id = new Guid("e39bb14f-ec88-4f31-ad74-b70dbf970440"),
                            MatKhau = "password2",
                            TaiKhoan = "admin2",
                            VaiTroId = new Guid("1a4b427d-63e7-4aea-bad5-864a05a321a9")
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("0b7a52b2-8f6a-46a7-ac46-f1b50375c978"),
                            ChatLieu = "Cao su",
                            CongNghe = "Chống trượt",
                            Mota = "Đế cao su bền chắc, khả năng chống trượt tốt",
                            TenDe = "Đế Cao Su"
                        },
                        new
                        {
                            Id = new Guid("747b7674-c438-4ad7-98f1-e909424288da"),
                            ChatLieu = "Nhựa",
                            CongNghe = "Chống mài mòn",
                            Mota = "Đế nhựa nhẹ, chịu được mài mòn cao",
                            TenDe = "Đế Nhựa"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("32b56b4b-cd86-4aed-85b6-2d4c083b2329"),
                            HangSanXuatId = new Guid("f2b23e0f-8555-4b38-8cbd-6819e9073e3b"),
                            LoaiGiayId = new Guid("3c9122fc-b5a7-4f7d-9922-71a5931aaabf"),
                            TrangThai = 1
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("8893f0e1-1532-474e-b719-3c6b7aa7302c"),
                            BaoHang = "Bảo hành 1 năm",
                            DeGiayId = new Guid("0b7a52b2-8f6a-46a7-ac46-f1b50375c978"),
                            Gia = 1500000m,
                            GiayId = new Guid("32b56b4b-cd86-4aed-85b6-2d4c083b2329"),
                            MauSacId = new Guid("576d00d5-d75b-49ec-b0c1-60cae747aee1"),
                            NgayNhanKho = new DateTime(2024, 12, 5, 17, 40, 11, 6, DateTimeKind.Local).AddTicks(5777),
                            SoLuong = 10,
                            TenHang = "Nike Air Max",
                            ThanGiayId = new Guid("f39b3796-9fc1-4650-bd89-b228f1dd6d0e"),
                            TrangThai = 1
                        },
                        new
                        {
                            Id = new Guid("c8efd32b-986f-4903-a770-8ede8e39e747"),
                            BaoHang = "Bảo hành 6 tháng",
                            DeGiayId = new Guid("747b7674-c438-4ad7-98f1-e909424288da"),
                            Gia = 1200000m,
                            GiayId = new Guid("32b56b4b-cd86-4aed-85b6-2d4c083b2329"),
                            MauSacId = new Guid("82b19c92-07b2-4b47-ae4c-81be4395baa0"),
                            NgayNhanKho = new DateTime(2024, 12, 5, 17, 40, 11, 6, DateTimeKind.Local).AddTicks(5793),
                            SoLuong = 15,
                            TenHang = "Nike Revolution",
                            ThanGiayId = new Guid("91d586b6-b936-44d9-8a93-005fc7a1a5a8"),
                            TrangThai = 1
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("f2b23e0f-8555-4b38-8cbd-6819e9073e3b"),
                            DiaChi = "Beaverton, Oregon, USA",
                            DieuKhoan = "https://example.com/terms-nike.pdf",
                            Email = "support@nike.com",
                            Logo = "https://example.com/logo-nike.png",
                            TenHang = "Nike"
                        });
                });

            modelBuilder.Entity("ClassicShoe.DATA.Models.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InvoiceCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("KhachHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MaGiamGiaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayTaoHoaDon")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("NhanVienId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhuongThucThanhToan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<decimal?>("ThanhTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

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

                    b.HasData(
                        new
                        {
                            Id = new Guid("5de6775f-c506-428c-9186-87729055c9db"),
                            DiaChi = "789 XYZ Street",
                            DiemTichLuy = 200,
                            Email = "tranthic@example.com",
                            NgaySinh = new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "0912345678",
                            TenKhachHang = "Tran Thi C",
                            TongChiTieu = 3000000m
                        },
                        new
                        {
                            Id = new Guid("9761154f-19e3-47f0-bf11-ea3ba51ff9e4"),
                            DiaChi = "789 XYZ Street",
                            DiemTichLuy = 200,
                            Email = "tranthic@example.com",
                            NgaySinh = new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "0100000000",
                            TenKhachHang = "Khách lẻ",
                            TongChiTieu = 3000000m
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("3c9122fc-b5a7-4f7d-9922-71a5931aaabf"),
                            MoTa = "Giày thể thao, phù hợp với nhiều hoạt động",
                            PhongCach = "Thể thao",
                            TenLoai = "Sneaker"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("11111111-1111-1111-1111-111111111111"),
                            GT_HoaDonToiThieu = 0m,
                            GT_ToiDaGiam = 0m,
                            MoTa = "Mã giảm giá đặc biệt không áp dụng ưu đãi.",
                            NgayBatDau = new DateTime(2024, 12, 5, 17, 40, 11, 6, DateTimeKind.Local).AddTicks(5850),
                            NgayKetThuc = new DateTime(2124, 12, 5, 17, 40, 11, 6, DateTimeKind.Local).AddTicks(5851),
                            PhanTramGiam = 0,
                            TenMaGiamGia = "NO_DISCOUNT"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("576d00d5-d75b-49ec-b0c1-60cae747aee1"),
                            TenMau = "Đỏ"
                        },
                        new
                        {
                            Id = new Guid("82b19c92-07b2-4b47-ae4c-81be4395baa0"),
                            TenMau = "Xanh"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("91223f56-f89c-4953-aa2d-43fbc66588c8"),
                            DiaChi = "123 ABC Street",
                            Email = "nguyenvana@example.com",
                            MatKhau = "123456",
                            NgaySinh = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "0901234567",
                            TenNhanVien = "Nguyen Van A",
                            TenTaiKhoan = "nguyenvana",
                            VaiTroId = new Guid("a91fa6e1-85dc-4f4a-b4f9-32d9a0849b87")
                        },
                        new
                        {
                            Id = new Guid("50108123-b9fc-4cec-84ac-e758f29014c6"),
                            DiaChi = "456 XYZ Street",
                            Email = "lethib@example.com",
                            MatKhau = "abcdef",
                            NgaySinh = new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "0907654321",
                            TenNhanVien = "Le Thi B",
                            TenTaiKhoan = "lethib",
                            VaiTroId = new Guid("a91fa6e1-85dc-4f4a-b4f9-32d9a0849b87")
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("f39b3796-9fc1-4650-bd89-b228f1dd6d0e"),
                            ChatLieu = "Da thật",
                            MoTa = "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao",
                            Ten = "Thân Giày Da",
                            ThietKe = "Thời trang cổ điển"
                        },
                        new
                        {
                            Id = new Guid("91d586b6-b936-44d9-8a93-005fc7a1a5a8"),
                            ChatLieu = "Vải canvas",
                            MoTa = "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động",
                            Ten = "Thân Giày Vải",
                            ThietKe = "Phong cách trẻ trung"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a4b427d-63e7-4aea-bad5-864a05a321a9"),
                            MaVaiTro = "ADMIN",
                            TenVaiTro = "Admin"
                        },
                        new
                        {
                            Id = new Guid("a91fa6e1-85dc-4f4a-b4f9-32d9a0849b87"),
                            MaVaiTro = "NV",
                            TenVaiTro = "NhanVien"
                        });
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
                    b.HasOne("ClassicShoe.DATA.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId");

                    b.HasOne("ClassicShoe.DATA.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangId");

                    b.HasOne("ClassicShoe.DATA.Models.MaGiamGia", "MaGiamGia")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaGiamGiaId");

                    b.HasOne("ClassicShoe.DATA.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("NhanVienId");

                    b.Navigation("Admin");

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

            modelBuilder.Entity("ClassicShoe.DATA.Models.MaGiamGia", b =>
                {
                    b.Navigation("HoaDons");
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
