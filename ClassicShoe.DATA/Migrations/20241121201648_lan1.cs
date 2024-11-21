using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassicShoe.DATA.Migrations
{
    /// <inheritdoc />
    public partial class lan1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeGiays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChatLieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CongNghe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeGiays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HangSanXuats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DieuKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangSanXuats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiemTichLuy = table.Column<int>(type: "int", nullable: false),
                    TongChiTieu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoaiGiays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongCach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiGiays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaGiamGias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMaGiamGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhanTramGiam = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GT_HoaDonToiThieu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GT_ToiDaGiam = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaGiamGias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSacs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSacs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThanGiays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChatLieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThietKe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanGiays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VaiTros",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenVaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaVaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaiTros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Giays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiGiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HangSanXuatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Giays_HangSanXuats_HangSanXuatId",
                        column: x => x.HangSanXuatId,
                        principalTable: "HangSanXuats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Giays_LoaiGiays_LoaiGiayId",
                        column: x => x.LoaiGiayId,
                        principalTable: "LoaiGiays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VaiTroId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_VaiTros_VaiTroId",
                        column: x => x.VaiTroId,
                        principalTable: "VaiTros",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VaiTroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanViens_VaiTros_VaiTroId",
                        column: x => x.VaiTroId,
                        principalTable: "VaiTros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiayChiTiets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeGiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThanGiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MauSacId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaoHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayNhanKho = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiayChiTiets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiayChiTiets_DeGiays_DeGiayId",
                        column: x => x.DeGiayId,
                        principalTable: "DeGiays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GiayChiTiets_Giays_GiayId",
                        column: x => x.GiayId,
                        principalTable: "Giays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GiayChiTiets_MauSacs_MauSacId",
                        column: x => x.MauSacId,
                        principalTable: "MauSacs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GiayChiTiets_ThanGiays_ThanGiayId",
                        column: x => x.ThanGiayId,
                        principalTable: "ThanGiays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaGiamGiaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayTaoHoaDon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PhuongThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDons_MaGiamGias_MaGiamGiaId",
                        column: x => x.MaGiamGiaId,
                        principalTable: "MaGiamGias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDons_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiayChiTietId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_GiayChiTiets_GiayChiTietId",
                        column: x => x.GiayChiTietId,
                        principalTable: "GiayChiTiets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiets_HoaDons_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "HoaDons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Admins_VaiTroId",
                table: "Admins",
                column: "VaiTroId");

            migrationBuilder.CreateIndex(
                name: "IX_GiayChiTiets_DeGiayId",
                table: "GiayChiTiets",
                column: "DeGiayId");

            migrationBuilder.CreateIndex(
                name: "IX_GiayChiTiets_GiayId",
                table: "GiayChiTiets",
                column: "GiayId");

            migrationBuilder.CreateIndex(
                name: "IX_GiayChiTiets_MauSacId",
                table: "GiayChiTiets",
                column: "MauSacId");

            migrationBuilder.CreateIndex(
                name: "IX_GiayChiTiets_ThanGiayId",
                table: "GiayChiTiets",
                column: "ThanGiayId");

            migrationBuilder.CreateIndex(
                name: "IX_Giays_HangSanXuatId",
                table: "Giays",
                column: "HangSanXuatId");

            migrationBuilder.CreateIndex(
                name: "IX_Giays_LoaiGiayId",
                table: "Giays",
                column: "LoaiGiayId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_GiayChiTietId",
                table: "HoaDonChiTiets",
                column: "GiayChiTietId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiets_HoaDonId",
                table: "HoaDonChiTiets",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangId",
                table: "HoaDons",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_MaGiamGiaId",
                table: "HoaDons",
                column: "MaGiamGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_NhanVienId",
                table: "HoaDons",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_VaiTroId",
                table: "NhanViens",
                column: "VaiTroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "GiayChiTiets");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "DeGiays");

            migrationBuilder.DropTable(
                name: "Giays");

            migrationBuilder.DropTable(
                name: "MauSacs");

            migrationBuilder.DropTable(
                name: "ThanGiays");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "MaGiamGias");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "HangSanXuats");

            migrationBuilder.DropTable(
                name: "LoaiGiays");

            migrationBuilder.DropTable(
                name: "VaiTros");
        }
    }
}
