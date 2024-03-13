using Microsoft.EntityFrameworkCore;
using QuanLyTrungTamLapTrinh.Models;
using System.Data;

namespace QuanLyTrungTamLapTrinh.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<DanhSachDangKy> DanhSachDangKy { get; set; }
        public DbSet<DanhSachThietBi> DanhSachThietBi { get; set; }
        public DbSet<GiaoVien> GiaoVien { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HocVien> HocVien { get; set; }
        public DbSet<KhoaHoc> KhoaHoc { get; set; }
        public DbSet<KhoaKhaiGiang> KhoaKhaiGiang { get; set; }
        public DbSet<LichKhaiGiang> LichKhaiGiang { get; set; }
        public DbSet<PhongHoc> PhongHoc { get; set; }
        public DbSet<ThietBi> ThietBi { get; set; }
        public DbSet<ThietBiHuHong> ThietBiHuHong { get; set; }


    }
}
