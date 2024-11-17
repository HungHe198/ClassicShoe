using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassicShoe.DATA.Migrations
{
    /// <inheritdoc />
    public partial class lan6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("91ed890e-24e0-4b8e-98d2-861c8b800581"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" },
                    { new Guid("ada38a1c-a534-4fba-9bff-db3a3386886b"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("5e3206b4-64fd-42f3-89d3-2047a8e9118d"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "Id", "DiaChi", "DiemTichLuy", "Email", "NgaySinh", "SoDienThoai", "TenKhachHang", "TongChiTieu" },
                values: new object[] { new Guid("f3c4e3ed-bdf9-466a-9953-7b38bf5a9b8f"), "789 XYZ Street", 200, "tranthic@example.com", new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", "Tran Thi C", 3000000m });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("1abd4878-b00c-4f0d-8c4d-d98d3fd9d1c7"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("4447e393-20f0-4abb-b354-af71a7c5974c"), "Xanh" },
                    { new Guid("577ec2a5-ddb2-4ab0-be78-80d25ea7ea14"), "Đỏ" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("479014c2-d0db-40e8-9f5e-491d8599d641"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" },
                    { new Guid("bf65de19-9af4-4c79-8f7d-027218ec13bf"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("28f4a4fc-4ab4-4e34-9619-401f193b514e"), "ADMIN", "Admin" },
                    { new Guid("e8a21deb-f8b9-41a7-b3a5-65393a1cdb0b"), "NV", "NhanVien" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("1a6bf570-b87a-4b52-902b-037f4a9c43b3"), "password1", "admin1", new Guid("28f4a4fc-4ab4-4e34-9619-401f193b514e") },
                    { new Guid("285a2c67-f10c-4e63-ac79-32e694e5b7ea"), "password2", "admin2", new Guid("28f4a4fc-4ab4-4e34-9619-401f193b514e") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("500c9e8b-e00c-4c9e-943e-5a47cd3d8819"), new Guid("5e3206b4-64fd-42f3-89d3-2047a8e9118d"), new Guid("1abd4878-b00c-4f0d-8c4d-d98d3fd9d1c7"), 1 });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "Id", "DiaChi", "Email", "MatKhau", "NgaySinh", "SoDienThoai", "TenNhanVien", "TenTaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("42f79fcd-7fd6-4b24-b498-09337bdb4a3f"), "123 ABC Street", "nguyenvana@example.com", "123456", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0901234567", "Nguyen Van A", "nguyenvana", new Guid("e8a21deb-f8b9-41a7-b3a5-65393a1cdb0b") },
                    { new Guid("be154807-81fa-4427-ab34-ab2dc3bfb277"), "456 XYZ Street", "lethib@example.com", "abcdef", new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0907654321", "Le Thi B", "lethib", new Guid("e8a21deb-f8b9-41a7-b3a5-65393a1cdb0b") }
                });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("0bf44d22-a1a1-412b-b86c-4c4d0c31c99b"), "Bảo hành 1 năm", new Guid("ada38a1c-a534-4fba-9bff-db3a3386886b"), 1500000m, new Guid("500c9e8b-e00c-4c9e-943e-5a47cd3d8819"), new Guid("577ec2a5-ddb2-4ab0-be78-80d25ea7ea14"), new DateTime(2024, 11, 18, 3, 32, 43, 617, DateTimeKind.Local).AddTicks(9271), 10, "Nike Air Max", new Guid("479014c2-d0db-40e8-9f5e-491d8599d641"), 1 },
                    { new Guid("9e6a1b1f-ad83-4b51-9fbe-c17e97df21c8"), "Bảo hành 6 tháng", new Guid("91ed890e-24e0-4b8e-98d2-861c8b800581"), 1200000m, new Guid("500c9e8b-e00c-4c9e-943e-5a47cd3d8819"), new Guid("4447e393-20f0-4abb-b354-af71a7c5974c"), new DateTime(2024, 11, 18, 3, 32, 43, 617, DateTimeKind.Local).AddTicks(9288), 15, "Nike Revolution", new Guid("bf65de19-9af4-4c79-8f7d-027218ec13bf"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("1a6bf570-b87a-4b52-902b-037f4a9c43b3"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("285a2c67-f10c-4e63-ac79-32e694e5b7ea"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("0bf44d22-a1a1-412b-b86c-4c4d0c31c99b"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("9e6a1b1f-ad83-4b51-9fbe-c17e97df21c8"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("f3c4e3ed-bdf9-466a-9953-7b38bf5a9b8f"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("42f79fcd-7fd6-4b24-b498-09337bdb4a3f"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("be154807-81fa-4427-ab34-ab2dc3bfb277"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("91ed890e-24e0-4b8e-98d2-861c8b800581"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("ada38a1c-a534-4fba-9bff-db3a3386886b"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("500c9e8b-e00c-4c9e-943e-5a47cd3d8819"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("4447e393-20f0-4abb-b354-af71a7c5974c"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("577ec2a5-ddb2-4ab0-be78-80d25ea7ea14"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("479014c2-d0db-40e8-9f5e-491d8599d641"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("bf65de19-9af4-4c79-8f7d-027218ec13bf"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("28f4a4fc-4ab4-4e34-9619-401f193b514e"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("e8a21deb-f8b9-41a7-b3a5-65393a1cdb0b"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("5e3206b4-64fd-42f3-89d3-2047a8e9118d"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("1abd4878-b00c-4f0d-8c4d-d98d3fd9d1c7"));

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
    }
}
