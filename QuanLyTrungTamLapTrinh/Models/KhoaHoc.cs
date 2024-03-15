using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTrungTamLapTrinh.Models
{
    public class KhoaHoc
    {
        [Key]
        public int Id { get; set; }
        public string TenKhoaHoc { get; set; }
        public string? MoTa { get; set; }
        public int HocPhi { get; set; }
        public string? GhiChu { get; set; }
        public string? TinhTrang {  get; set; }
    }
}
