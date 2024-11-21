using ClassicShoe.DATA.Models;
using ClassicShoe.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicShoe.APP.SERVICES
{
    public class NhanVienServices
    {
        AllRepositories<NhanVien> _repo = new AllRepositories<NhanVien>(new ClassicShoeDbContext());  
        
        
    
    }
}
