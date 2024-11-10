using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class GiayChiTiet
    {
        public Guid Id { get; set; }
        public Guid DeGiayId { get; set; }
        public DeGiay? DeGiay { get; set; }
        public Guid ThanGiayId { get; set; }
        public ThanGiay? ThanGiay { get; set; }
        public Guid GiayId { get; set; }
        public Giay? Giay { get; set; }
        public Guid MauSacId { get; set; }
        public MauSac? MauSac { get; set; }

        public string TenHang { get; set; }
        public string? BaoHang { get; set; } // Mô tả chi tiết quá trình bảo hành hoặc đổi trả nếu có
        public DateTime NgayNhanKho { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public int TrangThai { get; set; } // (1,2) còn bán và ngừng bán có thể nếu hàng lỗi hoặc gặp vấn đề tương tự



    }
}
