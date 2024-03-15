using System.ComponentModel.DataAnnotations;

namespace QuanLyTrungTamLapTrinh.Models
{
    public class ThietBi
    {
        [Key]
        public int Id { get; set; }
        public string TenTB { get; set; }
        
        public string? MoTa { get; set; }
        public string? GhiChu { get; set; }
        public int? SL { get; set; }
        public string? PhanLoai { get; set; }
    }
}
