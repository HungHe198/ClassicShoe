using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class ThanGiay
    {
        public Guid Id { get; set; }
        public ICollection<GiayChiTiet>? GiayChiTiets { get; set; }
        public string Ten { get; set; }
        public string ChatLieu { get; set; }
        public string ThietKe { get; set; }
        public string? MoTa { get; set; }
    }
}
