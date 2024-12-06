using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassicShoe.DATA.Migrations
{
    /// <inheritdoc />
    public partial class lan11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "NhanViens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("088abfba-26e9-4ede-a8bf-f5e15f038044"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" },
                    { new Guid("91fd22c0-6ef7-4233-b885-b11f390656f0"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("5979cd56-5fb7-49fd-bc67-ea2e9997601f"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "Id", "DiaChi", "DiemTichLuy", "Email", "NgaySinh", "SoDienThoai", "TenKhachHang", "TongChiTieu" },
                values: new object[,]
                {
                    { new Guid("02352b49-07f5-4d03-818c-372acd5fb51f"), "789 XYZ Street", 200, "tranthic@example.com", new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", "Tran Thi C", 3000000m },
                    { new Guid("e6222ef0-5bb1-47f3-9e69-3156da706343"), "789 XYZ Street", 200, "tranthic@example.com", new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0100000000", "Khách lẻ", 3000000m }
                });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("ad688b3d-5e15-4583-9b87-0fb8ff100b53"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.UpdateData(
                table: "MaGiamGias",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "NgayBatDau", "NgayKetThuc" },
                values: new object[] { new DateTime(2024, 12, 6, 6, 34, 43, 69, DateTimeKind.Local).AddTicks(2509), new DateTime(2124, 12, 6, 6, 34, 43, 69, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("3c3597a5-5a60-4a38-8317-49dd46532e0c"), "Đỏ" },
                    { new Guid("3dc3fe33-b62b-4716-8c79-ea981a1edf15"), "Xanh" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("93b3ab14-3a58-44bc-a23d-24a192382836"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" },
                    { new Guid("d55c38e9-c185-4a84-8550-fc831ff9d94b"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("b15e4efe-9192-4965-aee7-0ef3e63dd3cc"), "ADMIN", "Admin" },
                    { new Guid("ee8b450f-ce0c-4d9d-89df-d324b8d8186b"), "NV", "NhanVien" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("8d5f3df5-e480-4f38-8f95-2c604f0a1569"), "password2", "admin2", new Guid("b15e4efe-9192-4965-aee7-0ef3e63dd3cc") },
                    { new Guid("de9d0947-a974-4f92-a382-2d70cf7c6137"), "password1", "admin1", new Guid("b15e4efe-9192-4965-aee7-0ef3e63dd3cc") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("893fd079-d2a5-4784-b075-98f5d0d5821e"), new Guid("5979cd56-5fb7-49fd-bc67-ea2e9997601f"), new Guid("ad688b3d-5e15-4583-9b87-0fb8ff100b53"), 1 });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "Id", "DiaChi", "Email", "MatKhau", "NgaySinh", "SoDienThoai", "Status", "TenNhanVien", "TenTaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("21393ff3-1619-4306-9f66-3da535da83d0"), "456 XYZ Street", "lethib@example.com", "abcdef", new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0907654321", 0, "Le Thi B", "lethib", new Guid("ee8b450f-ce0c-4d9d-89df-d324b8d8186b") },
                    { new Guid("d522d4b2-129e-4b29-b579-8893c7b27083"), "123 ABC Street", "nguyenvana@example.com", "123456", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0901234567", 0, "Nguyen Van A", "nguyenvana", new Guid("ee8b450f-ce0c-4d9d-89df-d324b8d8186b") }
                });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("47e076d2-a04d-4c92-8496-e5c85caae85d"), "Bảo hành 6 tháng", new Guid("088abfba-26e9-4ede-a8bf-f5e15f038044"), 1200000m, new Guid("893fd079-d2a5-4784-b075-98f5d0d5821e"), new Guid("3dc3fe33-b62b-4716-8c79-ea981a1edf15"), new DateTime(2024, 12, 6, 6, 34, 43, 69, DateTimeKind.Local).AddTicks(2455), 15, "Nike Revolution", new Guid("d55c38e9-c185-4a84-8550-fc831ff9d94b"), 1 },
                    { new Guid("ad7feead-2b80-4916-810e-18e791a8c5a2"), "Bảo hành 1 năm", new Guid("91fd22c0-6ef7-4233-b885-b11f390656f0"), 1500000m, new Guid("893fd079-d2a5-4784-b075-98f5d0d5821e"), new Guid("3c3597a5-5a60-4a38-8317-49dd46532e0c"), new DateTime(2024, 12, 6, 6, 34, 43, 69, DateTimeKind.Local).AddTicks(2435), 10, "Nike Air Max", new Guid("93b3ab14-3a58-44bc-a23d-24a192382836"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("8d5f3df5-e480-4f38-8f95-2c604f0a1569"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("de9d0947-a974-4f92-a382-2d70cf7c6137"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("47e076d2-a04d-4c92-8496-e5c85caae85d"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("ad7feead-2b80-4916-810e-18e791a8c5a2"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("02352b49-07f5-4d03-818c-372acd5fb51f"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("e6222ef0-5bb1-47f3-9e69-3156da706343"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("21393ff3-1619-4306-9f66-3da535da83d0"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("d522d4b2-129e-4b29-b579-8893c7b27083"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("088abfba-26e9-4ede-a8bf-f5e15f038044"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("91fd22c0-6ef7-4233-b885-b11f390656f0"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("893fd079-d2a5-4784-b075-98f5d0d5821e"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("3c3597a5-5a60-4a38-8317-49dd46532e0c"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("3dc3fe33-b62b-4716-8c79-ea981a1edf15"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("93b3ab14-3a58-44bc-a23d-24a192382836"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("d55c38e9-c185-4a84-8550-fc831ff9d94b"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("b15e4efe-9192-4965-aee7-0ef3e63dd3cc"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("ee8b450f-ce0c-4d9d-89df-d324b8d8186b"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("5979cd56-5fb7-49fd-bc67-ea2e9997601f"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("ad688b3d-5e15-4583-9b87-0fb8ff100b53"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "NhanViens");

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
    }
}
