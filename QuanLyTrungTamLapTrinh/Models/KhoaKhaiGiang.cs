using System.ComponentModel.DataAnnotations;

namespace QuanLyTrungTamLapTrinh.Models
{
    public class KhoaKhaiGiang
    {
        [Key]
        public int Id { get; set; }
        public string TenKhoa { get; set; }
        public string? GhiChu { get; set; }
        public ICollection<LichKhaiGiang> LichKhaiGiang { get; set; }
    }
}
