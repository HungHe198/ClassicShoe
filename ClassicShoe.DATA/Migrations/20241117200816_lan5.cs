using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassicShoe.DATA.Migrations
{
    /// <inheritdoc />
    public partial class lan5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("2788c6ef-8b9e-41a5-b62e-ebf6aa4ad6e1"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" },
                    { new Guid("e5f05461-13f9-4dc1-85ed-d6233c81e793"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("3a0fe331-8efb-4dd8-9906-824094167156"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("f8f9b475-480b-4c74-af6c-93b5ba2044c7"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("3d725dfd-0a94-4f4c-a263-1dfc7ae352fb"), "Đỏ" },
                    { new Guid("f6a26141-31f3-4128-a9a5-e67d2eb7d205"), "Xanh" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("43709c98-73cb-4eda-8b7c-abd64750c03f"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" },
                    { new Guid("f30bbf79-99e2-4bb3-93fb-3d8043680d46"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("60d2c913-4972-45da-8d53-17adb99abbd1"), "NV", "NhanVien" },
                    { new Guid("80a9f8c3-07c5-4c24-b39c-876bdce0c31c"), "ADMIN", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("9b5a4130-133b-4a50-b3ba-f6cbe55591e8"), "password1", "admin1", new Guid("80a9f8c3-07c5-4c24-b39c-876bdce0c31c") },
                    { new Guid("ca2c623b-56e5-4d6f-825e-2c8d21a9ba63"), "password2", "admin2", new Guid("80a9f8c3-07c5-4c24-b39c-876bdce0c31c") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("7a7d2b97-6f76-4849-ad19-2666d0abbd2f"), new Guid("3a0fe331-8efb-4dd8-9906-824094167156"), new Guid("f8f9b475-480b-4c74-af6c-93b5ba2044c7"), 1 });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "Id", "DiaChi", "Email", "MatKhau", "NgaySinh", "SoDienThoai", "TenNhanVien", "TenTaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("284a9bbc-dce7-46fa-b401-966db03edae3"), "123 ABC Street", "nguyenvana@example.com", "123456", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0901234567", "Nguyen Van A", "nguyenvana", new Guid("60d2c913-4972-45da-8d53-17adb99abbd1") },
                    { new Guid("f83d6a06-b0ff-4a66-bbbb-3eae756822e1"), "456 XYZ Street", "lethib@example.com", "abcdef", new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0907654321", "Le Thi B", "lethib", new Guid("60d2c913-4972-45da-8d53-17adb99abbd1") }
                });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("c8d526c8-2134-4126-98ba-115ca8792fec"), "Bảo hành 6 tháng", new Guid("e5f05461-13f9-4dc1-85ed-d6233c81e793"), 1200000m, new Guid("7a7d2b97-6f76-4849-ad19-2666d0abbd2f"), new Guid("f6a26141-31f3-4128-a9a5-e67d2eb7d205"), new DateTime(2024, 11, 18, 3, 8, 16, 28, DateTimeKind.Local).AddTicks(1275), 15, "Nike Revolution", new Guid("43709c98-73cb-4eda-8b7c-abd64750c03f"), 1 },
                    { new Guid("d995b324-d0ed-4500-936d-396a7d7763e6"), "Bảo hành 1 năm", new Guid("2788c6ef-8b9e-41a5-b62e-ebf6aa4ad6e1"), 1500000m, new Guid("7a7d2b97-6f76-4849-ad19-2666d0abbd2f"), new Guid("3d725dfd-0a94-4f4c-a263-1dfc7ae352fb"), new DateTime(2024, 11, 18, 3, 8, 16, 28, DateTimeKind.Local).AddTicks(1256), 10, "Nike Air Max", new Guid("f30bbf79-99e2-4bb3-93fb-3d8043680d46"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("9b5a4130-133b-4a50-b3ba-f6cbe55591e8"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("ca2c623b-56e5-4d6f-825e-2c8d21a9ba63"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("c8d526c8-2134-4126-98ba-115ca8792fec"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("d995b324-d0ed-4500-936d-396a7d7763e6"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("284a9bbc-dce7-46fa-b401-966db03edae3"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("f83d6a06-b0ff-4a66-bbbb-3eae756822e1"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("2788c6ef-8b9e-41a5-b62e-ebf6aa4ad6e1"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("e5f05461-13f9-4dc1-85ed-d6233c81e793"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("7a7d2b97-6f76-4849-ad19-2666d0abbd2f"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("3d725dfd-0a94-4f4c-a263-1dfc7ae352fb"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("f6a26141-31f3-4128-a9a5-e67d2eb7d205"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("43709c98-73cb-4eda-8b7c-abd64750c03f"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("f30bbf79-99e2-4bb3-93fb-3d8043680d46"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("60d2c913-4972-45da-8d53-17adb99abbd1"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("80a9f8c3-07c5-4c24-b39c-876bdce0c31c"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("3a0fe331-8efb-4dd8-9906-824094167156"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("f8f9b475-480b-4c74-af6c-93b5ba2044c7"));

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
    }
}
