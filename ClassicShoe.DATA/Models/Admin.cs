using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class Admin
    {
        public Guid Id { get; set; }
        public Guid? VaiTroId { get; set; }
        public VaiTro? VaiTro { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

    }
}
