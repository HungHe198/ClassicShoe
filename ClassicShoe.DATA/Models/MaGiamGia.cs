using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class MaGiamGia
    {
        // một mã giảm giá có thể áp dụng cho 1 hoặc nhiều hóa đơn
        public Guid Id { get; set; }
        public string TenMaGiamGia{ get; set; } // UPPERCASE và không có dấu không được trùng
        public int PhanTramGiam { get; set; }
        // cần validate để ngày đầu luôn luôn đứng trước ngày kết
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal GT_HoaDonToiThieu { get; set; } // giá trị tối thiểu hóa đơn cần đạt được
        public decimal GT_ToiDaGiam { get; set; } // giá trị tối đa hóa đơn sẽ được giảm
        public string? MoTa { get; set; }

    }
}
