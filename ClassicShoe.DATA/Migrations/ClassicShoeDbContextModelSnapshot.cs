﻿// <auto-generated />
using System;
using ClassicShoe.DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassicShoe.DATA.Migrations
{
    [DbContext(typeof(ClassicShoeDbContext))]
    partial class ClassicShoeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("9992b3b8-1492-4488-ac1b-24f6d0320d10"),
                            MatKhau = "password1",
                            TaiKhoan = "admin1",
                            VaiTroId = new Guid("bab812fb-950f-46e6-8da6-e127ff2fed6b")
                        },
                        new
                        {
                            Id = new Guid("260df27a-46c9-4242-80b2-574484fdc9bf"),
                            MatKhau = "password2",
                            TaiKhoan = "admin2",
                            VaiTroId = new Guid("bab812fb-950f-46e6-8da6-e127ff2fed6b")
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
                            Id = new Guid("0b8953df-9c12-4f88-982b-595d55524d85"),
                            ChatLieu = "Cao su",
                            CongNghe = "Chống trượt",
                            Mota = "Đế cao su bền chắc, khả năng chống trượt tốt",
                            TenDe = "Đế Cao Su"
                        },
                        new
                        {
                            Id = new Guid("74d36fe4-f3ca-4b46-a8b0-7d9030275f62"),
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
                            Id = new Guid("71d29234-f097-40c7-8a19-f0b0808b0eb8"),
                            HangSanXuatId = new Guid("0a812994-d06a-4fa6-95cd-d14e11883f80"),
                            LoaiGiayId = new Guid("f2e60b61-ed7a-401b-9d27-f938a99eddb5"),
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
                            Id = new Guid("0706d460-145d-49cb-a16b-5d733b025ce1"),
                            BaoHang = "Bảo hành 1 năm",
                            DeGiayId = new Guid("0b8953df-9c12-4f88-982b-595d55524d85"),
                            Gia = 1500000m,
                            GiayId = new Guid("71d29234-f097-40c7-8a19-f0b0808b0eb8"),
                            MauSacId = new Guid("fda2ab3c-6e5a-4ea9-b342-4304700f859b"),
                            NgayNhanKho = new DateTime(2024, 11, 18, 13, 0, 38, 527, DateTimeKind.Local).AddTicks(638),
                            SoLuong = 10,
                            TenHang = "Nike Air Max",
                            ThanGiayId = new Guid("8dba1648-5d2b-4ddf-9b6e-2dbf92d7cc0e"),
                            TrangThai = 1
                        },
                        new
                        {
                            Id = new Guid("1a677749-771d-4e29-bed0-1d89f4edb2c0"),
                            BaoHang = "Bảo hành 6 tháng",
                            DeGiayId = new Guid("74d36fe4-f3ca-4b46-a8b0-7d9030275f62"),
                            Gia = 1200000m,
                            GiayId = new Guid("71d29234-f097-40c7-8a19-f0b0808b0eb8"),
                            MauSacId = new Guid("e760acff-fbb4-4fbb-b256-06873bcf8106"),
                            NgayNhanKho = new DateTime(2024, 11, 18, 13, 0, 38, 527, DateTimeKind.Local).AddTicks(672),
                            SoLuong = 15,
                            TenHang = "Nike Revolution",
                            ThanGiayId = new Guid("b1eb7371-cb61-4577-b6ba-8b1c0cbf3fec"),
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
                            Id = new Guid("0a812994-d06a-4fa6-95cd-d14e11883f80"),
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.HasData(
                        new
                        {
                            Id = new Guid("0beef5c6-997e-4eb4-890d-55bcf95367bc"),
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
                            Id = new Guid("f2e60b61-ed7a-401b-9d27-f938a99eddb5"),
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
                            Id = new Guid("fda2ab3c-6e5a-4ea9-b342-4304700f859b"),
                            TenMau = "Đỏ"
                        },
                        new
                        {
                            Id = new Guid("e760acff-fbb4-4fbb-b256-06873bcf8106"),
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
                            Id = new Guid("ad60635e-acdf-4318-bccc-e023ecbe8de8"),
                            DiaChi = "123 ABC Street",
                            Email = "nguyenvana@example.com",
                            MatKhau = "123456",
                            NgaySinh = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "0901234567",
                            TenNhanVien = "Nguyen Van A",
                            TenTaiKhoan = "nguyenvana",
                            VaiTroId = new Guid("623000f3-c0de-4eec-a8a2-6609e8a96d6d")
                        },
                        new
                        {
                            Id = new Guid("6af142c8-da9a-4868-92c9-d6ac3dc46a26"),
                            DiaChi = "456 XYZ Street",
                            Email = "lethib@example.com",
                            MatKhau = "abcdef",
                            NgaySinh = new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SoDienThoai = "0907654321",
                            TenNhanVien = "Le Thi B",
                            TenTaiKhoan = "lethib",
                            VaiTroId = new Guid("623000f3-c0de-4eec-a8a2-6609e8a96d6d")
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
                            Id = new Guid("8dba1648-5d2b-4ddf-9b6e-2dbf92d7cc0e"),
                            ChatLieu = "Da thật",
                            MoTa = "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao",
                            Ten = "Thân Giày Da",
                            ThietKe = "Thời trang cổ điển"
                        },
                        new
                        {
                            Id = new Guid("b1eb7371-cb61-4577-b6ba-8b1c0cbf3fec"),
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
                            Id = new Guid("bab812fb-950f-46e6-8da6-e127ff2fed6b"),
                            MaVaiTro = "ADMIN",
                            TenVaiTro = "Admin"
                        },
                        new
                        {
                            Id = new Guid("623000f3-c0de-4eec-a8a2-6609e8a96d6d"),
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
