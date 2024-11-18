using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassicShoe.DATA.Migrations
{
    /// <inheritdoc />
    public partial class lan8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0b8953df-9c12-4f88-982b-595d55524d85"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" },
                    { new Guid("74d36fe4-f3ca-4b46-a8b0-7d9030275f62"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("0a812994-d06a-4fa6-95cd-d14e11883f80"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "Id", "DiaChi", "DiemTichLuy", "Email", "NgaySinh", "SoDienThoai", "TenKhachHang", "TongChiTieu" },
                values: new object[] { new Guid("0beef5c6-997e-4eb4-890d-55bcf95367bc"), "789 XYZ Street", 200, "tranthic@example.com", new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", "Tran Thi C", 3000000m });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("f2e60b61-ed7a-401b-9d27-f938a99eddb5"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("e760acff-fbb4-4fbb-b256-06873bcf8106"), "Xanh" },
                    { new Guid("fda2ab3c-6e5a-4ea9-b342-4304700f859b"), "Đỏ" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("8dba1648-5d2b-4ddf-9b6e-2dbf92d7cc0e"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" },
                    { new Guid("b1eb7371-cb61-4577-b6ba-8b1c0cbf3fec"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("623000f3-c0de-4eec-a8a2-6609e8a96d6d"), "NV", "NhanVien" },
                    { new Guid("bab812fb-950f-46e6-8da6-e127ff2fed6b"), "ADMIN", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("260df27a-46c9-4242-80b2-574484fdc9bf"), "password2", "admin2", new Guid("bab812fb-950f-46e6-8da6-e127ff2fed6b") },
                    { new Guid("9992b3b8-1492-4488-ac1b-24f6d0320d10"), "password1", "admin1", new Guid("bab812fb-950f-46e6-8da6-e127ff2fed6b") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("71d29234-f097-40c7-8a19-f0b0808b0eb8"), new Guid("0a812994-d06a-4fa6-95cd-d14e11883f80"), new Guid("f2e60b61-ed7a-401b-9d27-f938a99eddb5"), 1 });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "Id", "DiaChi", "Email", "MatKhau", "NgaySinh", "SoDienThoai", "TenNhanVien", "TenTaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("6af142c8-da9a-4868-92c9-d6ac3dc46a26"), "456 XYZ Street", "lethib@example.com", "abcdef", new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0907654321", "Le Thi B", "lethib", new Guid("623000f3-c0de-4eec-a8a2-6609e8a96d6d") },
                    { new Guid("ad60635e-acdf-4318-bccc-e023ecbe8de8"), "123 ABC Street", "nguyenvana@example.com", "123456", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0901234567", "Nguyen Van A", "nguyenvana", new Guid("623000f3-c0de-4eec-a8a2-6609e8a96d6d") }
                });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("0706d460-145d-49cb-a16b-5d733b025ce1"), "Bảo hành 1 năm", new Guid("0b8953df-9c12-4f88-982b-595d55524d85"), 1500000m, new Guid("71d29234-f097-40c7-8a19-f0b0808b0eb8"), new Guid("fda2ab3c-6e5a-4ea9-b342-4304700f859b"), new DateTime(2024, 11, 18, 13, 0, 38, 527, DateTimeKind.Local).AddTicks(638), 10, "Nike Air Max", new Guid("8dba1648-5d2b-4ddf-9b6e-2dbf92d7cc0e"), 1 },
                    { new Guid("1a677749-771d-4e29-bed0-1d89f4edb2c0"), "Bảo hành 6 tháng", new Guid("74d36fe4-f3ca-4b46-a8b0-7d9030275f62"), 1200000m, new Guid("71d29234-f097-40c7-8a19-f0b0808b0eb8"), new Guid("e760acff-fbb4-4fbb-b256-06873bcf8106"), new DateTime(2024, 11, 18, 13, 0, 38, 527, DateTimeKind.Local).AddTicks(672), 15, "Nike Revolution", new Guid("b1eb7371-cb61-4577-b6ba-8b1c0cbf3fec"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("260df27a-46c9-4242-80b2-574484fdc9bf"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("9992b3b8-1492-4488-ac1b-24f6d0320d10"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("0706d460-145d-49cb-a16b-5d733b025ce1"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("1a677749-771d-4e29-bed0-1d89f4edb2c0"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("0beef5c6-997e-4eb4-890d-55bcf95367bc"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("6af142c8-da9a-4868-92c9-d6ac3dc46a26"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("ad60635e-acdf-4318-bccc-e023ecbe8de8"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("0b8953df-9c12-4f88-982b-595d55524d85"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("74d36fe4-f3ca-4b46-a8b0-7d9030275f62"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("71d29234-f097-40c7-8a19-f0b0808b0eb8"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("e760acff-fbb4-4fbb-b256-06873bcf8106"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("fda2ab3c-6e5a-4ea9-b342-4304700f859b"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("8dba1648-5d2b-4ddf-9b6e-2dbf92d7cc0e"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("b1eb7371-cb61-4577-b6ba-8b1c0cbf3fec"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("623000f3-c0de-4eec-a8a2-6609e8a96d6d"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("bab812fb-950f-46e6-8da6-e127ff2fed6b"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("0a812994-d06a-4fa6-95cd-d14e11883f80"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("f2e60b61-ed7a-401b-9d27-f938a99eddb5"));

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
    }
}
