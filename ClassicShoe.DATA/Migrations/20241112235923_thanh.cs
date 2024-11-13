using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassicShoe.DATA.Migrations
{
    /// <inheritdoc />
    public partial class thanh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("14cdcffb-8b43-4708-9e0e-11d6707ff9a8"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("28f6843c-9bf4-4382-9fb1-e331a5200810"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("36a273c6-e324-4299-acba-f5b7d528297b"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("45b6d1b7-0556-4b42-b3a7-691b53fec63b"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("d90328b0-9c4d-481c-966d-eab7c3bef05d"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("41457787-a14f-4a8a-8c89-07db6b55b0e6"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("e3300af7-bca6-423c-8a4b-41335fec903e"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("2258f7ac-fd67-46ea-8c17-5e6155065eeb"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("cbdd1e82-ffff-4b71-a1bb-e3c24b7dddf1"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("f3361cb7-6371-4c02-8261-32a85a622ebb"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("1fc4cc1c-e35d-46d9-8182-72d7784a9bcf"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("b78e58fa-450d-4bef-8533-d7b94e3e2c5a"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("e0e82ba0-b80b-4bf5-937b-8312601ef8e8"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("e68a8ddc-6c00-48f9-9e08-2d2ec6b99af4"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("5533ff3d-5c0b-4634-ba29-9bcadab2d528"));

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("30b0c30e-2e1c-4e74-abb4-f0a384b10d63"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" },
                    { new Guid("4bd1144f-9b26-4edb-b1d4-ab56744dd3d6"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("b419a7ab-2c29-48a6-b9bb-f2a19791bb6d"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("034ab49a-5a30-4c19-bffe-450c994002c0"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("9ec7286c-1a10-4906-9cf6-98535dac9ef9"), "Đỏ" },
                    { new Guid("bc45a606-79d9-492c-81c8-ec80441bb0a0"), "Xanh" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("02a3f4c4-ea86-482f-a8f9-0f89fa46b9f4"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" },
                    { new Guid("f3c87f77-51b6-4a64-9601-091a90fabb40"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("687be20a-856e-4b34-a10e-2daf03cfb6f9"), "NV", "NhanVien" },
                    { new Guid("c249bbb2-d1d7-4672-ab49-725c54f1a66d"), "ADMIN", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("10c899eb-26ac-42a3-b939-0e878ecd9963"), "password1", "admin1", new Guid("c249bbb2-d1d7-4672-ab49-725c54f1a66d") },
                    { new Guid("3b6cc382-a072-4472-b1dd-4af02bb2a52d"), "password2", "admin2", new Guid("c249bbb2-d1d7-4672-ab49-725c54f1a66d") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("0fd1ff27-d052-4b00-ba9b-6d8f94765345"), new Guid("b419a7ab-2c29-48a6-b9bb-f2a19791bb6d"), new Guid("034ab49a-5a30-4c19-bffe-450c994002c0"), 1 });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("0b6869f2-68e3-4888-9cb7-c9dcc03f0bc8"), "Bảo hành 1 năm", new Guid("30b0c30e-2e1c-4e74-abb4-f0a384b10d63"), 1500000m, new Guid("0fd1ff27-d052-4b00-ba9b-6d8f94765345"), new Guid("9ec7286c-1a10-4906-9cf6-98535dac9ef9"), new DateTime(2024, 11, 13, 6, 59, 23, 0, DateTimeKind.Local).AddTicks(9204), 10, "Nike Air Max", new Guid("f3c87f77-51b6-4a64-9601-091a90fabb40"), 1 },
                    { new Guid("950c75c9-cd32-4784-9a95-8d5f3d403070"), "Bảo hành 6 tháng", new Guid("4bd1144f-9b26-4edb-b1d4-ab56744dd3d6"), 1200000m, new Guid("0fd1ff27-d052-4b00-ba9b-6d8f94765345"), new Guid("bc45a606-79d9-492c-81c8-ec80441bb0a0"), new DateTime(2024, 11, 13, 6, 59, 23, 0, DateTimeKind.Local).AddTicks(9231), 15, "Nike Revolution", new Guid("02a3f4c4-ea86-482f-a8f9-0f89fa46b9f4"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("10c899eb-26ac-42a3-b939-0e878ecd9963"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("3b6cc382-a072-4472-b1dd-4af02bb2a52d"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("0b6869f2-68e3-4888-9cb7-c9dcc03f0bc8"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("950c75c9-cd32-4784-9a95-8d5f3d403070"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("687be20a-856e-4b34-a10e-2daf03cfb6f9"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("30b0c30e-2e1c-4e74-abb4-f0a384b10d63"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("4bd1144f-9b26-4edb-b1d4-ab56744dd3d6"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("0fd1ff27-d052-4b00-ba9b-6d8f94765345"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("9ec7286c-1a10-4906-9cf6-98535dac9ef9"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("bc45a606-79d9-492c-81c8-ec80441bb0a0"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("02a3f4c4-ea86-482f-a8f9-0f89fa46b9f4"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("f3c87f77-51b6-4a64-9601-091a90fabb40"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("c249bbb2-d1d7-4672-ab49-725c54f1a66d"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("b419a7ab-2c29-48a6-b9bb-f2a19791bb6d"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("034ab49a-5a30-4c19-bffe-450c994002c0"));

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("41457787-a14f-4a8a-8c89-07db6b55b0e6"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" },
                    { new Guid("e3300af7-bca6-423c-8a4b-41335fec903e"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("e68a8ddc-6c00-48f9-9e08-2d2ec6b99af4"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("5533ff3d-5c0b-4634-ba29-9bcadab2d528"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("cbdd1e82-ffff-4b71-a1bb-e3c24b7dddf1"), "Đỏ" },
                    { new Guid("f3361cb7-6371-4c02-8261-32a85a622ebb"), "Xanh" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("1fc4cc1c-e35d-46d9-8182-72d7784a9bcf"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" },
                    { new Guid("b78e58fa-450d-4bef-8533-d7b94e3e2c5a"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("d90328b0-9c4d-481c-966d-eab7c3bef05d"), "NV", "NhanVien" },
                    { new Guid("e0e82ba0-b80b-4bf5-937b-8312601ef8e8"), "ADMIN", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("14cdcffb-8b43-4708-9e0e-11d6707ff9a8"), "password2", "admin2", new Guid("e0e82ba0-b80b-4bf5-937b-8312601ef8e8") },
                    { new Guid("28f6843c-9bf4-4382-9fb1-e331a5200810"), "password1", "admin1", new Guid("e0e82ba0-b80b-4bf5-937b-8312601ef8e8") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("2258f7ac-fd67-46ea-8c17-5e6155065eeb"), new Guid("e68a8ddc-6c00-48f9-9e08-2d2ec6b99af4"), new Guid("5533ff3d-5c0b-4634-ba29-9bcadab2d528"), 1 });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("36a273c6-e324-4299-acba-f5b7d528297b"), "Bảo hành 1 năm", new Guid("e3300af7-bca6-423c-8a4b-41335fec903e"), 1500000m, new Guid("2258f7ac-fd67-46ea-8c17-5e6155065eeb"), new Guid("cbdd1e82-ffff-4b71-a1bb-e3c24b7dddf1"), new DateTime(2024, 11, 13, 6, 54, 40, 325, DateTimeKind.Local).AddTicks(7219), 10, "Nike Air Max", new Guid("b78e58fa-450d-4bef-8533-d7b94e3e2c5a"), 1 },
                    { new Guid("45b6d1b7-0556-4b42-b3a7-691b53fec63b"), "Bảo hành 6 tháng", new Guid("41457787-a14f-4a8a-8c89-07db6b55b0e6"), 1200000m, new Guid("2258f7ac-fd67-46ea-8c17-5e6155065eeb"), new Guid("f3361cb7-6371-4c02-8261-32a85a622ebb"), new DateTime(2024, 11, 13, 6, 54, 40, 325, DateTimeKind.Local).AddTicks(7235), 15, "Nike Revolution", new Guid("1fc4cc1c-e35d-46d9-8182-72d7784a9bcf"), 1 }
                });
        }
    }
}
