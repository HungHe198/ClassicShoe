using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class ClassicShoeDbContext : DbContext
    {
        public ClassicShoeDbContext()
        {
        }
        public ClassicShoeDbContext(DbContextOptions options) : base(options)
        {
        }



        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LEVANHUNG\\LEVANHUNG;Initial Catalog=ClassicShoe;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            var adminRoleId = Guid.NewGuid();
            var nhanVienRoleId = Guid.NewGuid();

            var loaiGiayId = Guid.NewGuid();
            var hangSanXuatId = Guid.NewGuid();
            var giayId = Guid.NewGuid();
            var deGiay1Id = Guid.NewGuid(); // Replace with the actual ID of DeGiay entry if already seeded
            var deGiay2Id = Guid.NewGuid(); // Replace with the actual ID of DeGiay entry if already seeded
            var thanGiay1Id = Guid.NewGuid(); // Replace with the actual ID of ThanGiay entry if already seeded
            var thanGiay2Id = Guid.NewGuid(); // Replace with the actual ID of ThanGiay entry if already seeded
            var mauSac1Id = Guid.NewGuid(); // Replace with the actual ID of MauSac entry if already seeded
            var mauSac2Id = Guid.NewGuid(); // Replace with the actual ID of MauSac entry if already seeded

            modelBuilder.Entity<VaiTro>().HasData(
                            new VaiTro
                            {
                                Id = adminRoleId,          // Unique identifier for Admin role
                                TenVaiTro = "Admin",          // Role name
                                MaVaiTro = "ADMIN"            // Role code
                            },
                            new VaiTro
                            {
                                Id = nhanVienRoleId,     // Unique identifier for NhanVien role
                                TenVaiTro = "NhanVien",       // Role name
                                MaVaiTro = "NV"               // Role code
                            });
            modelBuilder.Entity<Admin>().HasData(
                            new Admin
                            {
                                Id = Guid.NewGuid(),            // Unique identifier for the first Admin
                                VaiTroId = adminRoleId,         // Linking to the Admin VaiTro
                                TaiKhoan = "admin1",
                                MatKhau = "password1"           // Replace with secure hash in production
                            },
                            new Admin
                            {
                                Id = Guid.NewGuid(),            // Unique identifier for the second Admin
                                VaiTroId = adminRoleId,         // Linking to the Admin VaiTro
                                TaiKhoan = "admin2",
                                MatKhau = "password2"           // Replace with secure hash in production
                            });
            modelBuilder.Entity<NhanVien>().HasData(
                            new NhanVien
                            {
                                Id = Guid.NewGuid(),
                                VaiTroId = nhanVienRoleId,
                                TenNhanVien = "Nguyen Van A",
                                TenTaiKhoan = "nguyenvana",
                                MatKhau = "123456", // Lưu ý: Không lưu mật khẩu dạng plain-text trong thực tế
                                NgaySinh = new DateTime(1990, 1, 1),
                                DiaChi = "123 ABC Street",
                                Email = "nguyenvana@example.com",
                                SoDienThoai = "0901234567"
                            },
                            new NhanVien
                            {
                                Id = Guid.NewGuid(),
                                VaiTroId = nhanVienRoleId,
                                TenNhanVien = "Le Thi B",
                                TenTaiKhoan = "lethib",
                                MatKhau = "abcdef",
                                NgaySinh = new DateTime(1992, 2, 2),
                                DiaChi = "456 XYZ Street",
                                Email = "lethib@example.com",
                                SoDienThoai = "0907654321"
                            });

            modelBuilder.Entity<MauSac>().HasData(
                            new MauSac
                            {
                                Id = mauSac1Id,
                                TenMau = "Đỏ"   // Example color name
                            },
                            new MauSac
                            {
                                Id = mauSac2Id,
                                TenMau = "Xanh" // Example color name
                            });

            modelBuilder.Entity<DeGiay>().HasData(
                            new DeGiay
                            {
                                Id = deGiay1Id,
                                TenDe = "Đế Cao Su",
                                ChatLieu = "Cao su",
                                CongNghe = "Chống trượt",
                                Mota = "Đế cao su bền chắc, khả năng chống trượt tốt"
                            },
                            new DeGiay
                            {
                                Id = deGiay2Id,
                                TenDe = "Đế Nhựa",
                                ChatLieu = "Nhựa",
                                CongNghe = "Chống mài mòn",
                                Mota = "Đế nhựa nhẹ, chịu được mài mòn cao"
                            });
            modelBuilder.Entity<ThanGiay>().HasData(
                            new ThanGiay
                            {
                                Id = thanGiay1Id,
                                Ten = "Thân Giày Da",
                                ChatLieu = "Da thật",
                                ThietKe = "Thời trang cổ điển",
                                MoTa = "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao"
                            },
                            new ThanGiay
                            {
                                Id = thanGiay2Id,
                                Ten = "Thân Giày Vải",
                                ChatLieu = "Vải canvas",
                                ThietKe = "Phong cách trẻ trung",
                                MoTa = "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động"
                            });
            modelBuilder.Entity<LoaiGiay>().HasData(
                            new LoaiGiay
                            {
                                Id = loaiGiayId,
                                TenLoai = "Sneaker",
                                PhongCach = "Thể thao",
                                MoTa = "Giày thể thao, phù hợp với nhiều hoạt động"
                            });
            modelBuilder.Entity<HangSanXuat>().HasData(
                            new HangSanXuat
                            {
                                Id = hangSanXuatId,
                                TenHang = "Nike",
                                Logo = "https://example.com/logo-nike.png",
                                Email = "support@nike.com",
                                DiaChi = "Beaverton, Oregon, USA",
                                DieuKhoan = "https://example.com/terms-nike.pdf"
                            });
            modelBuilder.Entity<Giay>().HasData(
                           new Giay
                           {
                               Id = giayId,
                               LoaiGiayId = loaiGiayId,
                               HangSanXuatId = hangSanXuatId,
                               TrangThai = 1 // 1: còn bán
                           });

            modelBuilder.Entity<GiayChiTiet>().HasData(
                           new GiayChiTiet
                           {
                               Id = Guid.NewGuid(),
                               GiayId = giayId,
                               DeGiayId = deGiay1Id,
                               ThanGiayId = thanGiay1Id,
                               MauSacId = mauSac1Id,
                               TenHang = "Nike Air Max",
                               BaoHang = "Bảo hành 1 năm",
                               NgayNhanKho = DateTime.Now,
                               Gia = 1500000, // Example price
                               SoLuong = 10,
                               TrangThai = 1 // 1: còn bán
                           },
                           new GiayChiTiet
                           {
                               Id = Guid.NewGuid(),
                               GiayId = giayId,
                               DeGiayId = deGiay2Id,
                               ThanGiayId = thanGiay2Id,
                               MauSacId = mauSac2Id,
                               TenHang = "Nike Revolution",
                               BaoHang = "Bảo hành 6 tháng",
                               NgayNhanKho = DateTime.Now,
                               Gia = 1200000, // Example price
                               SoLuong = 15,
                               TrangThai = 1 // 1: còn bán
                           });
            modelBuilder.Entity<KhachHang>().HasData(
                           new KhachHang
                           {
                               Id = Guid.NewGuid(),
                               TenKhachHang = "Tran Thi C",
                               DiemTichLuy = 200,
                               TongChiTieu = 3000000m,
                               SoDienThoai = "0912345678",
                               Email = "tranthic@example.com",
                               NgaySinh = new DateTime(1985, 10, 15),
                               DiaChi = "789 XYZ Street"
                           });
            modelBuilder.Entity<KhachHang>().HasData(
                           new KhachHang
                           {
                               Id = Guid.NewGuid(),
                               TenKhachHang = "Khách lẻ",
                               DiemTichLuy = 200,
                               TongChiTieu = 3000000m,
                               SoDienThoai = "0100000000",
                               Email = "tranthic@example.com",
                               NgaySinh = new DateTime(1985, 10, 15),
                               DiaChi = "789 XYZ Street"
                           });
            var defaultGuid = new Guid("11111111-1111-1111-1111-111111111111");

            modelBuilder.Entity<MaGiamGia>().HasData(
                           new MaGiamGia
                           {
                               Id = defaultGuid, // GUID đặc biệt
                               TenMaGiamGia = "NO_DISCOUNT", // Tên mã giảm giá
                               PhanTramGiam = 0, // Không giảm giá
                               NgayBatDau = DateTime.Now, // Ngày bắt đầu là hiện tại
                               NgayKetThuc = DateTime.Now.AddYears(100), // Hiệu lực rất dài
                               GT_HoaDonToiThieu = 0, // Không yêu cầu giá trị tối thiểu
                               GT_ToiDaGiam = 0, // Không giới hạn giảm
                               MoTa = "Mã giảm giá đặc biệt không áp dụng ưu đãi."
                           });
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<DeGiay> DeGiays { get; set; }
        public DbSet<Giay> Giays { get; set; }
        public DbSet<GiayChiTiet> GiayChiTiets { get; set; }
        public DbSet<HangSanXuat> HangSanXuats { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LoaiGiay> LoaiGiays { get; set; }
        public DbSet<MaGiamGia> MaGiamGias { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ThanGiay> ThanGiays { get; set; }
        public DbSet<VaiTro> VaiTros { get; set; }
    }
}
