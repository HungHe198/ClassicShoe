using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class DeGiay
    {
        public Guid Id { get; set; }
        public string TenDe { get; set; }
        public string? ChatLieu { get; set; }
        public string? CongNghe { get; set; }
        public string? Mota { get; set; }
        public ICollection<GiayChiTiet>? GiayChiTiets { get; set; }

    }
}
