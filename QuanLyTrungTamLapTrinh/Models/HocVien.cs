using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QuanLyTrungTamLapTrinh.Models
{
    public class HocVien
    {
        [Key]
        public string Id { get; set; }

        public string HoTen { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string SoDT { get; set; }

        [DataType(DataType.EmailAddress)]
        public string ? Email { get; set; }
        public string ? DiaChi { get; set; }
        public string ? GhiChu { get; set; }
        public string ? TinhTrang { get; set; }
        public string ? HinhAnh {  get; set; }
        ICollection<DanhSachDangKy> DanhSachDangKy { get; set; }
    }
}
