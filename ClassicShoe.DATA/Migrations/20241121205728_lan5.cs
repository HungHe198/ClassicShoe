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

            migrationBuilder.InsertData(
                table: "MaGiamGias",
                columns: new[] { "Id", "GT_HoaDonToiThieu", "GT_ToiDaGiam", "MoTa", "NgayBatDau", "NgayKetThuc", "PhanTramGiam", "TenMaGiamGia" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), 0m, 0m, "Mã giảm giá đặc biệt không áp dụng ưu đãi.", new DateTime(2024, 11, 22, 3, 57, 28, 581, DateTimeKind.Local).AddTicks(6261), new DateTime(2124, 11, 22, 3, 57, 28, 581, DateTimeKind.Local).AddTicks(6262), 0, "NO_DISCOUNT" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "MaGiamGias",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

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
    }
}
