using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassicShoe.DATA.Migrations
{
    /// <inheritdoc />
    public partial class lan2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("7cc318f4-7211-4c9d-a996-aba24c244a92"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("dbc32078-1b24-41d4-833a-da3ccc5e6ea9"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("37657f79-5afd-49e5-9f2c-62bbf264b4b0"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("c3f532d7-a731-4407-ac38-e4a4ab9eb98a"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("41bbfb15-d6b0-4cc3-ac9c-b68ae4e4fdbe"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("2ecaf93f-6f8a-49ab-b612-477be516bb3d"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("ac615456-6904-4dda-81cf-54896445eb47"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("62310fc2-7afd-4c71-a138-fcfe152bf0e1"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("c175ef73-c43a-4955-af0b-7e59b7a10715"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("4aa79c6b-0fe5-4851-9d5a-626d711925b2"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("2f50ee69-3310-4880-a4b6-68d0e563c280"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("3a9b4b42-24f6-4964-a19a-49e1e3adb18b"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("8495904c-61de-4622-a0f0-b158a647cc5d"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("8713b41f-cf41-4f51-bcf4-4455b953a846"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("7d95e027-1380-4027-88fb-6eaa401feef4"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("c59da32a-6288-42be-a828-7897c6428601"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("047a7dc2-b30e-4d15-949f-f20f0d79d80a"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("3ffe5adc-baba-4cb0-89be-35ac7e922958"));

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("9bec2363-4056-4eb1-b362-f375e1e57085"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" },
                    { new Guid("da22cbae-0ac3-42d4-ae9e-99d5cfd879ad"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("2524d9fe-f6bb-4b93-9130-e49d61a93159"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "Id", "DiaChi", "DiemTichLuy", "Email", "NgaySinh", "SoDienThoai", "TenKhachHang", "TongChiTieu" },
                values: new object[] { new Guid("933be8d1-2876-4183-b99f-4cafcda9d071"), "789 XYZ Street", 200, "tranthic@example.com", new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", "Tran Thi C", 3000000m });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("5321a136-8401-42c0-9828-eab051f8157a"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("9f509f76-7eeb-416a-99f5-4f55111185f4"), "Xanh" },
                    { new Guid("db4448e7-cc14-4e32-90b4-e4d47b10e6c5"), "Đỏ" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("94c253aa-44c9-45d8-bd30-e7beecf60b31"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" },
                    { new Guid("bdc199d4-5f41-411a-8fc2-ebee8ed99673"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("5361efe7-db99-45a5-be81-ce1c7e67660e"), "ADMIN", "Admin" },
                    { new Guid("615b63c4-dbea-46c5-b44d-77a9cd565336"), "NV", "NhanVien" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("23240382-3070-4429-8370-7b692b129214"), "password1", "admin1", new Guid("5361efe7-db99-45a5-be81-ce1c7e67660e") },
                    { new Guid("abca2eac-7df4-4af9-a350-7ef146883c83"), "password2", "admin2", new Guid("5361efe7-db99-45a5-be81-ce1c7e67660e") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("4f08c04e-4618-405d-b389-c0c7dcce2770"), new Guid("2524d9fe-f6bb-4b93-9130-e49d61a93159"), new Guid("5321a136-8401-42c0-9828-eab051f8157a"), 1 });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "Id", "DiaChi", "Email", "MatKhau", "NgaySinh", "SoDienThoai", "TenNhanVien", "TenTaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("31431b10-016c-4018-b33d-bf93156e82af"), "456 XYZ Street", "lethib@example.com", "abcdef", new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0907654321", "Le Thi B", "lethib", new Guid("615b63c4-dbea-46c5-b44d-77a9cd565336") },
                    { new Guid("479d591e-5c55-449f-a2a3-e9566e29ac61"), "123 ABC Street", "nguyenvana@example.com", "123456", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0901234567", "Nguyen Van A", "nguyenvana", new Guid("615b63c4-dbea-46c5-b44d-77a9cd565336") }
                });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("1feeed2a-e7c4-433a-8292-f990552d57be"), "Bảo hành 6 tháng", new Guid("9bec2363-4056-4eb1-b362-f375e1e57085"), 1200000m, new Guid("4f08c04e-4618-405d-b389-c0c7dcce2770"), new Guid("9f509f76-7eeb-416a-99f5-4f55111185f4"), new DateTime(2024, 11, 22, 3, 46, 58, 903, DateTimeKind.Local).AddTicks(3657), 15, "Nike Revolution", new Guid("bdc199d4-5f41-411a-8fc2-ebee8ed99673"), 1 },
                    { new Guid("777a36cb-3602-4cfe-b4a0-581903eaf476"), "Bảo hành 1 năm", new Guid("da22cbae-0ac3-42d4-ae9e-99d5cfd879ad"), 1500000m, new Guid("4f08c04e-4618-405d-b389-c0c7dcce2770"), new Guid("db4448e7-cc14-4e32-90b4-e4d47b10e6c5"), new DateTime(2024, 11, 22, 3, 46, 58, 903, DateTimeKind.Local).AddTicks(3640), 10, "Nike Air Max", new Guid("94c253aa-44c9-45d8-bd30-e7beecf60b31"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("23240382-3070-4429-8370-7b692b129214"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("abca2eac-7df4-4af9-a350-7ef146883c83"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("1feeed2a-e7c4-433a-8292-f990552d57be"));

            migrationBuilder.DeleteData(
                table: "GiayChiTiets",
                keyColumn: "Id",
                keyValue: new Guid("777a36cb-3602-4cfe-b4a0-581903eaf476"));

            migrationBuilder.DeleteData(
                table: "KhachHangs",
                keyColumn: "Id",
                keyValue: new Guid("933be8d1-2876-4183-b99f-4cafcda9d071"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("31431b10-016c-4018-b33d-bf93156e82af"));

            migrationBuilder.DeleteData(
                table: "NhanViens",
                keyColumn: "Id",
                keyValue: new Guid("479d591e-5c55-449f-a2a3-e9566e29ac61"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("9bec2363-4056-4eb1-b362-f375e1e57085"));

            migrationBuilder.DeleteData(
                table: "DeGiays",
                keyColumn: "Id",
                keyValue: new Guid("da22cbae-0ac3-42d4-ae9e-99d5cfd879ad"));

            migrationBuilder.DeleteData(
                table: "Giays",
                keyColumn: "Id",
                keyValue: new Guid("4f08c04e-4618-405d-b389-c0c7dcce2770"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("9f509f76-7eeb-416a-99f5-4f55111185f4"));

            migrationBuilder.DeleteData(
                table: "MauSacs",
                keyColumn: "Id",
                keyValue: new Guid("db4448e7-cc14-4e32-90b4-e4d47b10e6c5"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("94c253aa-44c9-45d8-bd30-e7beecf60b31"));

            migrationBuilder.DeleteData(
                table: "ThanGiays",
                keyColumn: "Id",
                keyValue: new Guid("bdc199d4-5f41-411a-8fc2-ebee8ed99673"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("5361efe7-db99-45a5-be81-ce1c7e67660e"));

            migrationBuilder.DeleteData(
                table: "VaiTros",
                keyColumn: "Id",
                keyValue: new Guid("615b63c4-dbea-46c5-b44d-77a9cd565336"));

            migrationBuilder.DeleteData(
                table: "HangSanXuats",
                keyColumn: "Id",
                keyValue: new Guid("2524d9fe-f6bb-4b93-9130-e49d61a93159"));

            migrationBuilder.DeleteData(
                table: "LoaiGiays",
                keyColumn: "Id",
                keyValue: new Guid("5321a136-8401-42c0-9828-eab051f8157a"));

            migrationBuilder.InsertData(
                table: "DeGiays",
                columns: new[] { "Id", "ChatLieu", "CongNghe", "Mota", "TenDe" },
                values: new object[,]
                {
                    { new Guid("62310fc2-7afd-4c71-a138-fcfe152bf0e1"), "Cao su", "Chống trượt", "Đế cao su bền chắc, khả năng chống trượt tốt", "Đế Cao Su" },
                    { new Guid("c175ef73-c43a-4955-af0b-7e59b7a10715"), "Nhựa", "Chống mài mòn", "Đế nhựa nhẹ, chịu được mài mòn cao", "Đế Nhựa" }
                });

            migrationBuilder.InsertData(
                table: "HangSanXuats",
                columns: new[] { "Id", "DiaChi", "DieuKhoan", "Email", "Logo", "TenHang" },
                values: new object[] { new Guid("047a7dc2-b30e-4d15-949f-f20f0d79d80a"), "Beaverton, Oregon, USA", "https://example.com/terms-nike.pdf", "support@nike.com", "https://example.com/logo-nike.png", "Nike" });

            migrationBuilder.InsertData(
                table: "KhachHangs",
                columns: new[] { "Id", "DiaChi", "DiemTichLuy", "Email", "NgaySinh", "SoDienThoai", "TenKhachHang", "TongChiTieu" },
                values: new object[] { new Guid("41bbfb15-d6b0-4cc3-ac9c-b68ae4e4fdbe"), "789 XYZ Street", 200, "tranthic@example.com", new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", "Tran Thi C", 3000000m });

            migrationBuilder.InsertData(
                table: "LoaiGiays",
                columns: new[] { "Id", "MoTa", "PhongCach", "TenLoai" },
                values: new object[] { new Guid("3ffe5adc-baba-4cb0-89be-35ac7e922958"), "Giày thể thao, phù hợp với nhiều hoạt động", "Thể thao", "Sneaker" });

            migrationBuilder.InsertData(
                table: "MauSacs",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("2f50ee69-3310-4880-a4b6-68d0e563c280"), "Đỏ" },
                    { new Guid("3a9b4b42-24f6-4964-a19a-49e1e3adb18b"), "Xanh" }
                });

            migrationBuilder.InsertData(
                table: "ThanGiays",
                columns: new[] { "Id", "ChatLieu", "MoTa", "Ten", "ThietKe" },
                values: new object[,]
                {
                    { new Guid("8495904c-61de-4622-a0f0-b158a647cc5d"), "Da thật", "Thân giày làm từ da thật, thiết kế thanh lịch, độ bền cao", "Thân Giày Da", "Thời trang cổ điển" },
                    { new Guid("8713b41f-cf41-4f51-bcf4-4455b953a846"), "Vải canvas", "Thân giày làm từ vải canvas thoáng khí, phù hợp với phong cách năng động", "Thân Giày Vải", "Phong cách trẻ trung" }
                });

            migrationBuilder.InsertData(
                table: "VaiTros",
                columns: new[] { "Id", "MaVaiTro", "TenVaiTro" },
                values: new object[,]
                {
                    { new Guid("7d95e027-1380-4027-88fb-6eaa401feef4"), "NV", "NhanVien" },
                    { new Guid("c59da32a-6288-42be-a828-7897c6428601"), "ADMIN", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "MatKhau", "TaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("7cc318f4-7211-4c9d-a996-aba24c244a92"), "password2", "admin2", new Guid("c59da32a-6288-42be-a828-7897c6428601") },
                    { new Guid("dbc32078-1b24-41d4-833a-da3ccc5e6ea9"), "password1", "admin1", new Guid("c59da32a-6288-42be-a828-7897c6428601") }
                });

            migrationBuilder.InsertData(
                table: "Giays",
                columns: new[] { "Id", "HangSanXuatId", "LoaiGiayId", "TrangThai" },
                values: new object[] { new Guid("4aa79c6b-0fe5-4851-9d5a-626d711925b2"), new Guid("047a7dc2-b30e-4d15-949f-f20f0d79d80a"), new Guid("3ffe5adc-baba-4cb0-89be-35ac7e922958"), 1 });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "Id", "DiaChi", "Email", "MatKhau", "NgaySinh", "SoDienThoai", "TenNhanVien", "TenTaiKhoan", "VaiTroId" },
                values: new object[,]
                {
                    { new Guid("2ecaf93f-6f8a-49ab-b612-477be516bb3d"), "456 XYZ Street", "lethib@example.com", "abcdef", new DateTime(1992, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0907654321", "Le Thi B", "lethib", new Guid("7d95e027-1380-4027-88fb-6eaa401feef4") },
                    { new Guid("ac615456-6904-4dda-81cf-54896445eb47"), "123 ABC Street", "nguyenvana@example.com", "123456", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0901234567", "Nguyen Van A", "nguyenvana", new Guid("7d95e027-1380-4027-88fb-6eaa401feef4") }
                });

            migrationBuilder.InsertData(
                table: "GiayChiTiets",
                columns: new[] { "Id", "BaoHang", "DeGiayId", "Gia", "GiayId", "MauSacId", "NgayNhanKho", "SoLuong", "TenHang", "ThanGiayId", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("37657f79-5afd-49e5-9f2c-62bbf264b4b0"), "Bảo hành 1 năm", new Guid("62310fc2-7afd-4c71-a138-fcfe152bf0e1"), 1500000m, new Guid("4aa79c6b-0fe5-4851-9d5a-626d711925b2"), new Guid("2f50ee69-3310-4880-a4b6-68d0e563c280"), new DateTime(2024, 11, 22, 3, 16, 48, 236, DateTimeKind.Local).AddTicks(7373), 10, "Nike Air Max", new Guid("8495904c-61de-4622-a0f0-b158a647cc5d"), 1 },
                    { new Guid("c3f532d7-a731-4407-ac38-e4a4ab9eb98a"), "Bảo hành 6 tháng", new Guid("c175ef73-c43a-4955-af0b-7e59b7a10715"), 1200000m, new Guid("4aa79c6b-0fe5-4851-9d5a-626d711925b2"), new Guid("3a9b4b42-24f6-4964-a19a-49e1e3adb18b"), new DateTime(2024, 11, 22, 3, 16, 48, 236, DateTimeKind.Local).AddTicks(7392), 15, "Nike Revolution", new Guid("8713b41f-cf41-4f51-bcf4-4455b953a846"), 1 }
                });
        }
    }
}
