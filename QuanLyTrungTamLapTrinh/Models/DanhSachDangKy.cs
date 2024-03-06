using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTrungTamLapTrinh.Models
{
    public class DanhSachDangKy
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("LichKhaiGiang")]
        public int LichKhaiGiang_Id { get; set; }
        public LichKhaiGiang LichKhaiGiang { get; set; }
        [ForeignKey("HocVien")]
        public string HocVien_Id { get; set; }
        public HocVien HocVien { get; set; }
        public DateTime NgayDangKy { get; set; }
        public string TinhTrang { get; set; }
    }
}
