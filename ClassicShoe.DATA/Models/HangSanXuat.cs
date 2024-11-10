using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.DATA.Models
{
    public class HangSanXuat
    {
        public Guid Id { get; set; }
        public ICollection<Giay>? Giays { get; set; }
        public string TenHang { get; set; }
        public string? Logo { get; set; } // URL File
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string DieuKhoan { get; set; } // hoặc là viết trực tiếp hoặc là kiểu để url file điều khoản

    }
}
