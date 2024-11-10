using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class KhachHang
    {
        public Guid Id { get; set; }
        public string TenKhachHang{ get; set; }
        public int DiemTichLuy { get; set; }
        public decimal TongChiTieu { get; set; }
        public string SoDienThoai { get; set; }
        public string? Email { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? DiaChi { get; set; }  // cho các đơn hàng ship cod
        public ICollection<HoaDon>? HoaDons { get; set; } 


    }
}
