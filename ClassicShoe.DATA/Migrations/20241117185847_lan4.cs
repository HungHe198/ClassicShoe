using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassicShoe.DATA.Migrations
{
    /// <inheritdoc />
    public partial class lan4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "InvoiceCode",
                table: "HoaDons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("3456a830-8a54-4e3c-b483-60ef563242fb"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" },
                    { new Guid("8d408e32-6ed3-4b01-9175-db54a21ec6ea"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("76fa51b1-2ba9-4759-b110-f071346de434"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("fa752b9c-8e03-4180-a214-0ba8ddd8190b"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("73ad2f8e-417d-4a6e-8eb1-7fef399da319"), "Đỏ" },
                    { new Guid("eec9c9ed-7e7c-439b-a214-1f66583054ca"), "Xanh" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("b7aabb9b-1e8d-4b5b-a0bb-fb425ce61956"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" },
                    { new Guid("e64870c2-d1c0-4b18-81be-995a0d658075"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("19fedd88-3f19-410b-b767-b551236df2ef"), "NV", "NhanVien" },
                    { new Guid("8d08c6be-ba01-4403-b426-de40f3a0a679"), "ADMIN", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("d109f9b5-62cc-4d70-a99c-2753c1cfd4e6"), "password1", "admin1", new Guid("8d08c6be-ba01-4403-b426-de40f3a0a679") },
                    { new Guid("ee80691f-50e5-4200-b5e5-9bb3d685be70"), "password2", "admin2", new Guid("8d08c6be-ba01-4403-b426-de40f3a0a679") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("d7a2c987-f494-4a83-9552-7a10f616e9ae"), new Guid("76fa51b1-2ba9-4759-b110-f071346de434"), new Guid("fa752b9c-8e03-4180-a214-0ba8ddd8190b"), 1 });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("2286c4da-8678-49ce-a8c7-dd03cf4629ea"), "Bảo hành 6 tháng", new Guid("8d408e32-6ed3-4b01-9175-db54a21ec6ea"), 1200000m, new Guid("d7a2c987-f494-4a83-9552-7a10f616e9ae"), new Guid("eec9c9ed-7e7c-439b-a214-1f66583054ca"), new DateTime(2024, 11, 18, 1, 58, 47, 177, DateTimeKind.Local).AddTicks(336), 15, "Nike Revolution", new Guid("e64870c2-d1c0-4b18-81be-995a0d658075"), 1 },
                    { new Guid("e736e48b-6c61-49e9-ac95-d9b83f4ddf09"), "Bảo hành 1 năm", new Guid("3456a830-8a54-4e3c-b483-60ef563242fb"), 1500000m, new Guid("d7a2c987-f494-4a83-9552-7a10f616e9ae"), new Guid("73ad2f8e-417d-4a6e-8eb1-7fef399da319"), new DateTime(2024, 11, 18, 1, 58, 47, 177, DateTimeKind.Local).AddTicks(315), 10, "Nike Air Max", new Guid("b7aabb9b-1e8d-4b5b-a0bb-fb425ce61956"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("d109f9b5-62cc-4d70-a99c-2753c1cfd4e6"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ee80691f-50e5-4200-b5e5-9bb3d685be70"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("2286c4da-8678-49ce-a8c7-dd03cf4629ea"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("e736e48b-6c61-49e9-ac95-d9b83f4ddf09"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("19fedd88-3f19-410b-b767-b551236df2ef"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("3456a830-8a54-4e3c-b483-60ef563242fb"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("8d408e32-6ed3-4b01-9175-db54a21ec6ea"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("d7a2c987-f494-4a83-9552-7a10f616e9ae"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("73ad2f8e-417d-4a6e-8eb1-7fef399da319"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("eec9c9ed-7e7c-439b-a214-1f66583054ca"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("b7aabb9b-1e8d-4b5b-a0bb-fb425ce61956"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("e64870c2-d1c0-4b18-81be-995a0d658075"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("8d08c6be-ba01-4403-b426-de40f3a0a679"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("76fa51b1-2ba9-4759-b110-f071346de434"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("fa752b9c-8e03-4180-a214-0ba8ddd8190b"));

            migrationBuilder.DropColumn(
                name: "InvoiceCode",
                table: "HoaDons");

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
    }
}
