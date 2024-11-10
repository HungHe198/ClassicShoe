using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class LoaiGiay
    {
        public Guid Id { get; set; }
        public ICollection<Giay>? Giays { get; set; }
        public string TenLoai { get; set; }
        public string? PhongCach { get; set; }
        public string? MoTa { get; set; }

    }
}
