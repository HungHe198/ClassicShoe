using ClassicShoe.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.APP.SERVICES
{
    public static class GlobalVariable
    {
        public static Guid UserId = Guid.Empty;
        public static Guid CustomerId = Guid.Empty;
        public static string MaVaiTro = "";
        public static Guid IdHD = Guid.Empty;
        public static KhachHang khachHangNow = new KhachHang();
        

    }
}
