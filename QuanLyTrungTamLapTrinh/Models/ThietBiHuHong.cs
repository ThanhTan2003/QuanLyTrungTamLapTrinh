using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuanLyTrungTamLapTrinh.Models
{
    public class ThietBiHuHong
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ThietBi")]
        public int ThietBi_Id { get; set; }
        public ThietBi ThietBi { get; set; }

        [ForeignKey("PhongHoc")]
        public int PhongHoc_Id { get; set; }
        public PhongHoc PhongHoc { get; set; }
        public string? ViTri {  get; set; }

        public DateTime? NgayPhatHien { get; set; }
        public string? MoTaLoi { get; set; }
        public string? TinhTrang { get; set; } // Ví dụ: Đang sửa, Đã sửa, Cần thay thế
        public DateTime? NgaySuaChua { get; set; } // Nullable, vì có thể chưa được sửa chữa
    }
}
