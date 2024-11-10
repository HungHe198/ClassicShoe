using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassicShoe.DATA.Migrations
{
    /// <inheritdoc />
    public partial class lan3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("11d88519-289f-4f1f-a501-96b630a41d6a"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" },
                    { new Guid("71df5374-1ca3-46ca-bda5-d91d13974401"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("4dcc9491-279c-4d5a-8464-161d43ae96c0"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("c25a5d64-fd4c-45e3-b691-4051ed93e54d"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("297fe4a4-bccb-4b71-93fe-5cfc1a4a3e4c"), "Đỏ" },
                    { new Guid("427144dd-5a2c-40f3-b8ba-c2f4d4ba00c9"), "Xanh" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("5be9868e-7de5-49e8-b9c6-feaa8c269521"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" },
                    { new Guid("cb582836-e535-4e61-8ebe-71a792b63071"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("0a6af27f-e02c-4f5d-a05e-dc15e7fe460f"), "ADMIN", "Admin" },
                    { new Guid("bcbe5fe2-ef4b-4f05-9d58-7ce5a844092a"), "NV", "NhanVien" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("5ba27202-81e5-4b97-9359-53b60ff7b7e4"), "password1", "admin1", new Guid("0a6af27f-e02c-4f5d-a05e-dc15e7fe460f") },
                    { new Guid("b5ff59c8-4421-4203-81e1-afc989cdda76"), "password2", "admin2", new Guid("0a6af27f-e02c-4f5d-a05e-dc15e7fe460f") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("56be55ef-5ec3-4cb4-995f-58e7385da5fc"), new Guid("4dcc9491-279c-4d5a-8464-161d43ae96c0"), new Guid("c25a5d64-fd4c-45e3-b691-4051ed93e54d"), 1 });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("a72e170c-f12d-42f7-8984-08b06a4062ad"), "Bảo hành 1 năm", new Guid("71df5374-1ca3-46ca-bda5-d91d13974401"), 1500000m, new Guid("56be55ef-5ec3-4cb4-995f-58e7385da5fc"), new Guid("297fe4a4-bccb-4b71-93fe-5cfc1a4a3e4c"), new DateTime(2024, 11, 11, 6, 13, 6, 0, DateTimeKind.Local).AddTicks(8545), 10, "Nike Air Max", new Guid("5be9868e-7de5-49e8-b9c6-feaa8c269521"), 1 },
                    { new Guid("e1063b66-217b-4d1e-ab71-12fc81826063"), "Bảo hành 6 tháng", new Guid("11d88519-289f-4f1f-a501-96b630a41d6a"), 1200000m, new Guid("56be55ef-5ec3-4cb4-995f-58e7385da5fc"), new Guid("427144dd-5a2c-40f3-b8ba-c2f4d4ba00c9"), new DateTime(2024, 11, 11, 6, 13, 6, 0, DateTimeKind.Local).AddTicks(8566), 15, "Nike Revolution", new Guid("cb582836-e535-4e61-8ebe-71a792b63071"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("5ba27202-81e5-4b97-9359-53b60ff7b7e4"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b5ff59c8-4421-4203-81e1-afc989cdda76"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("a72e170c-f12d-42f7-8984-08b06a4062ad"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("e1063b66-217b-4d1e-ab71-12fc81826063"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("bcbe5fe2-ef4b-4f05-9d58-7ce5a844092a"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("11d88519-289f-4f1f-a501-96b630a41d6a"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("71df5374-1ca3-46ca-bda5-d91d13974401"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("56be55ef-5ec3-4cb4-995f-58e7385da5fc"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("297fe4a4-bccb-4b71-93fe-5cfc1a4a3e4c"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("427144dd-5a2c-40f3-b8ba-c2f4d4ba00c9"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("5be9868e-7de5-49e8-b9c6-feaa8c269521"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("cb582836-e535-4e61-8ebe-71a792b63071"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("0a6af27f-e02c-4f5d-a05e-dc15e7fe460f"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("4dcc9491-279c-4d5a-8464-161d43ae96c0"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("c25a5d64-fd4c-45e3-b691-4051ed93e54d"));
        }
    }
}
