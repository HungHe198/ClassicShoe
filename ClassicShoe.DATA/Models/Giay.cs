using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class Giay
    {
        public Guid Id { get; set; }
        public ICollection<GiayChiTiet>? GiayChiTiets { get; set; }
        public Guid LoaiGiayId { get; set; }
        public LoaiGiay? LoaiGiay { get; set; }
        public Guid HangSanXuatId { get; set; }
        public HangSanXuat? HangSanXuat { get; set; }
        public int TrangThai { get; set; } // 1còn bán, 2ngừng bán
    }
}
