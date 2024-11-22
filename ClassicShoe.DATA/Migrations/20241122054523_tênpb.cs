using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassicShoe.DATA.Migrations
{
    /// <inheritdoc />
    public partial class tênpb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("8f04fb60-97a2-44f4-aa7e-b326a130f9e9"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("d6f1d5a5-bac4-4469-87f7-8cd1ade43346"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("5a7cf51d-5a74-4c37-a353-aca5a7673c36"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("702b0567-8164-4b2a-9806-86d4508a1b1b"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("5f36bf8b-4c6e-41e4-8d3f-42babda2faf4"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("7b9df3b1-d66a-4a90-ae00-a5861c09d32d"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("b51f3491-ce4b-4a9c-aaa8-2e1a0176eca8"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("93ddfc26-fd27-41cb-9612-43145b2f5416"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("ff7e3ea5-75de-4c81-b2ef-fe8172aacff9"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("e8a84f1d-0a2c-48a5-81eb-d58466e730cf"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("6c930b46-cecb-44bf-a77d-e8529c1517a7"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("e054b54d-b509-4019-ade2-916e5e51bb11"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("6505444c-ab63-42a2-b00b-a68d774a1a8e"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("b9930b8c-e890-40ee-b6f6-20c0d4cda646"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("58504573-a740-48b3-b378-d830deea3351"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("7f8c33a4-42cd-4976-ae3e-80c6d2c78983"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("47e63190-4788-4e29-9a57-1d5a9f6d23ea"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("7a337aac-5516-41d2-bf7c-98c69692c975"));

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("ac1d31d2-0ce1-4b14-9863-d450d2d43826"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" },
                    { new Guid("c09c60f3-41fe-425b-89c6-510db548f12b"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("86fc747f-8fde-41b7-981d-817399a11aaa"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "Id", "DiaChi", "DiemTichLuy", "Email", "NgaySinh", "SoDienThoai", "TenKhachHang", "TongChiTieu" },
                values: new object[] { new Guid("19281854-01e4-4c1d-8d43-38df070d6484"), "789 XYZ Street", 200, "tranthic@example.com", new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", "Tran Thi C", 3000000m });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("d65032d2-f5ba-4be7-91c3-836bf8f51689"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.UpdateData(
                table: "MaGiamGias",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2024, 11, 22, 12, 45, 22, 383, DateTimeKind.Local).AddTicks(8687), new DateTime(2124, 11, 22, 12, 45, 22, 383, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("152bf1e8-ca68-447a-8783-9a3ac59de037"), "Đỏ" },
                    { new Guid("7fa3d315-fd7a-40e1-9364-ccf8b1d9f8f4"), "Xanh" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("1521b0a5-d63f-4d2f-8f62-647d0127fcc6"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" },
                    { new Guid("d873eeea-51cb-4b71-9a73-d67ce3fac2f0"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("3b90e2da-c3da-4c67-b6d4-24c4dbbb650c"), "NV", "NhanVien" },
                    { new Guid("a49c17f3-294e-4cc6-bcd8-75f70441608b"), "ADMIN", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("2c0fdbcb-c83a-4a68-bda6-9ab4a2e035b6"), "password2", "admin2", new Guid("a49c17f3-294e-4cc6-bcd8-75f70441608b") },
                    { new Guid("d32e15c2-63b7-486d-9da6-803b9defafa6"), "password1", "admin1", new Guid("a49c17f3-294e-4cc6-bcd8-75f70441608b") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("d0e54967-1655-4947-90a8-87f3cc26360e"), new Guid("86fc747f-8fde-41b7-981d-817399a11aaa"), new Guid("d65032d2-f5ba-4be7-91c3-836bf8f51689"), 1 });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "Id", "DiaChi", "Email", "MatKhau", "NgaySinh", "SoDienThoai", "TenNhanVien", "TenTaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("947b7587-b2d6-4a8d-83af-7f9bf70b3fc3"), "456 XYZ Street", "lethib@example.com", "abcdef", new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0907654321", "Le Thi B", "lethib", new Guid("3b90e2da-c3da-4c67-b6d4-24c4dbbb650c") },
                    { new Guid("ccc035a9-83c9-4cff-b250-c91e8279b2d3"), "123 ABC Street", "nguyenvana@example.com", "123456", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0901234567", "Nguyen Van A", "nguyenvana", new Guid("3b90e2da-c3da-4c67-b6d4-24c4dbbb650c") }
                });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("2d0c78e7-cb67-4289-b907-43cce6192fe2"), "Bảo hành 6 tháng", new Guid("c09c60f3-41fe-425b-89c6-510db548f12b"), 1200000m, new Guid("d0e54967-1655-4947-90a8-87f3cc26360e"), new Guid("7fa3d315-fd7a-40e1-9364-ccf8b1d9f8f4"), new DateTime(2024, 11, 22, 12, 45, 22, 383, DateTimeKind.Local).AddTicks(8590), 15, "Nike Revolution", new Guid("d873eeea-51cb-4b71-9a73-d67ce3fac2f0"), 1 },
                    { new Guid("2f90e9f7-e909-41e5-8b16-879e3380459a"), "Bảo hành 1 năm", new Guid("ac1d31d2-0ce1-4b14-9863-d450d2d43826"), 1500000m, new Guid("d0e54967-1655-4947-90a8-87f3cc26360e"), new Guid("152bf1e8-ca68-447a-8783-9a3ac59de037"), new DateTime(2024, 11, 22, 12, 45, 22, 383, DateTimeKind.Local).AddTicks(8549), 10, "Nike Air Max", new Guid("1521b0a5-d63f-4d2f-8f62-647d0127fcc6"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2c0fdbcb-c83a-4a68-bda6-9ab4a2e035b6"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("d32e15c2-63b7-486d-9da6-803b9defafa6"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("2d0c78e7-cb67-4289-b907-43cce6192fe2"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("2f90e9f7-e909-41e5-8b16-879e3380459a"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("19281854-01e4-4c1d-8d43-38df070d6484"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("947b7587-b2d6-4a8d-83af-7f9bf70b3fc3"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("ccc035a9-83c9-4cff-b250-c91e8279b2d3"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("ac1d31d2-0ce1-4b14-9863-d450d2d43826"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("c09c60f3-41fe-425b-89c6-510db548f12b"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("d0e54967-1655-4947-90a8-87f3cc26360e"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("152bf1e8-ca68-447a-8783-9a3ac59de037"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("7fa3d315-fd7a-40e1-9364-ccf8b1d9f8f4"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("1521b0a5-d63f-4d2f-8f62-647d0127fcc6"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("d873eeea-51cb-4b71-9a73-d67ce3fac2f0"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("3b90e2da-c3da-4c67-b6d4-24c4dbbb650c"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("a49c17f3-294e-4cc6-bcd8-75f70441608b"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("86fc747f-8fde-41b7-981d-817399a11aaa"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("d65032d2-f5ba-4be7-91c3-836bf8f51689"));

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("93ddfc26-fd27-41cb-9612-43145b2f5416"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" },
                    { new Guid("ff7e3ea5-75de-4c81-b2ef-fe8172aacff9"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("47e63190-4788-4e29-9a57-1d5a9f6d23ea"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "Id", "DiaChi", "DiemTichLuy", "Email", "NgaySinh", "SoDienThoai", "TenKhachHang", "TongChiTieu" },
                values: new object[] { new Guid("5f36bf8b-4c6e-41e4-8d3f-42babda2faf4"), "789 XYZ Street", 200, "tranthic@example.com", new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", "Tran Thi C", 3000000m });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("7a337aac-5516-41d2-bf7c-98c69692c975"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.UpdateData(
                table: "MaGiamGias",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2024, 11, 22, 3, 57, 28, 581, DateTimeKind.Local).AddTicks(6261), new DateTime(2124, 11, 22, 3, 57, 28, 581, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("6c930b46-cecb-44bf-a77d-e8529c1517a7"), "Đỏ" },
                    { new Guid("e054b54d-b509-4019-ade2-916e5e51bb11"), "Xanh" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("6505444c-ab63-42a2-b00b-a68d774a1a8e"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" },
                    { new Guid("b9930b8c-e890-40ee-b6f6-20c0d4cda646"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("58504573-a740-48b3-b378-d830deea3351"), "NV", "NhanVien" },
                    { new Guid("7f8c33a4-42cd-4976-ae3e-80c6d2c78983"), "ADMIN", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("8f04fb60-97a2-44f4-aa7e-b326a130f9e9"), "password2", "admin2", new Guid("7f8c33a4-42cd-4976-ae3e-80c6d2c78983") },
                    { new Guid("d6f1d5a5-bac4-4469-87f7-8cd1ade43346"), "password1", "admin1", new Guid("7f8c33a4-42cd-4976-ae3e-80c6d2c78983") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("e8a84f1d-0a2c-48a5-81eb-d58466e730cf"), new Guid("47e63190-4788-4e29-9a57-1d5a9f6d23ea"), new Guid("7a337aac-5516-41d2-bf7c-98c69692c975"), 1 });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "Id", "DiaChi", "Email", "MatKhau", "NgaySinh", "SoDienThoai", "TenNhanVien", "TenTaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("7b9df3b1-d66a-4a90-ae00-a5861c09d32d"), "123 ABC Street", "nguyenvana@example.com", "123456", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0901234567", "Nguyen Van A", "nguyenvana", new Guid("58504573-a740-48b3-b378-d830deea3351") },
                    { new Guid("b51f3491-ce4b-4a9c-aaa8-2e1a0176eca8"), "456 XYZ Street", "lethib@example.com", "abcdef", new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0907654321", "Le Thi B", "lethib", new Guid("58504573-a740-48b3-b378-d830deea3351") }
                });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("5a7cf51d-5a74-4c37-a353-aca5a7673c36"), "Bảo hành 6 tháng", new Guid("93ddfc26-fd27-41cb-9612-43145b2f5416"), 1200000m, new Guid("e8a84f1d-0a2c-48a5-81eb-d58466e730cf"), new Guid("e054b54d-b509-4019-ade2-916e5e51bb11"), new DateTime(2024, 11, 22, 3, 57, 28, 581, DateTimeKind.Local).AddTicks(6216), 15, "Nike Revolution", new Guid("6505444c-ab63-42a2-b00b-a68d774a1a8e"), 1 },
                    { new Guid("702b0567-8164-4b2a-9806-86d4508a1b1b"), "Bảo hành 1 năm", new Guid("ff7e3ea5-75de-4c81-b2ef-fe8172aacff9"), 1500000m, new Guid("e8a84f1d-0a2c-48a5-81eb-d58466e730cf"), new Guid("6c930b46-cecb-44bf-a77d-e8529c1517a7"), new DateTime(2024, 11, 22, 3, 57, 28, 581, DateTimeKind.Local).AddTicks(6202), 10, "Nike Air Max", new Guid("b9930b8c-e890-40ee-b6f6-20c0d4cda646"), 1 }
                });
        }
    }
}
