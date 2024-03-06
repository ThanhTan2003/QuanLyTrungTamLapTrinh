using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTrungTamLapTrinh.Models
{
    public class HoaDon
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("DanhSachDangKy")]
        public int DanhSachDangKy_Id { get; set; }
        public DanhSachDangKy DanhSachDangKy { get; set; }
        public string TenKhoaHoc { get; set; }
        public int SoTien { get; set; }
        public int? GiamGia { get; set; }
        public int TongTien { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string TinhTrang { get; set; }
    }
}
