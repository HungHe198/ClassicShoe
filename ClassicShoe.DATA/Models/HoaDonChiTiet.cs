using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class HoaDonChiTiet
    {
        public Guid Id { get; set; }
        public Guid GiayChiTietId { get; set; }
        public GiayChiTiet? GiayChiTiet { get; set; }
        public Guid HoaDonId { get; set; }
        public HoaDon? HoaDon { get; set; }
        public decimal DonGia { get; set; } // Giá tại thời điểm thêm vào hóa đơn
        public int SoLuong { get; set; }



    }
}
