using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTrungTamLapTrinh.Models
{
    public class LichKhaiGiang
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("KhoaKhaiGiang")]
        public int KhoaKhaiGiang_Id { get; set; }
        public KhoaKhaiGiang KhoaKhaiGiang { get; set; }
        [ForeignKey("KhoaHoc")]
        public int KhoaHoc_Id { get; set; }
        public KhoaHoc KhoaHoc { get; set; }
        [ForeignKey("PhongHoc")]
        public int PhongHoc_Id { get; set; }
        public PhongHoc PhongHoc { get; set; }
        [ForeignKey("GiaoVien")]
        public string GiaoVien_Id { get; set; }
        public GiaoVien GiaoVien { get; set; }
        public int SoBuoiHoc { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public int? SoLuongDK { get; set; }
        public string NgayHoc { get; set; }
        public string? GhiChu {  get; set; }
        public ICollection<DanhSachDangKy> DanhSachDangKy { get; set; }
    }
}
