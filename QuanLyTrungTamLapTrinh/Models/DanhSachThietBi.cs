using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QuanLyTrungTamLapTrinh.Models
{
    public class DanhSachThietBi
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PhongHoc")]
        public int PhongHoc_Id { get; set; }
        public PhongHoc PhongHoc { get; set; }

        [ForeignKey("ThietBi")]
        public int ThietBi_Id { get; set; }
        public ThietBi ThietBi { get; set; }
        public int SL { get; set; }
    }
}
