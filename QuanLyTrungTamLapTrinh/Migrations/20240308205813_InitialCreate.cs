using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyTrungTamLapTrinh.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiaoVien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoCCCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuyenMon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Luong = table.Column<int>(type: "int", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HocVien",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoCCCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoaHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HocPhi = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhoaKhaiGiang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaKhaiGiang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhongHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongHoc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThietBi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietBi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LichKhaiGiang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhoaKhaiGiang_Id = table.Column<int>(type: "int", nullable: false),
                    KhoaHoc_Id = table.Column<int>(type: "int", nullable: false),
                    PhongHoc_Id = table.Column<int>(type: "int", nullable: false),
                    GiaoVien_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoBuoiHoc = table.Column<int>(type: "int", nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuongDK = table.Column<int>(type: "int", nullable: true),
                    NgayHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichKhaiGiang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LichKhaiGiang_GiaoVien_GiaoVien_Id",
                        column: x => x.GiaoVien_Id,
                        principalTable: "GiaoVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichKhaiGiang_KhoaHoc_KhoaHoc_Id",
                        column: x => x.KhoaHoc_Id,
                        principalTable: "KhoaHoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichKhaiGiang_KhoaKhaiGiang_KhoaKhaiGiang_Id",
                        column: x => x.KhoaKhaiGiang_Id,
                        principalTable: "KhoaKhaiGiang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichKhaiGiang_PhongHoc_PhongHoc_Id",
                        column: x => x.PhongHoc_Id,
                        principalTable: "PhongHoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachThietBi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhongHoc_Id = table.Column<int>(type: "int", nullable: false),
                    ThietBi_Id = table.Column<int>(type: "int", nullable: false),
                    SL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachThietBi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DanhSachThietBi_PhongHoc_PhongHoc_Id",
                        column: x => x.PhongHoc_Id,
                        principalTable: "PhongHoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhSachThietBi_ThietBi_ThietBi_Id",
                        column: x => x.ThietBi_Id,
                        principalTable: "ThietBi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThietBiHuHong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThietBi_Id = table.Column<int>(type: "int", nullable: false),
                    PhongHoc_Id = table.Column<int>(type: "int", nullable: false),
                    NgayPhatHien = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MoTaLoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySuaChua = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietBiHuHong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThietBiHuHong_PhongHoc_PhongHoc_Id",
                        column: x => x.PhongHoc_Id,
                        principalTable: "PhongHoc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThietBiHuHong_ThietBi_ThietBi_Id",
                        column: x => x.ThietBi_Id,
                        principalTable: "ThietBi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachDangKy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LichKhaiGiang_Id = table.Column<int>(type: "int", nullable: false),
                    HocVien_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayDangKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachDangKy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DanhSachDangKy_HocVien_HocVien_Id",
                        column: x => x.HocVien_Id,
                        principalTable: "HocVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhSachDangKy_LichKhaiGiang_LichKhaiGiang_Id",
                        column: x => x.LichKhaiGiang_Id,
                        principalTable: "LichKhaiGiang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DanhSachDangKy_Id = table.Column<int>(type: "int", nullable: false),
                    TenKhoaHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoTien = table.Column<int>(type: "int", nullable: false),
                    GiamGia = table.Column<int>(type: "int", nullable: true),
                    TongTien = table.Column<int>(type: "int", nullable: false),
                    PhuongThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_DanhSachDangKy_DanhSachDangKy_Id",
                        column: x => x.DanhSachDangKy_Id,
                        principalTable: "DanhSachDangKy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachDangKy_HocVien_Id",
                table: "DanhSachDangKy",
                column: "HocVien_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachDangKy_LichKhaiGiang_Id",
                table: "DanhSachDangKy",
                column: "LichKhaiGiang_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachThietBi_PhongHoc_Id",
                table: "DanhSachThietBi",
                column: "PhongHoc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachThietBi_ThietBi_Id",
                table: "DanhSachThietBi",
                column: "ThietBi_Id");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_DanhSachDangKy_Id",
                table: "HoaDon",
                column: "DanhSachDangKy_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LichKhaiGiang_GiaoVien_Id",
                table: "LichKhaiGiang",
                column: "GiaoVien_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LichKhaiGiang_KhoaHoc_Id",
                table: "LichKhaiGiang",
                column: "KhoaHoc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LichKhaiGiang_KhoaKhaiGiang_Id",
                table: "LichKhaiGiang",
                column: "KhoaKhaiGiang_Id");

            migrationBuilder.CreateIndex(
                name: "IX_LichKhaiGiang_PhongHoc_Id",
                table: "LichKhaiGiang",
                column: "PhongHoc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ThietBiHuHong_PhongHoc_Id",
                table: "ThietBiHuHong",
                column: "PhongHoc_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ThietBiHuHong_ThietBi_Id",
                table: "ThietBiHuHong",
                column: "ThietBi_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhSachThietBi");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "ThietBiHuHong");

            migrationBuilder.DropTable(
                name: "DanhSachDangKy");

            migrationBuilder.DropTable(
                name: "ThietBi");

            migrationBuilder.DropTable(
                name: "HocVien");

            migrationBuilder.DropTable(
                name: "LichKhaiGiang");

            migrationBuilder.DropTable(
                name: "GiaoVien");

            migrationBuilder.DropTable(
                name: "KhoaHoc");

            migrationBuilder.DropTable(
                name: "KhoaKhaiGiang");

            migrationBuilder.DropTable(
                name: "PhongHoc");
        }
    }
}
