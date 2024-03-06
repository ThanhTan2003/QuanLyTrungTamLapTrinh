using System.ComponentModel.DataAnnotations;

namespace QuanLyTrungTamLapTrinh.Models
{
    public class PhongHoc
    {
        [Key]
        public int Id { get; set; }
        public string TenPhong { get; set; }
        public string? MoTa { get; set; }
        public string? GhiChu { get; set; }
        public ICollection<DanhSachThietBi> DanhSachThietBi { get; set; }
        public ICollection<ThietBiHuHong> ThietBiHuHong { get; set; }
    }
}
