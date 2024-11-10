using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        public Guid VaiTroId { get; set; }
        public VaiTro? VaiTro { get; set; }
        public string TenNhanVien { get; set; }
        public string TenTaiKhoan{ get; set; }
        public string MatKhau { get; set; }
        public DateTime NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }

    }
}
