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

            migrationBuilder.AddColumn<Guid>(
                name: "AdminId",
                table: "HoaDons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("5799f1b3-e9fb-47a7-8097-a7b6b9b83fb1"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" },
                    { new Guid("d03d5377-bdf9-44b2-af90-67496def7975"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("0e4aaf03-3a1a-4eb0-882b-3653e885edd5"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "Id", "DiaChi", "DiemTichLuy", "Email", "NgaySinh", "SoDienThoai", "TenKhachHang", "TongChiTieu" },
                values: new object[] { new Guid("2eb7498b-b4f0-422f-9687-458c20b56e3f"), "789 XYZ Street", 200, "tranthic@example.com", new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", "Tran Thi C", 3000000m });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("4945f64d-f12c-439c-8069-d1954fb8edef"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.UpdateData(
                table: "MaGiamGias",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2024, 12, 2, 13, 8, 27, 377, DateTimeKind.Local).AddTicks(5599), new DateTime(2124, 12, 2, 13, 8, 27, 377, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("ee4c591e-45c5-4527-b8bd-7ec70c98e159"), "Xanh" },
                    { new Guid("f8608fbf-5fbb-4b4d-b3a4-88211d49dd75"), "Đỏ" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("1e7e6009-b20a-4539-a3cc-ae8d6db1a0d7"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" },
                    { new Guid("9706c6ee-655e-4cb4-abca-ce1809a3c646"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("4ee1994a-7ce9-4da2-9cfb-fa5cc3170acb"), "ADMIN", "Admin" },
                    { new Guid("9e080247-ad52-40b4-bda9-e20ee6542539"), "NV", "NhanVien" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("1d97cdd6-4e47-4371-ba24-714424116403"), "password1", "admin1", new Guid("4ee1994a-7ce9-4da2-9cfb-fa5cc3170acb") },
                    { new Guid("21897968-29c5-4eab-8ddc-e03eae6db878"), "password2", "admin2", new Guid("4ee1994a-7ce9-4da2-9cfb-fa5cc3170acb") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("fd6e5023-41e1-4fab-ac08-08dede312c8c"), new Guid("0e4aaf03-3a1a-4eb0-882b-3653e885edd5"), new Guid("4945f64d-f12c-439c-8069-d1954fb8edef"), 1 });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "Id", "DiaChi", "Email", "MatKhau", "NgaySinh", "SoDienThoai", "TenNhanVien", "TenTaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("0319ca36-1b0d-4407-9de1-af6768ac0675"), "456 XYZ Street", "lethib@example.com", "abcdef", new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0907654321", "Le Thi B", "lethib", new Guid("9e080247-ad52-40b4-bda9-e20ee6542539") },
                    { new Guid("dffaaf30-db47-40fd-916f-16648ada0123"), "123 ABC Street", "nguyenvana@example.com", "123456", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0901234567", "Nguyen Van A", "nguyenvana", new Guid("9e080247-ad52-40b4-bda9-e20ee6542539") }
                });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1a73b41d-ff6a-4a0a-9011-11c5057f6ad5"), "Bảo hành 1 năm", new Guid("5799f1b3-e9fb-47a7-8097-a7b6b9b83fb1"), 1500000m, new Guid("fd6e5023-41e1-4fab-ac08-08dede312c8c"), new Guid("f8608fbf-5fbb-4b4d-b3a4-88211d49dd75"), new DateTime(2024, 12, 2, 13, 8, 27, 377, DateTimeKind.Local).AddTicks(5537), 10, "Nike Air Max", new Guid("9706c6ee-655e-4cb4-abca-ce1809a3c646"), 1 },
                    { new Guid("68faaf09-9a83-42d5-a0df-37b18df22169"), "Bảo hành 6 tháng", new Guid("d03d5377-bdf9-44b2-af90-67496def7975"), 1200000m, new Guid("fd6e5023-41e1-4fab-ac08-08dede312c8c"), new Guid("ee4c591e-45c5-4527-b8bd-7ec70c98e159"), new DateTime(2024, 12, 2, 13, 8, 27, 377, DateTimeKind.Local).AddTicks(5555), 15, "Nike Revolution", new Guid("1e7e6009-b20a-4539-a3cc-ae8d6db1a0d7"), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_AdminId",
                table: "HoaDons",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_Admins_AdminId",
                table: "HoaDons",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_Admins_AdminId",
                table: "HoaDons");

            migrationBuilder.DropIndex(
                name: "IX_HoaDons_AdminId",
                table: "HoaDons");

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("1d97cdd6-4e47-4371-ba24-714424116403"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("21897968-29c5-4eab-8ddc-e03eae6db878"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("1a73b41d-ff6a-4a0a-9011-11c5057f6ad5"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("68faaf09-9a83-42d5-a0df-37b18df22169"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("2eb7498b-b4f0-422f-9687-458c20b56e3f"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("0319ca36-1b0d-4407-9de1-af6768ac0675"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("dffaaf30-db47-40fd-916f-16648ada0123"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("5799f1b3-e9fb-47a7-8097-a7b6b9b83fb1"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("d03d5377-bdf9-44b2-af90-67496def7975"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("fd6e5023-41e1-4fab-ac08-08dede312c8c"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("ee4c591e-45c5-4527-b8bd-7ec70c98e159"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("f8608fbf-5fbb-4b4d-b3a4-88211d49dd75"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("1e7e6009-b20a-4539-a3cc-ae8d6db1a0d7"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("9706c6ee-655e-4cb4-abca-ce1809a3c646"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("4ee1994a-7ce9-4da2-9cfb-fa5cc3170acb"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("9e080247-ad52-40b4-bda9-e20ee6542539"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("0e4aaf03-3a1a-4eb0-882b-3653e885edd5"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("4945f64d-f12c-439c-8069-d1954fb8edef"));

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "HoaDons");

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
    }
}
