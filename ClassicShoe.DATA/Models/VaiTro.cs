using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class VaiTro
    {
        public Guid Id{ get; set; }
        public ICollection<Admin>? Admins { get; set; }
        public ICollection<NhanVien>? NhanViens { get; set; }
        public string TenVaiTro { get; set; }
        public string MaVaiTro { get; set; }

    }
}
