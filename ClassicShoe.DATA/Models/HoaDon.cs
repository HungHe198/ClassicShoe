using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public ICollection<HoaDonChiTiet>? HoaDonChiTiets { get; set; }
        public Guid NhanVienId { get; set; }
        public NhanVien? NhanVien { get; set; }
        public Guid KhachHangId { get; set; }
        public KhachHang? KhachHang { get; set; }
        public Guid MaGiamGiaId { get; set; }
        public MaGiamGia? MaGiamGia { get; set; }
        public DateTime NgayTaoHoaDon { get; set; }
        public decimal ThanhTien { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public int Status { get; set; } // 1,2,3,4 *(Chờ xác nhận, chờ thanh toán, thanh toán thành công, đã hủy ) // lọc theo combobox

    }
}
