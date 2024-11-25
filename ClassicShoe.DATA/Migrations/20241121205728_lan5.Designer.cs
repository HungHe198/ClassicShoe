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
    [Migration("20241121205728_lan5")]
    partial class lan5
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
                            Id = new Guid("d6f1d5a5-bac4-4469-87f7-8cd1ade43346"),
                            MatKhau = "password1",
                            TaiKhoan = "admin1",
                            VaiTroId = new Guid("7f8c33a4-42cd-4976-ae3e-80c6d2c78983")
                        },
                        new
                        {
                            Id = new Guid("8f04fb60-97a2-44f4-aa7e-b326a130f9e9"),
                            MatKhau = "password2",
                            TaiKhoan = "admin2",
                            VaiTroId = new Guid("7f8c33a4-42cd-4976-ae3e-80c6d2c78983")
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
                            Id = new Guid("ff7e3ea5-75de-4c81-b2ef-fe8172aacff9"),
                            ChatLieu = "Cao su",
                            CongNghe = "Chống trượt",
                            Mota = "Đế cao su bền chắc, khả năng chống trượt tốt",
                            TenDe = "Đế Cao Su"
                        },
                        new
                        {
                            Id = new Guid("93ddfc26-fd27-41cb-9612-43145b2f5416"),
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
                            Id = new Guid("e8a84f1d-0a2c-48a5-81eb-d58466e730cf"),
                            HangSanXuatId = new Guid("47e63190-4788-4e29-9a57-1d5a9f6d23ea"),
                            LoaiGiayId = new Guid("7a337aac-5516-41d2-bf7c-98c69692c975"),
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
                            Id = new Guid("702b0567-8164-4b2a-9806-86d4508a1b1b"),
                            BaoHang = "Bảo hành 1 năm",
                            DeGiayId = new Guid("ff7e3ea5-75de-4c81-b2ef-fe8172aacff9"),
                            Gia = 1500000m,
                            GiayId = new Guid("e8a84f1d-0a2c-48a5-81eb-d58466e730cf"),
                            MauSacId = new Guid("6c930b46-cecb-44bf-a77d-e8529c1517a7"),
                            NgayNhanKho = new DateTime(2024, 11, 22, 3, 57, 28, 581, DateTimeKind.Local).AddTicks(6202),
                            SoLuong = 10,
                            TenHang = "Nike Air Max",
                            ThanGiayId = new Guid("b9930b8c-e890-40ee-b6f6-20c0d4cda646"),
                            TrangThai = 1
                        },
                        new
                        {
                            Id = new Guid("5a7cf51d-5a74-4c37-a353-aca5a7673c36"),
                            BaoHang = "Bảo hành 6 tháng",
                            DeGiayId = new Guid("93ddfc26-fd27-41cb-9612-43145b2f5416"),
                            Gia = 1200000m,
                            GiayId = new Guid("e8a84f1d-0a2c-48a5-81eb-d58466e730cf"),
                            MauSacId = new Guid("e054b54d-b509-4019-ade2-916e5e51bb11"),
                            NgayNhanKho = new DateTime(2024, 11, 22, 3, 57, 28, 581, DateTimeKind.Local).AddTicks(6216),
                            SoLuong = 15,
                            TenHang = "Nike Revolution",
                            ThanGiayId = new Guid("6505444c-ab63-42a2-b00b-a68d774a1a8e"),
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
                            Id = new Guid("47e63190-4788-4e29-9a57-1d5a9f6d23ea"),
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
                            Id = new Guid("5f36bf8b-4c6e-41e4-8d3f-42babda2faf4"),
                            DiaChi = "789 XYZ Street",
                            DiemTichLuy = 200,
                            Email = "tranthic@example.com",
                            NgaySinh = new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "0912345678",
                            TenKhachHang = "Tran Thi C",
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
                            Id = new Guid("7a337aac-5516-41d2-bf7c-98c69692c975"),
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
                            NgayBatDau = new DateTime(2024, 11, 22, 3, 57, 28, 581, DateTimeKind.Local).AddTicks(6261),
                            NgayKetThuc = new DateTime(2124, 11, 22, 3, 57, 28, 581, DateTimeKind.Local).AddTicks(6262),
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
                            Id = new Guid("6c930b46-cecb-44bf-a77d-e8529c1517a7"),
                            TenMau = "Đỏ"
                        },
                        new
                        {
                            Id = new Guid("e054b54d-b509-4019-ade2-916e5e51bb11"),
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
                            Id = new Guid("7b9df3b1-d66a-4a90-ae00-a5861c09d32d"),
                            DiaChi = "123 ABC Street",
                            Email = "nguyenvana@example.com",
                            MatKhau = "123456",
                            NgaySinh = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "0901234567",
                            TenNhanVien = "Nguyen Van A",
                            TenTaiKhoan = "nguyenvana",
                            VaiTroId = new Guid("58504573-a740-48b3-b378-d830deea3351")
                        },
                        new
                        {
                            Id = new Guid("b51f3491-ce4b-4a9c-aaa8-2e1a0176eca8"),
                            DiaChi = "456 XYZ Street",
                            Email = "lethib@example.com",
                            MatKhau = "abcdef",
                            NgaySinh = new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "0907654321",
                            TenNhanVien = "Le Thi B",
                            TenTaiKhoan = "lethib",
                            VaiTroId = new Guid("58504573-a740-48b3-b378-d830deea3351")
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
                            Id = new Guid("b9930b8c-e890-40ee-b6f6-20c0d4cda646"),
                            ChatLieu = "Da thật",
                            MoTa = "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao",
                            Ten = "Thân Giày Da",
                            ThietKe = "Thời trang cổ điển"
                        },
                        new
                        {
                            Id = new Guid("6505444c-ab63-42a2-b00b-a68d774a1a8e"),
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
                            Id = new Guid("7f8c33a4-42cd-4976-ae3e-80c6d2c78983"),
                            MaVaiTro = "ADMIN",
                            TenVaiTro = "Admin"
                        },
                        new
                        {
                            Id = new Guid("58504573-a740-48b3-b378-d830deea3351"),
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
                    b.HasOne("ClassicShoe.DATA.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangId");

                    b.HasOne("ClassicShoe.DATA.Models.MaGiamGia", "MaGiamGia")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaGiamGiaId");

                    b.HasOne("ClassicShoe.DATA.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("NhanVienId");

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