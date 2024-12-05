using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassicShoe.DATA.Migrations
{
    /// <inheritdoc />
    public partial class lan9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("0b7a52b2-8f6a-46a7-ac46-f1b50375c978"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" },
                    { new Guid("747b7674-c438-4ad7-98f1-e909424288da"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("f2b23e0f-8555-4b38-8cbd-6819e9073e3b"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "Id", "DiaChi", "DiemTichLuy", "Email", "NgaySinh", "SoDienThoai", "TenKhachHang", "TongChiTieu" },
                values: new object[,]
                {
                    { new Guid("5de6775f-c506-428c-9186-87729055c9db"), "789 XYZ Street", 200, "tranthic@example.com", new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", "Tran Thi C", 3000000m },
                    { new Guid("9761154f-19e3-47f0-bf11-ea3ba51ff9e4"), "789 XYZ Street", 200, "tranthic@example.com", new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0100000000", "Khách lẻ", 3000000m }
                });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("3c9122fc-b5a7-4f7d-9922-71a5931aaabf"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.UpdateData(
                table: "MaGiamGias",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2024, 12, 5, 17, 40, 11, 6, DateTimeKind.Local).AddTicks(5850), new DateTime(2124, 12, 5, 17, 40, 11, 6, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("576d00d5-d75b-49ec-b0c1-60cae747aee1"), "Đỏ" },
                    { new Guid("82b19c92-07b2-4b47-ae4c-81be4395baa0"), "Xanh" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("91d586b6-b936-44d9-8a93-005fc7a1a5a8"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" },
                    { new Guid("f39b3796-9fc1-4650-bd89-b228f1dd6d0e"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("1a4b427d-63e7-4aea-bad5-864a05a321a9"), "ADMIN", "Admin" },
                    { new Guid("a91fa6e1-85dc-4f4a-b4f9-32d9a0849b87"), "NV", "NhanVien" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("e39bb14f-ec88-4f31-ad74-b70dbf970440"), "password2", "admin2", new Guid("1a4b427d-63e7-4aea-bad5-864a05a321a9") },
                    { new Guid("fc0a6b18-24de-4603-bb2d-e80d642ca74c"), "password1", "admin1", new Guid("1a4b427d-63e7-4aea-bad5-864a05a321a9") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("32b56b4b-cd86-4aed-85b6-2d4c083b2329"), new Guid("f2b23e0f-8555-4b38-8cbd-6819e9073e3b"), new Guid("3c9122fc-b5a7-4f7d-9922-71a5931aaabf"), 1 });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "Id", "DiaChi", "Email", "MatKhau", "NgaySinh", "SoDienThoai", "TenNhanVien", "TenTaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("50108123-b9fc-4cec-84ac-e758f29014c6"), "456 XYZ Street", "lethib@example.com", "abcdef", new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0907654321", "Le Thi B", "lethib", new Guid("a91fa6e1-85dc-4f4a-b4f9-32d9a0849b87") },
                    { new Guid("91223f56-f89c-4953-aa2d-43fbc66588c8"), "123 ABC Street", "nguyenvana@example.com", "123456", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0901234567", "Nguyen Van A", "nguyenvana", new Guid("a91fa6e1-85dc-4f4a-b4f9-32d9a0849b87") }
                });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("8893f0e1-1532-474e-b719-3c6b7aa7302c"), "Bảo hành 1 năm", new Guid("0b7a52b2-8f6a-46a7-ac46-f1b50375c978"), 1500000m, new Guid("32b56b4b-cd86-4aed-85b6-2d4c083b2329"), new Guid("576d00d5-d75b-49ec-b0c1-60cae747aee1"), new DateTime(2024, 12, 5, 17, 40, 11, 6, DateTimeKind.Local).AddTicks(5777), 10, "Nike Air Max", new Guid("f39b3796-9fc1-4650-bd89-b228f1dd6d0e"), 1 },
                    { new Guid("c8efd32b-986f-4903-a770-8ede8e39e747"), "Bảo hành 6 tháng", new Guid("747b7674-c438-4ad7-98f1-e909424288da"), 1200000m, new Guid("32b56b4b-cd86-4aed-85b6-2d4c083b2329"), new Guid("82b19c92-07b2-4b47-ae4c-81be4395baa0"), new DateTime(2024, 12, 5, 17, 40, 11, 6, DateTimeKind.Local).AddTicks(5793), 15, "Nike Revolution", new Guid("91d586b6-b936-44d9-8a93-005fc7a1a5a8"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e39bb14f-ec88-4f31-ad74-b70dbf970440"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("fc0a6b18-24de-4603-bb2d-e80d642ca74c"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("8893f0e1-1532-474e-b719-3c6b7aa7302c"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("c8efd32b-986f-4903-a770-8ede8e39e747"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("5de6775f-c506-428c-9186-87729055c9db"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("9761154f-19e3-47f0-bf11-ea3ba51ff9e4"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("50108123-b9fc-4cec-84ac-e758f29014c6"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("91223f56-f89c-4953-aa2d-43fbc66588c8"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("0b7a52b2-8f6a-46a7-ac46-f1b50375c978"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("747b7674-c438-4ad7-98f1-e909424288da"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("32b56b4b-cd86-4aed-85b6-2d4c083b2329"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("576d00d5-d75b-49ec-b0c1-60cae747aee1"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("82b19c92-07b2-4b47-ae4c-81be4395baa0"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("91d586b6-b936-44d9-8a93-005fc7a1a5a8"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("f39b3796-9fc1-4650-bd89-b228f1dd6d0e"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("1a4b427d-63e7-4aea-bad5-864a05a321a9"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("a91fa6e1-85dc-4f4a-b4f9-32d9a0849b87"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("f2b23e0f-8555-4b38-8cbd-6819e9073e3b"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("3c9122fc-b5a7-4f7d-9922-71a5931aaabf"));

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
        }
    }
}
